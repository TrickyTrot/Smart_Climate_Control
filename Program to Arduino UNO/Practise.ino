#include <SimpleDHT.h> //Подключаем библиотеку для работы с гигрометром
#include <SPI.h>//Подключение библиотеки для работы с интерфейсом SPI
#include <ShiftedLCD.h>// Подключение библиотеки для работы с жидкокристаллическим дисплеем
#include <Math.h>//подключение библиотеки математических операторов
LiquidCrystal lcd(10);// Инициализация экрана. Указание на порт для выбора ведомого устройства
byte TempRead=0, HumRead=0;//Переменные для работы с показаниями датчика
byte Temp1Set = 20;//Переменная температуры T1
byte Temp2Set = 30;//Переменная температуры T2
byte Hum1Set=65;//Переменная влажности H1
byte Light1Set=50;//Переменная освещённости L1
byte LightValue=0;//Переменная освещённости L
int pause = 1000;// время задержки данных
int LightABC=0;//Переменная считывающая значения датчика освещённости
int ERRORFlag = 0;//Флаг ошибки чтения
int Del = 1000;//время паузы устройства
const int PinDHT=7;//Вывод считывающий сигналы датчика
const int PinLED=3;//Вывод регулирующий уровень освещения
const int PinHum=4;//Вывод ублажнителя
const int PinHot=5;//Вывод нагревателя
const int PinCold=6;//Вывод охладителя
const int PinLight=A0;// Вывод датчика освещённости
SimpleDHT11 dht(PinDHT);//создаём переменную для работы с датчиком

void setup() {
  Serial.begin(115200);
  // EEROM - энергонезависимая память
  lcd.clear();
  lcd.begin(16, 2);// Установка размера (количества столбцов и строк) экрана
 lcd.setCursor(0, 0);
 lcd.print("Hello world!");// Вывод первой строки
 // Установка курсора в первую колонку второй строки
 // Поскольку индексация в компьютерной технике начинается с нуля,
 // то индексы будут 0 и 1 соответственно
 lcd.setCursor(0, 1);
 lcd.print("Hello INIT!");// Вывод второй строки

pinMode(PinLED,OUTPUT);
pinMode(PinLight,INPUT); 
delay(1000);
}

void loop() {
  lcd.clear();
  lcd.setCursor(0,0);
  lcd.print("Scan...");
 // Serial.println("=======================");
//Считываем уровень освещённости
  for (int i=0;i<10;i++)LightABC=analogRead(PinLight);
  LightValue=map(LightABC,200,1023,100,0);
  //Serial.print("Light = ");
//Serial.println(LightValue);
  ERRORFlag=0;
  for (int i=0;i<10;i++){
    if(dht.read(&TempRead,&HumRead,NULL)!=0) ERRORFlag++; 
  }
  if(ERRORFlag > 9){
    Serial.println("Error was found!");
    delay(1000);
    return;
  }
 // Serial.print("Temp = ");
  //Serial.println(TempRead);
  //Serial.print("Hum = ");
  //Serial.println(HumRead);

   //обнуление состояния исполнителей
  digitalWrite(PinHot,LOW);
  digitalWrite(PinCold,LOW);
  if (TempRead > (Temp2Set + 1)) digitalWrite(PinCold,HIGH);//включение охладителя.
  
  else if(TempRead < (Temp1Set - 1))analogWrite(PinHot,250);//включение нагревателя.

  else{//выключение нагрев/охлад
  digitalWrite(PinCold,LOW);
  digitalWrite(PinHot,LOW);
  }
  if(HumRead< Hum1Set){ analogWrite(PinHum,250);}
  else {digitalWrite(PinHum,HIGH);}
  if(LightValue < Light1Set) analogWrite(PinLED, map(Light1Set += Light1Set-LightValue,0,100,0,250));
  else if(LightValue > Light1Set)digitalWrite(PinLED,LOW);
  else analogWrite(PinLED, map(Light1Set,0,100,0,250));
  
  LCDPrint();
  recieveData();

delay(Del);
}
                    

void recieveData() // Функция для передачи/получения данных
{
  byte DTS[4] = {60,TempRead, HumRead, LightValue};//(Data To Send) массив для отправки
    Serial.write(DTS,4);//отправляем массив

 byte DTG[4]; //Data To Get - массив для приёма
 if (Serial.available() >0) // Если в буфере есть данные
 { int i=0;
 while(Serial.available()>0){
 DTG[i]=Serial.read();//побайтого считываем данные
 i++;
}
}
//производим настройку на основе полученных данных
if(DTG[0]!=60){
Temp1Set=DTG[0];
Temp2Set=DTG[1];
Hum1Set=DTG[2];
Light1Set=DTG[3];
}
}

void LCDPrint(){//функция для вывода данных на дисплей
  lcd.clear();
//начало вывода считанных данных
   //Установка курсора в 1 столбец, 1 строку
  lcd.setCursor(0,0);
  //Вывод температуры на дисплей
  lcd.print("Tred = ");
  lcd.print(TempRead);
  lcd.print(" oC");
  //Установка курсора в 1 столбец, 2 строку
  lcd.setCursor(0,1);
  //Вывод уровня влажности на экран 
  lcd.print("Hred = ");
  lcd.print(HumRead);
  lcd.print(" %");
  delay(pause);
  
  //Установка курсора в 1 столбец, 2 строку
  lcd.setCursor(0,1);
  //Вывод уровня влажности на экран 
  lcd.print("Lred = ");
  lcd.print(LightValue);
  lcd.print(" %");
  delay(pause);
  //конец вывода считанных данных
  lcd.clear();
  //начало вывода установленных данных
  //Установка курсора в 1 столбец, 1 строку
  lcd.setCursor(0,0);
  //Вывод температуры на дисплей
  lcd.print("T1set = ");
  lcd.print(Temp1Set);
  lcd.print(" oC");
  
  //Установка курсора в 1 столбец, 2 строку
  lcd.setCursor(0,1);
  //Вывод уровня влажности на экран 
  lcd.print("T2set = ");
  lcd.print(Temp2Set);
  lcd.print(" oC");
  delay(pause);
  lcd.clear();
  //Установка курсора в 1 столбец, 1 строку
  lcd.setCursor(0,0);
  //Вывод температуры на дисплей
  lcd.print("H1set = ");
  lcd.print(Hum1Set);
  lcd.print(" %");
    
  //Установка курсора в 1 столбец, 2 строку
  lcd.setCursor(0,1);
  //Вывод уровня влажности на экран 
  lcd.print("L1set = ");
  lcd.print(Light1Set);
  lcd.print(" %");
  delay(pause);
//Конец вывода установленных данных
}
