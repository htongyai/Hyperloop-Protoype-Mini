#include <SPI.h>



/*  ***************************************
    Arduino Pin connections： This assigns
    Pin 13 Ard is connected to 11 74HC595 IC (SRCK)
    Pin 11 Ard is connected to 14 74HC595 IC(data) 
    Pin 10 Ard is connected to 12 74HC595 IC (latch)  
    *************************************** */
    int numbers[10] = {63, 6, 91, 79, 102, 109, 125, 7, 127, 103};
    int receivedVal;
    volatile int exitStatus;
    int LED = 4;
   
       



void setup() 
{
  SPI.begin();    //sets SS, SRK and MOSI to output; SCK and MOSI low; SS high
//
SPI.setFrequency(1000000);
 // pinMode(LED,OUTPUT);
 // digitalWrite(3,HIGH); 
//  attachInterrupt(digitalPinToInterrupt(3), interruptRoutine, CHANGE); 
  //Serial.begin(9600); 
}

void loop() 
{
    delay(3000);
    
    exitStatus = 0;
    digitalWrite(LED,LOW);
/*  *************************************
    Actual shifiting out onto the 595 IC.
    This code is set up for two 7 segment
    displays connected together in series
    via two ICs.
    ********************************************************
    |f| == minutes |e|d| == seconds |c|b|a| === milliseconds
    ******************************************************** */
    for(int f=0;f<10;f++)   //minutes                                            
    {  
      for(int e=0;e<6;e++)  //tens of seconds
      {    
        for(int d=0;d<10;d++)  //seconds
        {
          for(int c=0;c<10;c++) //100s of milliseconds
          {
            for(int b=0;b<10;b++) //10s of milliseconds
            {
              for(int a=0;a<10;a++) //milliseconds
              { 
                             
               display(a,b,c,d,e,f);
               delayMicroseconds(965);
               if(exitStatus == 1){goto loopExit;}
               

              }
            }   
          }
        }
      }
    }

  loopExit:  delay(5000);

}//end arduino loop

void display(int a, int b, int c, int d, int e, int f)
{
    
    SPI.beginTransaction(SPISettings(25000000,MSBFIRST,SPI_MODE3));
    digitalWrite(SS, LOW);      //SS Low: Changes in values stored in 74HC595 IC are not displayed on 7 segment displays
    
    receivedVal  = SPI.transfer(numbers[a]);
    receivedVal  = SPI.transfer(numbers[b]);
    receivedVal  = SPI.transfer(numbers[c]);
    receivedVal  = SPI.transfer(numbers[d]);
    receivedVal  = SPI.transfer(numbers[e]);
    receivedVal  = SPI.transfer(numbers[f]);
                
    digitalWrite(SS, HIGH);
    SPI.endTransaction();
    return;

}


void interruptRoutine()
{
  if (digitalRead(3) == LOW)
  { 
    exitStatus = 1;
    digitalWrite(LED,HIGH);
  }
  else
  { 
    exitStatus = 0;
    digitalWrite(LED,LOW);
  }
   
}



