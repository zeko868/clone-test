#include "MAX6675-library-master/max6675.h"

/// <summary>
/// Broj pina na koji je spojena �ica za serijski izlaz podataka (SO) temperaturne sonde
/// </summary>
const uint8_t thermoSOPin = 8;

/// <summary>
/// Broj pina na koji je spojena �ica za odabira �ipa (CS) temperaturne sonde
/// </summary>
const uint8_t thermoCSPin = 9;

/// <summary>
/// Broj pina na koji je spojena �ica za serijski ulaz podataka (SCK) temperaturne sonde
/// </summary>
const uint8_t thermoSCKPin = 10;

/// <summary>
/// Broj pina na koji je spojena �ica za i��itavanje intenziteta svjetlosti zaprimljene od foto�elije
/// </summary>
const uint8_t photocellPin = 0;

/// <summary>
/// Predefinirani prag detektiranog intenziteta svjetlosti ispod kojeg se i��itana analogna svjetlost smatra odsustvom, a iznad prisustvom svjetla
/// </summary>
const unsigned short defaultPhotocellAnalogValueTreshold = 500;

/// <summary>
/// Analogna vrijednost i��itana prilikom zadnje kalibracije ure�aja pri odsustvu svjetlosti
/// </summary>
unsigned short lowAnalogValue = 250;

/// <summary>
/// Analogna vrijednost i��itana prilikom zadnje kalibracije ure�aja pri prisustvu svjetlosti
/// </summary>
unsigned short highAnalogValue = 750;

/// <summary>
/// Analogna vrijednost praga ispod kojeg se i��itane analogne vrijednosti smatraju odsustvom svjetlosti, a iznad prisustvom svjetlosti
/// </summary>
unsigned short photocellAnalogValueTreshold = defaultPhotocellAnalogValueTreshold;

/// <summary>
/// Broj milisekundi proteklih nakon po�etka mjerenja vremena
/// </summary>
unsigned long startTimeOfCurrentMeasuring = 0;

/// <summary>
/// Zaprimljen znakovni niz putem serijske komunikacije
/// </summary>
String inputString = "";

/// <summary>
/// Objekt za manipulaciju s temperaturnom sondom s definiranim proslije�enim parametrima
/// </summary>
MAX6675 thermocoupleHandler(thermoSCKPin, thermoCSPin, thermoSOPin);

/// <summary>
/// Je li pristiglo vozilo na mjesto o�itavanja prisutnosti ili nije
/// </summary>
bool vehicleIsHere = false;

/// <summary>
/// Provjerava postojanost prepreke izme�u izvora svjetlosti i senzora svjetlosnog signala
/// </summary>
/// <returns>Istina ukoliko se nalazi prepreka izme�u izvora svjetlosti i senzora, odnosno ukoliko signal nije pristigao na odredi�te</returns>
inline bool IsObstacleBetweenDiodeAndReceiver()
{
	return analogRead(photocellPin) < photocellAnalogValueTreshold ? true : false;
}

/// <summary>
/// I��itava intenzitet svjetlosti detektiran od strane foto�elije
/// </summary>
void ListenForLaserBeam()
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
				if (!IsObstacleBetweenDiodeAndReceiver())
				{
					vehicleIsHere = false;
				}
			}
		}
	}
}

/// <summary>
/// Izvodi definirane naredbe prilikom pokretanja samog ure�aja
/// </summary>
void setup()
{
	Serial.begin(9600);
	while (!Serial)
	{
		;
	}

	inputString.reserve(100);
}

/// <summary>
/// Obrada podataka zaprimljenih putem serijske komunikacije nakon �to je okinut doga�aj istoga
/// </summary>
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
	else if (DoesStringStartWithNeedle("calibrate ", inputString.c_str()))
	{
		const byte offset = strlen("calibrate ");
		if (inputString.substring(offset) == "low")
		{
			lowAnalogValue = analogRead(photocellPin);
			photocellAnalogValueTreshold = (highAnalogValue + lowAnalogValue) / 2;
		}
		else if (inputString.substring(offset) == "high")
		{
			highAnalogValue = analogRead(photocellPin);
			photocellAnalogValueTreshold = (highAnalogValue + lowAnalogValue) / 2;
		}
		else
		{
			photocellAnalogValueTreshold = defaultPhotocellAnalogValueTreshold;
		}
		Serial.println(photocellAnalogValueTreshold);
	}
	inputString = "";
}

/// <summary>
/// I��itava podatke zaprimljene putem serijske komunikacije i pohranjuje u globalnu varijablu
/// </summary>
inline void ReadLineOverSerialCommunication()
{
	inputString += Serial.readString();
	inputString.trim();
}

/// <summary>
/// Provjerava po�inje li drugi proslije�eni znakovni niz s prvim proslije�enim znakovnim nizom
/// </summary>
/// <param name="pre">Znakovni niz s kojim se vr�i ispitivanje</param>
/// <param name="str">Znakovni niz na kojem se provjerava po�etni dio</param>
/// <returns>Istina ukoliko drugi znakovni niz po�inje s prvim; ina�e neistina</returns>
inline bool DoesStringStartWithNeedle(const char* pre, const char* str)
{
	size_t lenpre = strlen(pre), lenstr = strlen(str);
	return lenstr < lenpre ? false : strncmp(pre, str, lenpre) == 0;
}

/// <summary>
/// Izvodi definirane naredbe kontinuirano nakon �to se ure�aj pokrene
/// </summary>
void loop()
{
	ListenForLaserBeam();
	delay(100);
}
