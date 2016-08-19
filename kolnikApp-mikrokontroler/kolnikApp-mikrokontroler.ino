#include "Arduino-IRremote-master/IRremote.h"
#include "Arduino-IRremote-master/IRremoteInt.h"
#include "Arduino-IRremote-master/ir_Lego_PF_BitStreamEncoder.h"
#include "MAX6675-library-master/max6675.h"

//const uint8_t thermoGNDPin = 2;
//const uint8_t thermoVCCPin = 3;
const uint8_t thermoSOPin = 8;
const uint8_t thermoCSPin = 9;
const uint8_t thermoSCKPin = 10;
const uint8_t IRRecvPin = 4;
const uint32_t frequencyOfInfraredLEDInHertz = 38000;
const uint32_t timePeriodBetween2AdjacentLEDEmissionsInMicroseconds = (1. / frequencyOfInfraredLEDInHertz) * 1000000;

unsigned long startTimeOfCurrentMeasuring = 0;
String inputString = "";
MAX6675 thermocoupleHandler(thermoSCKPin, thermoCSPin, thermoSOPin);
IRrecv irrecv(IRRecvPin);
decode_results results;
bool vehicleIsHere = false;

inline bool IsObstacleBetweenDiodeAndReceiver()
{
	return !irrecv.decode(&results);
}

void ListenForInfraredSignal()
{
	//-ako detektor nije primio signal && prisutnostVozila==false
	//  -odspavaj otprilike jednu sekundu (na taj nacin se ignoriraju smetnje poput prolaska covjeka ili ptice izmedju lasera i detektora)
	//  -ako detektor opet nije primio signal
	//    -prisutnostVozila = true
	//    -Serial.println("poruka")
	//-inace ako je detektor primio signal && prisutnostVozila==true
	//  -odspavaj otprilike dvije sekunde (na taj nacin se ignorira moguc prolazak snopa svjetlosti lasera kroz kabinu vozila ili prolaz svjetlosti kroz prostor izmedju kabine i sanduka)
	//  -ako je detektor opet primio signal
	//    -prisutnostVozila = false
	if (!startTimeOfCurrentMeasuring)
	{
		if (!vehicleIsHere)
		{
			if (IsObstacleBetweenDiodeAndReceiver())
			{
				startTimeOfCurrentMeasuring = millis();
			}
		}
		else
		{
			if (!IsObstacleBetweenDiodeAndReceiver())
			{
				startTimeOfCurrentMeasuring = millis();
			}
		}
	}
	else
	{
		if (!vehicleIsHere)
		{
			if (millis() - startTimeOfCurrentMeasuring >= 1000)
			{
				startTimeOfCurrentMeasuring = 0;
				delayMicroseconds(timePeriodBetween2AdjacentLEDEmissionsInMicroseconds);
				if (IsObstacleBetweenDiodeAndReceiver())
				{
					vehicleIsHere = true;
					Serial.println("NOTIFY");
				}
			}
		}
		else
		{
			if (millis() - startTimeOfCurrentMeasuring >= 2000)
			{
				irrecv.resume();
				startTimeOfCurrentMeasuring = 0;
				delayMicroseconds(timePeriodBetween2AdjacentLEDEmissionsInMicroseconds);
				if (!IsObstacleBetweenDiodeAndReceiver())
				{
					vehicleIsHere = false;
					irrecv.resume();
				}
			}
		}
	}
}

void setup()
{
	Serial.begin(9600);
	while (!Serial)
	{
		;
	}
	irrecv.enableIRIn();
	inputString.reserve(200);
	/*
	pinMode(thermoVCCPin, OUTPUT);
	pinMode(thermoGNDPin, OUTPUT);
	digitalWrite(thermoVCCPin, HIGH);
	digitalWrite(thermoGNDPin, LOW);
	*/
}

void loop()
{
	ListenForInfraredSignal();
}

void serialEvent()
{
	ReadLineOverSerialCommunication();
}

void ReadLineOverSerialCommunication()
{
	while (Serial.available())
	{
		char primljenoSlovo = (char)Serial.read();
		if (primljenoSlovo != '\n')
		{
			inputString += primljenoSlovo;
		}
		else
		{
			if (DoesStringStartWithNeedle(inputString.c_str(), "temperatura"))
			{
				String newNeedle = "OIB=";
				int newNeedlePos = inputString.indexOf(newNeedle);
				if (newNeedlePos != -1)
				{
					String oibPrimatelja = inputString.substring(newNeedlePos + newNeedle.length());
					Serial.println("TMP=" + String(thermocoupleHandler.readCelsius()) + "&OIB=" + oibPrimatelja);
				}
			}
			inputString = "";

		}
	}
}

bool DoesStringStartWithNeedle(const char* pre, const char* str)
{
	size_t lenpre = strlen(pre), lenstr = strlen(str);
	return lenstr < lenpre ? false : strncmp(pre, str, lenpre) == 0;
}

