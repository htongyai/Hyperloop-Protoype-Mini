
/*  ***************************************
    Arduino Pin connections： This assigns
    integer variables to Arduino pins 2,3,5.
    Pin 2 Ard is connected to 12 74HC595 IC 
    Pin 3 Ard is connected to 14 74HC595 IC 
    Pin 5 Ard is connected to 11 74HC595 IC   
    *************************************** */
    int latchPin = 2;
    int dataPin = 3;
    int clockPin = 5;
    //End Pin connections

    int numbers[10] = {63, 6, 91, 79, 102, 109, 125, 7, 127, 103};
    int minutes, seconds, millisec; 
    double leapMilli = 0;
    double time1,time2;
    double timeCount = 0;
    



void setup() 
{
/*  ***********************************************
    Pins are set to output, to control shif register. 
    *********************************************** */
    pinMode(latchPin, OUTPUT);
    pinMode(clockPin, OUTPUT);
    pinMode(dataPin, OUTPUT);
    //End Setup
    Serial.begin(9600);
}

void loop() 
{
    delay(3000);
/*  *************************************
    Actual shifiting out onto the 595 IC.
    This code is set up for two 7 segment
    displays connected together in series
    via two ICs.
    ********************************************************
    |f| == minutes |e|d| == seconds |c|b|a| === milliseconds
    ******************************************************** */
    //time1 = millis();
    for(int f=0;f<10;f++)                                             
    {
      for(int e=0;e<6;e++)
      {
        for(int d=0;d<10;d++)
        {
          for(int c=0;c<10;c++)
          {
            for(int b=0;b<10;b++)
            {
              for(int a=0;a<10;a++)
              { 
                time1 = micros();
                digitalWrite(latchPin, LOW);      //LatchPin Low: Changes in values stored in 74HC595 IC are not displayed on 7 segment displays
                digitalWrite(clockPin, LOW);                                        
                shiftOut(dataPin, clockPin, MSBFIRST,numbers[a]);     //Least significant number goes to the last IC in the series
                shiftOut(dataPin, clockPin, MSBFIRST,numbers[b]);
                shiftOut(dataPin, clockPin, MSBFIRST,numbers[c]);
                shiftOut(dataPin, clockPin, MSBFIRST,numbers[d]);
                shiftOut(dataPin, clockPin, MSBFIRST,numbers[e]);
                shiftOut(dataPin, clockPin, MSBFIRST,numbers[f]);     //Most significant number goes to first IC in the series

                /*
                minutes = f;
                seconds = (e*10 + d);
                millisec =(c*100 + b*10 + a); 
                */ 
                
                digitalWrite(latchPin, HIGH);
                //time2 = micros();
                leapMilli = leapMilli + (micros()-time1) - 1000;
                if(leapMilli>=1000)
                {
                  a = a + 1;
                  leapMilli = 285.9;
                }
                //break;
                //Serial.println(time1);   
                //delayMicroseconds(1000);    

              }
             // break;
            }
           // break;
          }
          //break;
        }
        //break;
      }
     // break;
    }  
}

