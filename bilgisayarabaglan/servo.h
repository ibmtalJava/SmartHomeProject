#include <Servo.h> 
class CamServo{
  private:
    int xyPin=0;    int zPin=0;    int xyDeg=0;    int zDeg=0;
    Servo xyServo;    Servo zServo;
  public:
    CamServo(int d1,int d2){
      xyPin=d1;      zPin=d2;
    }
    void setup(){
      xyServo.attach(xyPin);      zServo.attach(zPin);
    } 
    void set(String d1,String d2){
      xyDeg=d1.toInt();
      zDeg=d2.toInt();
      xyServo.write(xyDeg);
      zServo.write(zDeg);
      delay(15);
    }  
};
