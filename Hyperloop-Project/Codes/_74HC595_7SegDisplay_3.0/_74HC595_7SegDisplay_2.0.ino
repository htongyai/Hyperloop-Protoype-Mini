
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



void setup() 
{
/*  ***********************************************
    Pins are set to output, to control shif register. 
    *********************************************** */
    pinMode(latchPin, OUTPUT);
    pinMode(clockPin, OUTPUT);
    pinMode(dataPin, OUTPUT);
    //End Setup
}

void loop() 
{
/*  ***************************  
    Variable declarations
    ***************************
    7 segment eqivalents of 0 - 9 
    are stored in an array.
    *************************** */
    

    
    //End declarations

    
/*  **************************** 
    code below shifts bits out 
    onto 74HC595 IC
    *************************** 
    digitalWrite(latchPin, LOW);      //LatchPin Low: Changes in values stored in 74HC595 IC are not displayed on 7 segment displays
    digitalWrite(clockPin, LOW);      //ClockPin Low: No data is loaded onto the 74HC595 IC

/*  *************************************
    Actual shifiting out onto the 595 IC.
    This code is set up for two 7 segment
    displays connected together in series
    via two ICs.
    ********************************************************
    |f| == minutes |e|d| == seconds |c|b|a| === milliseconds
    ******************************************************** */
   /* for(int f=0;f<10;f++)                                             
    {
      for(int e=0;e<6;e++)
      {
        for(int d=0;d<10;d++)
        {
          for(int c=0;c<10;c++)
          {*/
            for(int b=0;b<10;b++)
            {
              for(int a=0;a<10;a++)
              { 
                digitalWrite(latchPin, LOW);      //LatchPin Low: Changes in values stored in 74HC595 IC are not displayed on 7 segment displays
                digitalWrite(clockPin, LOW);                                        
                shiftOut(dataPin, clockPin, MSBFIRST,numbers[a]);     //Least significant number goes to the last IC in the series
                shiftOut(dataPin, clockPin, MSBFIRST,numbers[b]);
                digitalWrite(latchPin, HIGH);   
                delay(100);    
            /*    shiftOut(dataPin, clockPin, MSBFIRST,numbers[c]);
                shiftOut(dataPin, clockPin, MSBFIRST,numbers[d]);
                shiftOut(dataPin, clockPin, MSBFIRST,numbers[e]);
                shiftOut(dataPin, clockPin, MSBFIRST,numbers[f]);     //Most significant number goes to first IC in the series
                delay(1);                                             //More accurately will be to subtract time taken to execute the code below from delay */
              }
            }
       /*   }
        }
      }
    }*/

/*  ***************************************   
    Display the values that were shifted
    into the ICs on the 7 segment displays
    *************************************** */
    //digitalWrite(latchPin, HIGH);     //LatchPin High: Changes in values stored in 74HC595 IC are displayed on 7 segment displays
    //delay(1000);                       //Pause before the next display value. Not required for this code
  
}

