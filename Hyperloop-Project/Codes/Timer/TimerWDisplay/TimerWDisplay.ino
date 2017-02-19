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
    int startButton = 4;
    //End Pin connections

    //Timer  
    int i, j, k;
    int checkState = 0;
    int miliSec =0;
    int tMiliSec =0;

void setup() {
  // put your setup code here, to run once:
  //Timer Setup
   miliSec =0;
   tMiliSec =0;
   displayShow(miliSec,tMiliSec);
     //Input
  pinMode(4, INPUT);
  //End Timer Setup
  

  //Display Setup
    pinMode(latchPin, OUTPUT);
    pinMode(clockPin, OUTPUT);
    pinMode(dataPin, OUTPUT);
  //End DIsplay Setup

}
//Main Process==============================================================================
void loop() {
  boolean buttonState = digitalRead(4);
  
  if (buttonState){
  // put your main code here, to run repeatedly:
     if (checkState==0){
        timer1();
     }
    
    
  }
  
  
}
//End Main===================================================================================


int timer1(){
      for (int j=1;j<=100;j++){
         if (checkState==1){
                  break;
          }
            for (int i=1;i<=10;i++){
              //check();
               if (checkState==1){
                  break;
                }
              miliSec++;
              int a;
              int b;
              
              if (miliSec<=9){
                a = tMiliSec;    
                b = miliSec;
              }else if(i>9){
                if (tMiliSec >9){
                  tMiliSec = 0;
                }else{
                tMiliSec++;
                }
                miliSec = 0;
                a = tMiliSec;
                b = miliSec;
              }
              
              displayShow(a,b);
            }
        } 
}


int displayShow(int a, int b){
  
/*  ***************************  
    Variable declarations
    ***************************
    7 segment eqivalents of 0 - 9 
    are stored in an array.
    *************************** */
    
    int numbers[10] = {63, 6, 91, 79, 102, 109, 125, 7, 127, 103};
    
    //End declarations

    
/*  **************************** 
    code below shifts bits out 
    onto 74HC595 IC
    *************************** */
    digitalWrite(latchPin, LOW);      //LatchPin Low: Changes in values stored in 74HC595 IC are not displayed on 7 segment displays
    digitalWrite(clockPin, LOW);      //ClockPin Low: No data is loaded onto the 74HC595 IC

/*  *************************************
    Actual shifiting out onto the 595 IC.
    This code is set up for two 7 segment
    displays connected together in series
    via two ICs.
    ************************************* */

    
    shiftOut(dataPin, clockPin, MSBFIRST,numbers[b]);     //Least significant number goes to the last IC in the series
    shiftOut(dataPin, clockPin, MSBFIRST,numbers[a]);     //Most significant number goes to first IC in the series
   
/*  ***************************************   
    Display the values that were shifted
    into the ICs on the 7 segment displays
    *************************************** */
    digitalWrite(latchPin, HIGH);     //LatchPin High: Changes in values stored in 74HC595 IC are displayed on 7 segment displays
    delay(100);                       //Pause before the next display value. Not required for this code
  
}
