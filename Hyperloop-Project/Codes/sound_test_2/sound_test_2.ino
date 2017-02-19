const int analogPin = 0; //pin which mic is connected to
const int microphonePin= 0; //the microphone positive terminal will connect to analog pin A0 to be read
const int redPin =13; //red led (indicates start and stop of 3 min round)
const int greenPin = 5; // green led (flashed @ each second of round)
const int yellowPin= 4; // yeloow led (flashes at each minute of the round)

int val ; //analoue voltage read by mic
int minute = 60;
int record = 0;

boolean timerState = false;//this controls timer loop
boolean micState = false; //this controls mic loop

void setup() {
    Serial.begin(9600);
}
 
void loop() {
   //MIC CODE
  if(!micState){
    int mn = 1024; // mn only decreases
    int mx = 0; // mx only increases\
    
    // Perform 10000 reads. Update mn and mx for each one.
    for (int i = 0; i < 10000; ++i) {
        val = analogRead(analogPin);
        mn = min(mn, val);
        mx = max(mx, val);
    }
    
    
    // Send min, max and delta over Serial
    Serial.print("val=");
    Serial.print(val);
    Serial.print(" m=");
    Serial.print(mn);
    Serial.print(" M=");
    Serial.print(mx);
    Serial.print(" D=");
    int diff = mx-mn;
    Serial.print(diff);
    Serial.println();
    if(diff > 450){
       micState = true;
       timerState = true;
      digitalWrite (redPin, HIGH); //if the reading is greater than the threshold value, LED turns on
      delay (500); //LED stays on for a half a second
      digitalWrite (redPin, LOW); //LED turns off
    }
  }
    //TIMER CODE
    if (timerState){
      int i,j;
      Serial.println("Timer Started:");
    for( j=0; j<3 ; j++){
     for (i=1; i <= minute; i++){
          digitalWrite(greenPin, HIGH);
          Serial.println(i);
          //Serial.print(" ");
          digitalWrite(greenPin, LOW);
          delay(1000);
       }
       Serial.println("1 Minute");
       digitalWrite(yellowPin,HIGH); //****************************************seems not to be working****************************
       delay(100);
       digitalWrite(yellowPin,LOW);// LED seemd not turning on after 1st min, definitely turned on at second min
    }
   Serial.println("Round finished");
   digitalWrite(redPin,HIGH);
   delay(100);
   digitalWrite(redPin,LOW);
   Serial.println("Timer Done");
   timerState = false;
   micState = true;
  }
}
