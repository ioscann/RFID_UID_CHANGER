using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using ArduinoUploader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ArduinoUploader.Hardware;
using RFID_UID_CHANGER.Properties;
using System.Threading;

namespace RFID_UID_CHANGER.Forms
{
    public partial class uidChange : Form
    {
        public uidChange()
        {
            InitializeComponent();
        }

        private string cardUID;
        public static bool language = false;

        void endConnection() 
        {
            serialPort1.Close();
            btnDisconnect.Enabled = false;
            btnConnect.Enabled = true;
            if (language == true) { lblConnectStatus.Text = "Not Connected"; } else { lblConnectStatus.Text = "BAĞLI DEĞİL"; }
            lblConnectStatus.ForeColor = Color.Red;
            btnCodeUploader.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled= false;
        }

        void clearReadTextbox()
        {
            RTxtBlock1.Text = ""; RTxtBlock2.Text = "";
            RTxtBlock3.Text = ""; RTxtBlock4.Text = "";
        }

        void clearWriteTexbox()
        {
            WTxtBlock1.Text = ""; WTxtBlock2.Text = "";
            WTxtBlock3.Text = ""; WTxtBlock4.Text = "";
        }

        void makeEnglish()
        {
            groupBox1.Text = "Connection and code uploading";
            label1.Text = "Serial port";
            btnConnect.Text = "Connect";
            btnDisconnect.Text = "Disconnect";
            btnCodeUploader.Text = "Upload";
            //
            groupBox2.Text = "UID changing and reading";
            label2.Text = "UID entry";
            label3.Text = "Card UID";
            btnChangeUID.Text = "Try to change UID";
            btnReadUID.Text = "Read UID";
            //
            groupBox3.Text = "Reading and writing data to the card";
            label4.Text = "Sector No"; label21.Text = "Sector No";
            label5.Text = "Block"; label8.Text = "Block"; label10.Text = "Block"; label12.Text = "Block";
            btnWriteSector.Text = "Write";
            label14.Text = "Block"; label16.Text = "Block"; label18.Text = "Block"; label20.Text = "Block";
            btnReadSector.Text = "Read";
        }

        void makeTurkish()
        {
            groupBox1.Text = "Bağlantı ve kod yükleme";
            label1.Text = "Seri port";
            btnConnect.Text = "Bağlan";
            btnDisconnect.Text = "Bağlantıyı kes";
            btnCodeUploader.Text = "Kodu yükle";
            //
            groupBox2.Text = "UID değiştirme ve okuma";
            label2.Text = "UID giriş";
            label3.Text = "UID bilgisi";
            btnChangeUID.Text = "Değiştirmeyi dene";
            btnReadUID.Text = "Kart oku";
            //
            groupBox3.Text = "Karttan veri okuma ve karta veri yazma";
            label4.Text = "Sektör No"; label21.Text = "Sektör No";
            label5.Text = "Blok"; label8.Text = "Blok"; label10.Text = "Blok"; label12.Text = "Blok";
            btnWriteSector.Text = "Yaz";
            label14.Text = "Blok"; label16.Text = "Blok"; label18.Text = "Blok"; label20.Text = "Blok";
            btnReadSector.Text = "Oku";
        }

        private void uidChanege_Load(object sender, EventArgs e)
        {
            timer2.Start();
            btnDisconnect.Enabled = false;
            btnCodeUploader.Enabled = false;
            if (language == true) { makeEnglish(); }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                cmbSerialPorts.Enabled = true;
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                btnCodeUploader.Enabled = true;
                if (language == true) { lblConnectStatus.Text = "Not Connected"; } else { lblConnectStatus.Text = "BAĞLI DEĞİL"; }
                lblConnectStatus.ForeColor = Color.Red;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbSerialPorts.Text != "" && serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = cmbSerialPorts.Text;
                    serialPort1.BaudRate = 9600;
                    serialPort1.Open();
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                    cmbSerialPorts.Enabled = false;
                    if (language == true) { lblConnectStatus.Text = "Connected"; } else { lblConnectStatus.Text = "BAĞLI"; }
                    lblConnectStatus.ForeColor = Color.Lime;
                    btnCodeUploader.Enabled = true;
                }
                catch 
                {
                    if (language == false) { MessageBox.Show("Seri portlar çakışıyor ! Cihazı başka bir programın kullanmadığından emin olun !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); endConnection(); }
                    else { MessageBox.Show("Serial ports conflicting ! Make sure no other program is using the device !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); endConnection(); }
                }
            }
        }

        private void btnCodeUploader_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true) 
            {
                var uploader = new ArduinoSketchUploader(
                new ArduinoSketchUploaderOptions()
                {
                    FileName = "rfidchanger.ino.hex",
                    PortName = cmbSerialPorts.Text,
                    ArduinoModel = ArduinoModel.UnoR3
                });
                serialPort1.Close();
                try 
                { 
                    uploader.UploadSketch(); 
                    serialPort1.Open();
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                    btnCodeUploader.Enabled = false;
                } 
                catch
                {
                    if (language == false) { MessageBox.Show("İletişim koptu ! Lütfen cihazın bilgisayara bağlı olduğundan emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); endConnection(); }
                    else { MessageBox.Show("Communication lost! Please make sure the device is connected to the computer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); endConnection(); } 
                }                           
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true) 
            {
                serialPort1.Write("0");

                System.Threading.Thread.Sleep(1000);

                cardUID = serialPort1.ReadExisting().ToString();

                if (cardUID != "") { txtUID.Text = cardUID; }
                else { txtUID.Text = ""; }

                if (txtUID.Text != "") { listBox1.BackColor = Color.Lime;}
                else { listBox1.BackColor = Color.Red; }

                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbSerialPorts.DataSource = ports;
            if (language == true) { makeEnglish(); } else { makeTurkish(); }
            if (language == true && serialPort1.IsOpen == true) { lblConnectStatus.Text = "Connected"; }
            else if (language == true && serialPort1.IsOpen == false) { lblConnectStatus.Text = "Not Connected"; }
            else if (language == false && serialPort1.IsOpen == true) { lblConnectStatus.Text = "BAĞLI"; }
            else if (language == false && serialPort1.IsOpen == false) { lblConnectStatus.Text = "BAĞLI DEĞİL"; }
            if (cmbSerialPorts.Text == "") { endConnection(); btnCodeUploader.Enabled = true; cmbSerialPorts.Enabled = true; }
            if (language == true && radioButton4.Checked == true) { WTxtBlock4.Text = "Access Bit!"; } 
            else if (language == false && radioButton4.Checked == true) { WTxtBlock4.Text = "Doğrulama Bit'i !"; }
        }

        private void btnChangeUID_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true && maskedTextBox1.Text != "" && maskedTextBox2.Text != "" && maskedTextBox3.Text != "" && maskedTextBox4.Text != "" )
            {
                int A = int.Parse(maskedTextBox1.Text);
                int B = int.Parse(maskedTextBox2.Text);
                int C = int.Parse(maskedTextBox3.Text);
                int D = int.Parse(maskedTextBox4.Text);

                if (A <= 255 && B <= 255 && C <= 255 && D <= 255 )
                {
                    serialPort1.Write("1");
                    System.Threading.Thread.Sleep(2000);
                    serialPort1.Write(maskedTextBox1.Text);
                    System.Threading.Thread.Sleep(2000);
                    serialPort1.Write(maskedTextBox2.Text);
                    System.Threading.Thread.Sleep(3000);
                    serialPort1.Write(maskedTextBox3.Text);
                    System.Threading.Thread.Sleep(3000);
                    serialPort1.Write(maskedTextBox4.Text);
                    System.Threading.Thread.Sleep(3000);

                    System.Threading.Thread.Sleep(2000);
                }
                else { if (language == false) { MessageBox.Show("Bir bölüme yazılabilecek en büyük tam sayı 255 dir !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                       else { MessageBox.Show("The largest integer that can be written to a partition is 255 !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); } }
                
            }
            else { if (language == false) { MessageBox.Show("Bu alan boş bırakılamaz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else { MessageBox.Show("This field cannot be left blank !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            
        }

        private void btnReadUID_Click(object sender, EventArgs e) { timer1.Start(); }

        private void btnCopy_Click(object sender, EventArgs e) { if (txtUID.Text != "") { } }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "0") { Wblock1.Text = ""; Wblock2.Text = ""; Wblock3.Text = "2"; Wblock4.Text = "3"; }
            else if (comboBox1.Text == "1") { Wblock1.Text = "4"; Wblock2.Text = "5"; Wblock3.Text = "6"; Wblock4.Text = "7"; }
            else if (comboBox1.Text == "2") { Wblock1.Text = "8"; Wblock2.Text = "9"; Wblock3.Text = "10"; Wblock4.Text = "11"; }
            else if (comboBox1.Text == "3") { Wblock1.Text = "12"; Wblock2.Text = "13"; Wblock3.Text = "14"; Wblock4.Text = "15"; }
            else if (comboBox1.Text == "4") { Wblock1.Text = "16"; Wblock2.Text = "17"; Wblock3.Text = "18"; Wblock4.Text = "19"; }
            else if (comboBox1.Text == "5") { Wblock1.Text = "20"; Wblock2.Text = "21"; Wblock3.Text = "22"; Wblock4.Text = "23"; }
            else if (comboBox1.Text == "6") { Wblock1.Text = "24"; Wblock2.Text = "25"; Wblock3.Text = "26"; Wblock4.Text = "27"; }
            else if (comboBox1.Text == "7") { Wblock1.Text = "28"; Wblock2.Text = "29"; Wblock3.Text = "30"; Wblock4.Text = "31"; }
            else if (comboBox1.Text == "8") { Wblock1.Text = "32"; Wblock2.Text = "33"; Wblock3.Text = "34"; Wblock4.Text = "35"; }
            else if (comboBox1.Text == "9") { Wblock1.Text = "36"; Wblock2.Text = "37"; Wblock3.Text = "38"; Wblock4.Text = "39"; }
            else if (comboBox1.Text == "10") { Wblock1.Text = "40"; Wblock2.Text = "41"; Wblock3.Text = "42"; Wblock4.Text = "43"; }
            else if (comboBox1.Text == "11") { Wblock1.Text = "44"; Wblock2.Text = "45"; Wblock3.Text = "46"; Wblock4.Text = "47"; }
            else if (comboBox1.Text == "12") { Wblock1.Text = "48"; Wblock2.Text = "49"; Wblock3.Text = "50"; Wblock4.Text = "51"; }
            else if (comboBox1.Text == "13") { Wblock1.Text = "52"; Wblock2.Text = "53"; Wblock3.Text = "54"; Wblock4.Text = "55"; }
            else if (comboBox1.Text == "14") { Wblock1.Text = "56"; Wblock2.Text = "57"; Wblock3.Text = "58"; Wblock4.Text = "59"; }
            else if (comboBox1.Text == "15") { Wblock1.Text = "60"; Wblock2.Text = "61"; Wblock3.Text = "62"; Wblock4.Text = "63"; }
            clearWriteTexbox();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "0") { Rblock1.Text = "0"; Rblock2.Text = "1"; Rblock3.Text = "2"; Rblock4.Text = "3"; }
            else if (comboBox2.Text == "1") { Rblock1.Text = "2"; Rblock2.Text = "2"; Rblock3.Text = "6"; Rblock4.Text = "7"; }
            else if (comboBox2.Text == "2") { Rblock1.Text = ""; Rblock2.Text = ""; Rblock3.Text = "10"; Rblock4.Text = "11"; }
            else if (comboBox2.Text == "3") { Rblock1.Text = "12"; Rblock2.Text = "13"; Rblock3.Text = "14"; Rblock4.Text = "15"; }
            else if (comboBox2.Text == "4") { Rblock1.Text = "16"; Rblock2.Text = "17"; Rblock3.Text = "18"; Rblock4.Text = "19"; }
            else if (comboBox2.Text == "5") { Rblock1.Text = "20"; Rblock2.Text = "21"; Rblock3.Text = "22"; Rblock4.Text = "23"; }
            else if (comboBox2.Text == "6") { Rblock1.Text = "24"; Rblock2.Text = "25"; Rblock3.Text = "26"; Rblock4.Text = "27"; }
            else if (comboBox2.Text == "7") { Rblock1.Text = "28"; Rblock2.Text = "29"; Rblock3.Text = "30"; Rblock4.Text = "31"; }
            else if (comboBox2.Text == "8") { Rblock1.Text = "32"; Rblock2.Text = "33"; Rblock3.Text = "34"; Rblock4.Text = "35"; }
            else if (comboBox2.Text == "9") { Rblock1.Text = "36"; Rblock2.Text = "37"; Rblock3.Text = "38"; Rblock4.Text = "39"; }
            else if (comboBox2.Text == "10") { Rblock1.Text = "40"; Rblock2.Text = "41"; Rblock3.Text = "42"; Rblock4.Text = "43"; }
            else if (comboBox2.Text == "11") { Rblock1.Text = "44"; Rblock2.Text = "45"; Rblock3.Text = "46"; Rblock4.Text = "47"; }
            else if (comboBox2.Text == "12") { Rblock1.Text = "48"; Rblock2.Text = "49"; Rblock3.Text = "50"; Rblock4.Text = "51"; }
            else if (comboBox2.Text == "13") { Rblock1.Text = "52"; Rblock2.Text = "53"; Rblock3.Text = "54"; Rblock4.Text = "55"; }
            else if (comboBox2.Text == "14") { Rblock1.Text = "56"; Rblock2.Text = "57"; Rblock3.Text = "58"; Rblock4.Text = "59"; }
            else if (comboBox2.Text == "15") { Rblock1.Text = "60"; Rblock2.Text = "61"; Rblock3.Text = "62"; Rblock4.Text = "63"; }
            clearReadTextbox();
        }

        private void btnWriteSector_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && serialPort1.IsOpen == true)
            {
                if (radioButton1.Checked == true && WTxtBlock1.Text != "" && Wblock1.Text != "") { serialPort1.Write("2"); System.Threading.Thread.Sleep(2000); serialPort1.Write(Wblock1.Text); System.Threading.Thread.Sleep(2000); serialPort1.Write(WTxtBlock1.Text); System.Threading.Thread.Sleep(3000); }
                else if (radioButton2.Checked == true && WTxtBlock2.Text != "" && Wblock2.Text != "") { serialPort1.Write("2"); System.Threading.Thread.Sleep(2000); serialPort1.Write(Wblock2.Text); System.Threading.Thread.Sleep(2000); serialPort1.Write(WTxtBlock2.Text); System.Threading.Thread.Sleep(3000); }
                else if (radioButton3.Checked == true && WTxtBlock3.Text != "" && Wblock3.Text != "") { serialPort1.Write("2"); System.Threading.Thread.Sleep(2000); serialPort1.Write(Wblock3.Text); System.Threading.Thread.Sleep(2000); serialPort1.Write(WTxtBlock3.Text); System.Threading.Thread.Sleep(3000); }
                else if (radioButton4.Checked == true && WTxtBlock4.Text != "" && Wblock3.Text != "") { if (language == false) { MessageBox.Show("Doğrulama biti. Buraya veri yazamazsınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else { MessageBox.Show("Access bit. You cannot write data here !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); } }

                else { if (language == false) { MessageBox.Show("Önce bir blok seçmeniz gerekiyor ! (NOT : 0,1,2 SEKTÖRLERİNDE İLK İKİ BLOĞA VERİ YAZILAMAZ)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); } 
                    else { MessageBox.Show("A block needs to be made first! (NOTE: DATA CANNOT BE WRITTEN IN THE FIRST TWO BLOCKS IN SECTORS 0,1,2)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); } }
                
            }
            else { if (language == false) { MessageBox.Show("Önce bir sektör seçip içini doldurmanız gerekir ! ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                   else { MessageBox.Show("First you need to select a sector and fill it in ! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }         
        }

        private void btnReadSector_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" &&  serialPort1.IsOpen == true) 
            {
                if (radioButton5.Checked == true) { serialPort1.Write("3"); serialPort1.Write(Rblock1.Text); System.Threading.Thread.Sleep(500); RTxtBlock1.Text = serialPort1.ReadExisting(); }
                else if (radioButton6.Checked == true) { serialPort1.Write("3"); serialPort1.Write(Rblock2.Text); System.Threading.Thread.Sleep(500); RTxtBlock2.Text = serialPort1.ReadExisting(); }
                else if (radioButton7.Checked == true) { serialPort1.Write("3"); serialPort1.Write(Rblock3.Text); System.Threading.Thread.Sleep(500); RTxtBlock3.Text = serialPort1.ReadExisting(); }
                else if (radioButton8.Checked == true) { serialPort1.Write("3"); serialPort1.Write(Rblock4.Text); System.Threading.Thread.Sleep(500); RTxtBlock4.Text = serialPort1.ReadExisting(); }
                else { if (language == false) { MessageBox.Show("Önce okumak istediğin bloğu seçmelisin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                       else { MessageBox.Show("First you need the select the block you want!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                
            }
            else { if (language == false) { MessageBox.Show("Okumadan önce sektör ve blok seçmelisin !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                   else { MessageBox.Show("You must select sector and block before reading !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); } }
                        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) { if (radioButton1.Checked == true) { WTxtBlock1.Enabled = true; } else { WTxtBlock1.Enabled = false; } }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) { if (radioButton2.Checked == true) { WTxtBlock2.Enabled = true; } else { WTxtBlock2.Enabled = false; } }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) { if (radioButton3.Checked == true) { WTxtBlock3.Enabled = true; } else { WTxtBlock3.Enabled = false; } }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) { if (radioButton4.Checked == true) { if (language == true) { WTxtBlock4.Text = "Doğrulama Bit'i !"; } else { WTxtBlock4.Text = "Access bit !"; } } else { WTxtBlock4.Enabled = false; } }
    }
}
