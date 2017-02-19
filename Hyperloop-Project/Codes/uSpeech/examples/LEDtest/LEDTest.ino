
#include "uspeech.h"
#define led 13
signal voice(A0);
String collvoice;
char prev;
boolean newline=false;
int sum = 0;
void setup(){
  voice.f_enabled = false; //not trying to detect /f/s
  voice.minVolume = 1500; //max volume power that should be considered
  voice.fconstant = 400;  //power threshold for f
  voice.econstant = 1;    //power threshold for e/i
  voice.aconstant = 2;    //power threshold for a/o/r/l/
  voice.vconstant = 3;
  voice.shconstant = 4;
  voice.calibrate();
  Serial.begin(9600);
  pinMode(led, OUTPUT); 
}

void loop(){
    voice.sample();
    /*void signal::sample(){
      int i = 0;
      while ( i < 32){
      #ifdef ARDUINO_ENVIRONMENT
        arr[i] = (analogRead(pin)*scale-calib);
      #endif
        i++;
    }*/
    voice.maxPower();
    char p = voice.getPhoneme();
        
    if(p!=' '){
      if((p=='o')){   //tryinging to detect 'a','o','i','r','l','m','n' and 'u' sounds. keyword is 'alle'
          newline = true;
      }
      else{
          
          newline = false;
      }
    }
    else{
      if(newline){
        digitalWrite(led, LOW);
      }
      else{
        digitalWrite(led, HIGH);
      }
    }
}
