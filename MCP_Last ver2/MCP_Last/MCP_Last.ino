#include <GyverButton.h>

#define EN 3
#define S0 22
#define S1 23
#define S2 24
#define S3 25
#define SIG 26
#define CS 27
#define DIN 28

#define PARSE_AMOUNT 16         // число значений в массиве, который хотим получить

#include <LedControl.h>
#include <CD74HC4067.h>

int course1, ias, hdg, alt, vvi, course2;
char dig8 = ' ';

GButton Butt2(39);

int intData[PARSE_AMOUNT];     // массив численных значений после парсинга
boolean recievedFlag;
boolean getStarted;
int oldLight = 0;
byte index;
String string_convert = "";

LedControl lc = LedControl(DIN, SIG, CS, 1); //28-din,27-cs,26-clk
CD74HC4067 mux1 = CD74HC4067(S0, S1, S2, S3);

void setup()
{
  Serial.begin(115200);
  Serial.setTimeout(20);

  pinMode(39, OUTPUT);
  pinMode(EN, OUTPUT);
  pinMode(45, OUTPUT);
  pinMode(33, OUTPUT);
  pinMode(34, OUTPUT);
  pinMode(35, OUTPUT);
  pinMode(36, OUTPUT);
  pinMode(2, OUTPUT);
  // digitalWrite(2, HIGH);
  digitalWrite(EN, LOW);

  pinMode(S0, OUTPUT);
  pinMode(S1, OUTPUT);
  pinMode(S2, OUTPUT);
  pinMode(S3, OUTPUT);

  mux1.channel(0);
  LedControl lc = LedControl(DIN, SIG, CS, 1); //28-din,27-cs,26-clk
  lc.shutdown(0, false); // включаем дисплей энергосбережение дисплей
  lc.setIntensity(0, 10); // устанавливаем яркость (0-минимум, 15-максимум)
  lc.clearDisplay(0);// очищаем дисплей

  mux1.channel(1);
  LedControl lc1 = LedControl(DIN, SIG, CS, 1); //28-din,27-cs,26-clk
  lc.shutdown(0, false); // включаем дисплей энергосбережение дисплей
  lc.setIntensity(0, 10); // устанавливаем яркость (0-минимум, 15-максимум)
  lc.clearDisplay(0);// очищаем дисплей

  mux1.channel(2);
  LedControl lc2 = LedControl(DIN, SIG, CS, 1); //28-din,27-cs,26-clk
  lc.shutdown(0, false); // включаем дисплей энергосбережение дисплей
  lc.setIntensity(0, 10); // устанавливаем яркость (0-минимум, 15-максимум)
  lc.clearDisplay(0);// очищаем дисплей
}

void loop()
{
  parsing();       // функция парсинга
  if (recievedFlag)
  { // если получены данные
    recievedFlag = false;
    mux1.channel(0); {

      printNumber3Digit(0, 0, intData[0], false);
      switch (intData[1])
      {
        case 0: lc.setChar(0, 3, ' ', false); break;
        case 1:
          {
            if (intData[2] == 1) dig8 = '8'; else dig8 = ' ';
            lc.setChar(0, 3, dig8, false);
            break;
          }
        case 2:
          {
            if (intData[3] == 1) dig8 = 'A'; else dig8 = ' ';
            lc.setChar(0, 3, dig8, false);
            break;
          }
      }
      if (intData[5] == 0)
      {
        lc.setChar(0, 3, ' ', false);
        lc.setChar(0, 4, ' ', false);
        lc.setChar(0, 5, ' ', false);
        lc.setChar(0, 6, ' ', false);
      } else {
        if (intData[4] < 100)
        {
          printNumber3DigitFloat(0, 3, intData[4], false);
        } else {
          printNumber3Digit(0, 4, intData[4], false);
        }
      }
    }
    mux1.channel(1); {
      printNumber3Digit(0, 0, intData[6], false);
      printNumber3DigitAlt(0, 3, intData[7], false);
    }
    mux1.channel(2); {
      printNumber3Digit(0, 0, intData[8], false);
      printNumber3Digit(0, 5, intData[9], false);
    }

    if (intData[15] != oldLight)
    {
      change_light(intData[15]);
      oldLight = intData[15];
    }

    digitalWrite(45, intData[10]);
    digitalWrite(33, intData[11]);
    digitalWrite(34, intData[12]);
    digitalWrite(35, intData[13]);
    digitalWrite(36, intData[14]);

  }
  Butt2.tick();
  /* // Обработка нажатий кнопоку и поворотов энкодеров

    mux1.channel(0); {

    }

    mux1.channel(1); {

    }

    mux1.channel(2); {

    }

    mux1.channel(3); {

    }

    mux1.channel(4); {

    }

    mux1.channel(5); {

    }

    mux1.channel(6); {

    }

    mux1.channel(7); {

    }*/

  mux1.channel(8); {
    //  GButton Butt2(39);
    if (Butt2.isClick()){
      Serial.println("CWS_A");}
  }

  /* mux1.channel(9); {

    }

    mux1.channel(10); {
    if (But2.isClick()) {
    Serial.print("CMD_A");
    }
    }*/

  /* mux1.channel(11); {

    }

    mux1.channel(12); {

    }

    mux1.channel(13); {

    }

    mux1.channel(14); {

    }

    mux1.channel(15); {

    }*/
  // Serial.flush();

}

void printNumber3Digit(int displayNumber, int segment, int v, int decimalPoint)
{
  int ones = 0;
  int tens = 0;
  int hundreds = 0;

  ones = v % 10;
  v = v / 10;
  tens = v % 10;
  v = v / 10;
  hundreds = v % 10;

  lc.setDigit(displayNumber, segment, (byte)hundreds, false);
  lc.setDigit(displayNumber, segment + 1, (byte)tens, false);
  lc.setDigit(displayNumber, segment + 2, (byte)ones, false);
}

void printNumber3DigitAlt(int displayNumber, int segment, int v, int decimalPoint)
{
  int ones = 0;
  int tens = 0;
  int hundreds = 0;

  // v = v / 100;
  ones = v % 10;
  v = v / 10;
  tens = v % 10;
  v = v / 10;
  hundreds = v % 10;

  if (hundreds == 0)
  {
    lc.setChar(displayNumber, segment, ' ', false);
  }
  else
  {
    lc.setDigit(displayNumber, segment, (byte)hundreds, false);
  }
  if (tens == 0 && hundreds == 0)
  {
    lc.setChar(displayNumber, segment + 1, ' ', false);
  }
  else
  {
    lc.setDigit(displayNumber, segment + 1, (byte)tens, false);
  }
  lc.setDigit(displayNumber, segment + 2, (byte)ones, false);
  lc.setDigit(displayNumber, segment + 3, 0, false);
  lc.setDigit(displayNumber, segment + 4, 0, false);
}

void printNumber3DigitFloat(int displayNumber, int segment, int v, int decimalPoint)
{
  int ones = 0;
  int tens = 0;

  ones = v % 10;
  v = v / 10;
  tens = v % 10;

  lc.setChar(displayNumber, segment, '.', false);
  lc.setDigit(displayNumber, segment + 1, (byte)tens, false);
  lc.setDigit(displayNumber, segment + 2, (byte)ones, false);
  lc.setChar(displayNumber, segment + 3, ' ', false);
}

void parsing()
{
  if (Serial.available() > 0) {
    char incomingByte = Serial.read();        // обязательно ЧИТАЕМ входящий символ
    if (getStarted) {                         // если приняли начальный символ (парсинг разрешён)
      if (incomingByte != ',' && incomingByte != ';') {   // если это не пробел И не конец
        string_convert += incomingByte;       // складываем в строку
      } else {                                // если это пробел или ; конец пакета
        intData[index] = string_convert.toInt();  // преобразуем строку в int и кладём в массив
        string_convert = "";                  // очищаем строку
        index++;                              // переходим к парсингу следующего элемента массива
      }
    }
    if (incomingByte == '$') {                // если это $
      getStarted = true;                      // поднимаем флаг, что можно парсить
      index = 0;                              // сбрасываем индекс
      string_convert = "";                    // очищаем строку
    }
    if (incomingByte == ';') {                // если таки приняли ; - конец парсинга
      getStarted = false;                     // сброс
      recievedFlag = true;                    // флаг на принятие
    }
  }
}

void change_light(int value)
{
  analogWrite(2, value);
}
