#include "serialCommand.h"
SerialCommand sc;
void setup() {
  sc.setBautRate(115200);
  sc.setup();
  pinMode(8,OUTPUT);
  pinMode(6,OUTPUT);

}
void loop() {
  sc.read();
  if(sc.modul=="light"&&sc.action=="onkapi"&&sc.data1=="1") digitalWrite(8,HIGH);
  if(sc.modul=="light"&&sc.action=="onkapi"&&sc.data1=="0") digitalWrite(8,LOW);
  if(sc.modul=="light"&&sc.action=="arkabahce"&&sc.data1=="1") digitalWrite(6,HIGH);
  if(sc.modul=="light"&&sc.action=="arkabahce"&&sc.data1=="0") digitalWrite(6,LOW);

}
