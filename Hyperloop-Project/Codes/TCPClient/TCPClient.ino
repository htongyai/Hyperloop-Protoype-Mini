// EXAMPLE USAGE
SYSTEM_MODE(MANUAL);

TCPClient client;
byte server[] = { 192, 168, 0, 3 }; // to the queen(one as a server photon)  wlan IP

char* c = "1";


void setup()
{
    
        
    pinMode(D7,OUTPUT);
  // Make sure your Serial Terminal app is closed before powering your device
   Serial.begin(9600);
   WiFi.connect();
  // Now open your Serial Terminal, and hit any key to continue!
  while(!Serial.available()) Particle.process();
  
  //connect to local wifi and show the status
    Serial.println("connecting to wifi");
    
    //while(!WiFi.ready());
    Serial.println(WiFi.localIP());
    Serial.println(WiFi.subnetMask());
    Serial.println(WiFi.gatewayIP());
    Serial.println(WiFi.SSID());

  Serial.println("connecting to server");

  if (client.connect(server, 1000))
  {
    Serial.println("server connected");
    /*
    client.println("GET /search?q=unicorn HTTP/1.0");
    client.println("Host: www.google.com");
    client.println("Content-Length: 0");
    client.println();
    */
  }
  else
  {
    Serial.println("connection failed");
  }
}

void loop()
{
   Particle.process(); 
   digitalWrite(D7,HIGH);
    
    client.write(c);
    
    if(client.available() > 0){
        Serial.println("reading back");
        Serial.println(client.read());
        client.flush();
        }
  

  if (!client.connected())
  {
    Serial.println();
    Serial.println();
    Serial.println("reconnecting.");
    client.stop();
    for(;;);
    if(client.connect(server,1000)){
        Serial.println("connected");
    }
    else
    {
        Serial.println("connection failed");
    }
  }
  delay(500);
  digitalWrite(D7,LOW);
  delay(500);
  
  
}
