#include <Servo.h> 
#include "serialCommand.h"

SerialCommand sc;
Servo camOnKapixy;
Servo camOnKapiz; 
void setup() {
  sc.setBautRate(115200);
  sc.setup();
  pinMode(8,OUTPUT);
  pinMode(6,OUTPUT);
  camOnKapixy.attach(9);
  camOnKapiz.attach(11);
}
void loop() {
  sc.read();
  if(sc.modul=="light"&&sc.action=="onkapi"&&sc.data1=="1") digitalWrite(8,HIGH);
  if(sc.modul=="light"&&sc.action=="onkapi"&&sc.data1=="0") digitalWrite(8,LOW);
  if(sc.modul=="light"&&sc.action=="arkabahce"&&sc.data1=="1") digitalWrite(6,HIGH);
  if(sc.modul=="light"&&sc.action=="arkabahce"&&sc.data1=="0") digitalWrite(6,LOW);
  if(sc.modul=="cam"&&sc.action=="onkapi") {
    int a=sc.data1.toInt();
    camOnKapixy.write(a);
        delay(15);
   
    delay(15);
  }

  

}
