#include <AcceleroMMA7361.h>

AcceleroMMA7361 accelero;
int x, y, z;
int t, orient;

const int numReadings = 10;
int readings[numReadings];      // the readings from the analog input
int index = 0;                  // the index of the current reading
int total = 0;                  // the running total
int average = 0;                // the average
int target = 0;
boolean itIsPressed = false;

int loopCount = 0;

void setup()
{
  Serial.begin(9600);
  accelero.begin(13, 12, 11, 10, A0, A1, A2);
  accelero.setARefVoltage(3.3);                   //sets the AREF voltage to 3.3V
  accelero.setSensitivity(HIGH);                   //sets the sensitivity to +/-6G
  accelero.calibrate();
}

void loop()
{
  accelero.setAveraging(1);
  accelero.getAccelXYZ(&x, &y, &z);
  //orient = accelero.getOrientation();
  target = 110;
  t = accelero.getTotalVector();
  
  // subtract the last reading:
  total = total - readings[index];         
  // read from the sensor:  
  readings[index] = t; 
  // add the reading to the total:
  total = total + readings[index];       
  // advance to the next position in the array:  
  index = index + 1;    
  
  // if we're at the end of the array...
  if (index >= numReadings)              
    // ...wrap around to the beginning: 
    index = 0;                           

  // calculate the average:
  average = total / numReadings;

  if((average >= target) && (itIsPressed == false))
  {
      Serial.print("\nC");
      Serial.print(average);
      itIsPressed = true;
  }
  
  if(loopCount>=35)
  {
    loopCount = 0;
    itIsPressed = false;
  }

  loopCount++;
  // send it to the computer as ASCII digits
  delay(50);        // delay in between reads for stability     
}
