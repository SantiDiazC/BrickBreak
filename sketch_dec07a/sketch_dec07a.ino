
// zoomkat 7-30-11 serial I/O string test
// type a string in serial monitor. then send or enter
// for IDE 0019 and later

String readString;

void setup() {
 Serial.begin(9600);
 Serial.println("serial test 0021"); // so I can keep track of what is loaded
 pinMode(13, OUTPUT);
}

void loop() {

 while (Serial.available()) {
   delay(2);  //delay to allow byte to arrive in input buffer
   char c = Serial.read();
   readString += c;
   if (readString == "1"){
   digitalWrite(13, HIGH);   
   delay(100);              
   digitalWrite(13, LOW);   
   delay(100); 
   }
   readString = ""; 
 }


}
