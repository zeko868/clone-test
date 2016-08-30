#include "MAX6675-library-master/max6675.h"

const uint8_t thermoSOPin = 8;
const uint8_t thermoCSPin = 9;
const uint8_t thermoSCKPin = 10;
const uint8_t photocellPin = 0;
const unsigned short photocellAnalogValueTreshold = 500;

unsigned long startTimeOfCurrentMeasuring = 0;
String inputString = "";
MAX6675 thermocoupleHandler(thermoSCKPin, thermoCSPin, thermoSOPin);

bool vehicleIsHere = false;

inline bool IsObstacleBetweenDiodeAndReceiver()
{
	return analogRead(photocellPin) < photocellAnalogValueTreshold ? true : false;
}

void ListenForInfraredSignal()
{
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
				delayMicroseconds(100);
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
	
				startTimeOfCurrentMeasuring = 0;
				delayMicroseconds(100);
				if (!IsObstacleBetweenDiodeAndReceiver())
				{
					vehicleIsHere = false;
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

	inputString.reserve(100);
}


void serialEvent()
{
	ReadLineOverSerialCommunication();

	if (DoesStringStartWithNeedle("temperatura", inputString.c_str()))
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

inline void ReadLineOverSerialCommunication()
{
	inputString += Serial.readString();
	inputString.trim();
}

inline bool DoesStringStartWithNeedle(const char* pre, const char* str)
{
	size_t lenpre = strlen(pre), lenstr = strlen(str);
	return lenstr < lenpre ? false : strncmp(pre, str, lenpre) == 0;
}

void loop()
{
	ListenForInfraredSignal();
	delay(100);
}
