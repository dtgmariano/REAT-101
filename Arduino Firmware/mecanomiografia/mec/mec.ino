#include <AcceleroMMA7361.h>
#define _delay (unsigned long)0x1ff
#define _sens 475

AcceleroMMA7361 accelero;

unsigned int maxVal=0x0;
unsigned int t, amp;
unsigned int minVal = (unsigned int)0xffff;
unsigned long ignoreClick = 0;
int countLoop;

void setup()
{
  Serial.begin(9600);
  accelero.begin(13, 12, 11, 10, A0, A1, A2);
  accelero.setARefVoltage(3.3);                   //sets the AREF voltage to 3.3V
  accelero.setSensitivity(HIGH);                   //sets the sensitivity to +/-6G
  accelero.calibrate();
  accelero.setAveraging(1);
  
  countLoop = 10;
  while(countLoop--)
  {
     t = accelero.getTotalVector();
     minVal = (t < minVal? t: minVal);
     maxVal = (t > maxVal? t: maxVal);
  }
  amp = (maxVal - minVal);
  //maxVal /= 10;
  //minVal /= 10;
  
  maxVal *= 10;
  maxVal *= 10;
}

void loop()
{
  //t = accelero.getTotalVector()/10;
  //t = accelero.getTotalVector();
  t = accelero.getTotalVector()*10;
  if(t < minVal)
  {
    //Descida
    minVal = t;
    maxVal = t + amp;
  }
  else
  {
      if(((t - minVal) > (amp + _sens)) && (!ignoreClick))
      {
        Serial.println(t);
        Serial.println(amp + _sens);
        Serial.print("C");
        minVal = t;
        maxVal = t + amp;
        ignoreClick = _delay;
      }
  }
  
  if(ignoreClick)
  {
    minVal = t;
    maxVal = t + amp;    
    ignoreClick--;
  } 
}




