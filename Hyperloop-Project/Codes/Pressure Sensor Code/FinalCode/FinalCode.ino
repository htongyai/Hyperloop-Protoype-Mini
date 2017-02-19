//Design and Build 
//Final code for the pressure sensor and the side in which the hit was made 


int PS1AnalogPin = 0; // PS1 is connected to analog 0
int PS2AnalogPin = 1; //  PS2 is connected to analog 0 
int LED1pin = 11;     // connect Red LED to pin 11 (PWM pin)
int LED2pin = 12;     // connect Yellow LED to pin 12 (PWM pin)
int PS1Reading;      // the analog reading from the FSR resistor divider
int PS2Reading;      // the analog reading from the FSR resistor
int PS1ToPrint = 0;
int PS2ToPrint = 0;
int PS1Min = 0;
int PS1Max = 1023;
int PS2Min = 0;
int PS2Max = 1023;


void setup() {  
 Serial.begin(9600);
 pinMode(LED1pin,OUTPUT);
 pinMode(LED2pin,OUTPUT);
}

void loop() {

  // For Pressure sensor 1
  
  PS1Reading = analogRead(PS1AnalogPin);
  PS1Reading = map(PS1Reading,PS1Min,PS1Max, 0.0,10.0);
  PS1Reading = constrain(PS1Reading, 0.0, 10.0);
  if(PS1Reading != 0){
      PS1ToPrint = PS1Reading;
    }
  Serial.print("Pressure1 = ");
  Serial.println(PS1ToPrint);
  Serial.println(" ");

  // For  Pressure sensor 2
  
  PS2Reading = analogRead(PS2AnalogPin);
  PS2Reading = map(PS2Reading,PS2Min,PS2Max, 0.0,10.0);
  PS2Reading = constrain(PS2Reading, 0.0, 10.0);
  if(PS2Reading != 0){
      PS2ToPrint = PS2Reading;
    }
  Serial.print("Pressure2 = ");
  Serial.println(PS2ToPrint);
  Serial.println(" ");
  
  // For the LEDS
  
  if (PS1Reading > PS2Reading){
    while (PS1Reading != 0){
   digitalWrite(11, HIGH);
   digitalWrite(12, LOW);
    }
  }
  else if (PS1Reading < PS2Reading) {
    while (PS2Reading != 0){
   digitalWrite(12, HIGH);
   digitalWrite(11, LOW);
    }
  }
  else {
    digitalWrite(12, LOW);
    digitalWrite(11, LOW);
    
  }
  delay (500);
}


