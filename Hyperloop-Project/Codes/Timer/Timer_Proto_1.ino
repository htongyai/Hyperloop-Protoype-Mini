 int minute = 60;
 int record = 0;

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
  Serial.println("Initialization Completed");
}

void loop() {
  // put your main code here, to run repeatedly:
  
boolean buttonState = digitalRead(2);
boolean buttonState7 = digitalRead(7);
int i;

if (buttonState){
  Serial.println("Timer Started:");
  digitalWrite(4,HIGH);
     for (i=1; i <= minute; i++){
          digitalWrite(5, HIGH);
          Serial.println(i);
          //Serial.print(" ");
          digitalWrite(5, LOW);
          delay(1000);
       }
       Serial.println("1 Minute");
       delay(100);
       digitalWrite(4,LOW);
       Serial.println("Timer Done");
  }

  if (buttonState7){
    record = i;
    Serial.println("Logged");
   delay(200);
  }
   
}

