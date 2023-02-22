#include <SPI.h>
#include <MFRC522.h>

#define RST_PIN   9     
#define SS_PIN    10    

MFRC522 mfrc522(SS_PIN, RST_PIN);   
MFRC522::MIFARE_Key key;
MFRC522::StatusCode status;

byte bufferLen = 18;
byte readBlockData[18];
byte blockData[16];

int A,B,C,D;

void setup() 
{
  Serial.begin(9600);  // seri haberleşme hızı
  while (!Serial); // Seri haberleşme sürdüğü sürece  
  SPI.begin(); // SPI protokolünü başlatır   
  mfrc522.PCD_Init(); //MFRC522 kartını başlatır
  
  for (byte i = 0; i < 6; i++) { key.keyByte[i] = 0xFF; } // Anahtarı hazırlar -> çip fabrikadan teslim edildiğinde tüm anahtarlar FFFFFFFFFFFFFF olarak ayarlanır.
}

void readUID()
{
  if (!mfrc522.PICC_IsNewCardPresent()) { return; } // Mevcut okutulan karttan başka bir kart gelmediğinde başa döner 

  if (!mfrc522.PICC_ReadCardSerial()) { return; }  // Herhangi bir kart okutulmadığında değerlerin ekrana gelmemesini sağlar

  for (int i=0;i<mfrc522.uid.size;i++) {Serial.print(mfrc522.uid.uidByte[i]); Serial.print(" ");} // Okunan kartın UID sini seri porta yazdırır
}


void setNewUID(int A , int B , int C , int D)
{ 
  byte newUid[] = {A,B,C,D}; // Alınan 4 veriyi byte dizisine depolar

  if (!mfrc522.PICC_IsNewCardPresent()) { return; }  

  if (!mfrc522.PICC_ReadCardSerial()) { return; } 
     
  if ( mfrc522.MIFARE_SetUid(newUid, (byte)4, true) )  {Serial.println(F("Wrote new UID to card."));} // Alınan verilere göre kartın UID sini değiştirir
}

void WriteDataToBlockString(int blockNum, String data) // Karta veri yazma fonksiyonu
{
  for (int i=0;i<16;i++) { blockData[i] = data[i];} // Alınan veriyi data değişkenine aktaran kod bloğu

  for (byte i = 0; i < 6; i++) {key.keyByte[i] = 0xFF;} 

  if ( ! mfrc522.PICC_IsNewCardPresent()) { return; }  
  
  if ( ! mfrc522.PICC_ReadCardSerial()) { return; }  

  status = mfrc522.PCD_Authenticate(MFRC522::PICC_CMD_MF_AUTH_KEY_A, blockNum, &key, &(mfrc522.uid)); // A Anahtarını kullanarak okuma erişimi için istenen veri bloğunun kimliğinin doğrulanması
 
  status = mfrc522.MIFARE_Write(blockNum, blockData, 16);  // İstenilen bloğa istenilen veriyi yazar
  
  status = mfrc522.PCD_Authenticate(MFRC522::PICC_CMD_MF_RESTORE, blockNum, &key, &(mfrc522.uid)); // A anahtarı kullanılarak yapılan kimlik doğrulamasını sıfırlar

  Serial.print("Wrote new data to your block. Maybe not. I think you should go and check it out.");
}

void ReadDataFromBlock(int blockNum, byte readBlockData[]) // Karttaki veriyi okuma fonksiyonu
{
  for (byte i = 0; i < 6; i++) {key.keyByte[i] = 0xFF;} 

  if ( ! mfrc522.PICC_IsNewCardPresent()) { return; } 
  
  if ( ! mfrc522.PICC_ReadCardSerial()) { return; }

  byte status = mfrc522.PCD_Authenticate(MFRC522::PICC_CMD_MF_AUTH_KEY_A, blockNum, &key, &(mfrc522.uid)); // A Anahtarını kullanarak okuma erişimi için istenen veri bloğunun kimliğinin doğrulanması

  status = mfrc522.MIFARE_Read(blockNum, readBlockData, &bufferLen); // İstenilen bloktaki veriyi okur

  status = mfrc522.PCD_Authenticate(MFRC522::PICC_CMD_MF_RESTORE, blockNum, &key, &(mfrc522.uid)); // A anahtarı kullanılarak yapılan kimlik doğrulamasını sıfırlar

  for (int j=0 ; j<16 ; j++) {Serial.write(readBlockData[j]);} // Kartın istenilen blokundaki veriyi yazdırır
}

void loop() 
{ 
  start: 

  if (Serial.available())
  {

    char data = Serial.read();

    if (data == '0') 
    {
      readUID();
      data = "";
      goto start;
    }
    else if (data == '1')
    {
      delay(2000);
      int A = Serial.parseInt();
      delay(2000);
      int B = Serial.parseInt();
      delay(3000);
      int C = Serial.parseInt();
      delay(3000);
      int D = Serial.parseInt();
      delay(3000);
      setNewUID(A,B,C,D);
      data = "";
      goto start;
    }
    else if (data == '2')
    { 
      delay(2000);
      int blockNum = Serial.parseInt(); 
      delay(2000); 
      String data = Serial.readString(); 
      delay(3000); 
      WriteDataToBlockString(blockNum,data); 
      data = "";
      goto start;
    }
    else if (data == '3') 
    { 
      int blockNum = Serial.parseInt(); 
      ReadDataFromBlock(blockNum,readBlockData); 
      data = "";
      goto start;}
    }   
}