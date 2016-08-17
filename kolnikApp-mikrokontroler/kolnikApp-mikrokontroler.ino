#include "MAX6675-library-master/max6675.h"
String inputString = "";
const int thermo_gnd_pin = 2;
const int thermo_vcc_pin = 3;
const int thermo_so_pin = 4;
const int thermo_cs_pin = 5;
const int thermo_sck_pin = 6;

MAX6675 thermocouple(thermo_sck_pin, thermo_cs_pin, thermo_so_pin);

void setup() {
	Serial.begin(9600);
	while (!Serial) {
		;
	}
	inputString.reserve(200);
	pinMode(thermo_vcc_pin, OUTPUT);
	pinMode(thermo_gnd_pin, OUTPUT);
	digitalWrite(thermo_vcc_pin, HIGH);
	digitalWrite(thermo_gnd_pin, LOW);
}

void loop() {

}

void VehicleHasArrived() {
	//-ako je detektor primio signal && prisutnostVozila==false
	//  -odspavaj otprilike jednu sekundu (na taj nacin se ignoriraju smetnje poput prolaska covjeka ili ptice izmedju lasera i detektora)
	//  -ako je opet detektor primio signal
	//    -prisutnostVozila = true
	//    -Serial.println(
	//-inace ako detektor nije primio signal && prisutnostVozila==true
	//  -odspavaj otprilike dvije sekunde (na taj nacin se ignorira moguc prolazak snopa svjetlosti lasera kroz kabinu vozila ili prolaz svjetlosti kroz prostor izmedju kabine i sanduka)
	//  -ako detektor opet nije primio signal
	//    -prisutnostVozila = false
}

void serialEvent() {
	ReadLineOverSerialCommunication();
}

void ReadLineOverSerialCommunication() {
	while (Serial.available()) {
		char primljenoSlovo = (char)Serial.read();
		if (primljenoSlovo != '\n') {
			inputString += primljenoSlovo;
		}
		else {
			if (DoesStringStartWithNeedle(inputString.c_str(), "temperatura")) {
				String newNeedle = "OIB=";
				int newNeedlePos = inputString.indexOf(newNeedle);
				if (newNeedlePos != -1) {
					String oibPrimatelja = inputString.substring(newNeedlePos + newNeedle.length());
					Serial.println("TMP=" + String(thermocouple.readCelsius()) + "&OIB=" + oibPrimatelja);
				}
			}
			inputString = "";

		}
	}
}

bool DoesStringStartWithNeedle(const char* pre, const char* str) {
	size_t lenpre = strlen(pre), lenstr = strlen(str);
	return lenstr < lenpre ? false : strncmp(pre, str, lenpre) == 0;
}

