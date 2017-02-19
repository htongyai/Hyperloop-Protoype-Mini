/***********************************************************
* Timerr
* Design & Build Project  
* Group 9
* Last Edit 03/02/16
***********************************************************/
 //Initialization
 int i, j, k;
 int minute = 60;
 int record = 0;
 int minuteCheck = 0;
 int checkState = 0;

void setup() {
  // put your setup code here, to run once:
  //Serial Conenction 
  Serial.begin(9600);
  //Input
  pinMode(2, INPUT);
  pinMode(7, INPUT);
  //Output
  pinMode(4, OUTPUT);
  pinMode(5, OUTPUT);
  //Minute Indicator
  pinMode(10, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(12, OUTPUT);
  Serial.println("Initialization Completed");
}
//Void loop----------------------------------------------------------------------------------------------------------------------==============================================
void loop() {
// put your main code here, to run repeatedly:
//Set Read
boolean buttonState = digitalRead(2);
boolean buttonState7 = digitalRead(7);
//Button Pressed--------------------------------------------------------------
  if (buttonState){
    Serial.println("Timer Started:");
    digitalWrite(4,HIGH);
   
    for (k=0;k<3;k++){  
       minCount();   
       if (k == 1){
              digitalWrite(10, HIGH);
       }else if (k == 2){
              digitalWrite(11, HIGH);
       }else if(k == 3){
              digitalWrite(12, HIGH);
       }
    }
    result();
    resetAll();          
}
//End Button Pressed--------------------------------------------------------------
//Return all the Timer value to Default
}//End void loop
//Void Loop----------------------------------------------------------------------------------------------------------------------==============================================

//Functions----------------------------------------------------------------------------------------------------------------------==============================================
int minCount(){
  for (j=0;j<60;j++){
                if (checkState==1){
                  break;
              }
              secCount();
            //1 Minute Checkpoint
                   if (record == 60){
                     minuteCheck++;
                     break;
                    }//Break 1 Minute Loop 
              }//End of 1 minute loop
              j=0;
}
int secCount(){
 for (i=1; i <= 100; i++){
          check();
          if (checkState==1){
            break;
          }
          digitalWrite(5, HIGH);
          Serial.println(i);
          digitalWrite(5, LOW);
          delay(10);     
       }
}

int check(){
    boolean buttonState7 = digitalRead(7);
    if (buttonState7 == HIGH){
      digitalWrite(9, HIGH);  
      checkState = 1;
    } 
}

int result(){
  digitalWrite(12, HIGH);
  Serial.println("MNM:SS:mm");
  if(k <=9){
  Serial.print("0");  
  }
  Serial.print(k);
  Serial.print(":");
  if(j <=9){
  Serial.print("0");  
  }
  Serial.print(j);
  Serial.print(":");
  if(i <=9){
  Serial.print("0");  
  }
  Serial.print(i);
}

void resetAll(){
i = 0;
j = 0;
k = 0;
record = 0;
minuteCheck = 0;
lastCount = 0;
checkState = 0; 
}



