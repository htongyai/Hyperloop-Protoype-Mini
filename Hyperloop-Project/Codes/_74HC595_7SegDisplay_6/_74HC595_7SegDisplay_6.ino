#include <SPI.h>

/*  ********************************************
    Arduino Pin connections：(These pins can't be changed)
    Pin 13 Ard is connected to 11 74HC595 (SRK)
    Pin 11 Ard is connected to 14 74HC595 (MOSI) 
    Pin 10 Ard is connected to 12 74HC595 (SS)  
    ********************************************* */
    int numbers[10] = {63, 6, 91, 79, 102, 109, 125, 7, 127, 103};
    int receivedVal;            //IGNORE
    int LED = 4;
    volatile int exitStatus;    //If 1, timer loop is exited (timer stops). If 0, nothing. 
                                //exitStatus value is input during an interrupt which occurs when a switch/vest/e.t.c is pressed.
    
   
       
void setup() 
{
  SPI.begin();                 //sets pins 10, 13 and 11 to output; 11 LOW; 10 HIGH
  pinMode(LED,OUTPUT);
  digitalWrite(3,LOW);       //PIN 3 is set high. When a change occurs from HIGH to LOW or LOW to HIGH, an Interrupt service routine is run    
  attachInterrupt(digitalPinToInterrupt(3), interruptRoutine, CHANGE);    //If there is a CHANGE in PIN 3, run interruptRoutine
  //Serial.begin(9600); 
}

void loop() 
{
    delay(3000);
    exitStatus = 0;
    digitalWrite(LED,LOW);

/*  ********************************
    Time keeping done here
 *  ******************************** */
    
    for(int f=0;f<10;f++){             //minutes                                              
      for(int e=0;e<6;e++){            //10s of seconds    
        for(int d=0;d<10;d++){         //seconds  
          for(int c=0;c<10;c++){       //100s of milliseconds
            for(int b=0;b<10;b++){     //10s of milliseconds
              for(int a=0;a<10;a++){   //milliseconds
                                             
               display(a,b,c,d,e,f);
               delayMicroseconds(965);
               if(exitStatus == 1){goto loopExit;}

              }
            }   
          }
        }
      }
    }
//  Endd time keeping


/*  ********************************************
    Put code to execute when an interrupt occurs
    after loopExit.    
 *  ******************************************** */
    loopExit:  delay(5000);

}//end arduino loop




/*  **********************************************
    Function to display values on the 7 seg displays.
    Can be reused to dislpay scores, e.t.c   
 *  ********************************************** */
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
  if (digitalRead(3) == HIGH)
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



