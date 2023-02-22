namespace RFID_UID_CHANGER.Forms
{
    partial class uidChange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCodeUploader = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConnectStatus = new System.Windows.Forms.Label();
            this.cmbSerialPorts = new System.Windows.Forms.ComboBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnReadUID = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangeUID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnReadSector = new System.Windows.Forms.Button();
            this.RTxtBlock4 = new System.Windows.Forms.TextBox();
            this.RTxtBlock3 = new System.Windows.Forms.TextBox();
            this.RTxtBlock2 = new System.Windows.Forms.TextBox();
            this.RTxtBlock1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Rblock4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Rblock3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Rblock2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Rblock1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnWriteSector = new System.Windows.Forms.Button();
            this.WTxtBlock4 = new System.Windows.Forms.TextBox();
            this.WTxtBlock3 = new System.Windows.Forms.TextBox();
            this.WTxtBlock2 = new System.Windows.Forms.TextBox();
            this.WTxtBlock1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Wblock4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Wblock3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Wblock2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Wblock1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCodeUploader);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblConnectStatus);
            this.groupBox1.Controls.Add(this.cmbSerialPorts);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bağlantı ve kod yükleme";
            // 
            // btnCodeUploader
            // 
            this.btnCodeUploader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCodeUploader.Location = new System.Drawing.Point(599, 6);
            this.btnCodeUploader.Name = "btnCodeUploader";
            this.btnCodeUploader.Size = new System.Drawing.Size(175, 68);
            this.btnCodeUploader.TabIndex = 5;
            this.btnCodeUploader.Text = "Kod Yükle";
            this.btnCodeUploader.UseVisualStyleBackColor = true;
            this.btnCodeUploader.Click += new System.EventHandler(this.btnCodeUploader_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seri port :";
            // 
            // lblConnectStatus
            // 
            this.lblConnectStatus.AutoSize = true;
            this.lblConnectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConnectStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectStatus.Location = new System.Drawing.Point(411, 28);
            this.lblConnectStatus.Name = "lblConnectStatus";
            this.lblConnectStatus.Size = new System.Drawing.Size(141, 25);
            this.lblConnectStatus.TabIndex = 4;
            this.lblConnectStatus.Text = "BAĞLI DEĞİL";
            // 
            // cmbSerialPorts
            // 
            this.cmbSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerialPorts.FormattingEnabled = true;
            this.cmbSerialPorts.Location = new System.Drawing.Point(75, 32);
            this.cmbSerialPorts.Name = "cmbSerialPorts";
            this.cmbSerialPorts.Size = new System.Drawing.Size(121, 21);
            this.cmbSerialPorts.TabIndex = 1;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Red;
            this.btnDisconnect.FlatAppearance.BorderSize = 0;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Location = new System.Drawing.Point(288, 30);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(80, 23);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Bağlanıyı kes";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Lime;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(202, 30);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(80, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.maskedTextBox4);
            this.groupBox2.Controls.Add(this.maskedTextBox3);
            this.groupBox2.Controls.Add(this.maskedTextBox2);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.btnReadUID);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.txtUID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnChangeUID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(0, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 110);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UID değiştirme ve okuma";
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(201, 29);
            this.maskedTextBox4.Mask = "000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(36, 20);
            this.maskedTextBox4.TabIndex = 10;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(159, 29);
            this.maskedTextBox3.Mask = "000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(36, 20);
            this.maskedTextBox3.TabIndex = 9;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(117, 29);
            this.maskedTextBox2.Mask = "000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(36, 20);
            this.maskedTextBox2.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(75, 28);
            this.maskedTextBox1.Mask = "000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(36, 20);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // btnReadUID
            // 
            this.btnReadUID.BackColor = System.Drawing.SystemColors.Control;
            this.btnReadUID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadUID.Location = new System.Drawing.Point(300, 53);
            this.btnReadUID.Name = "btnReadUID";
            this.btnReadUID.Size = new System.Drawing.Size(200, 24);
            this.btnReadUID.TabIndex = 6;
            this.btnReadUID.Text = "Kart oku";
            this.btnReadUID.UseVisualStyleBackColor = false;
            this.btnReadUID.Click += new System.EventHandler(this.btnReadUID_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(522, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 52);
            this.listBox1.TabIndex = 4;
            // 
            // txtUID
            // 
            this.txtUID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUID.Enabled = false;
            this.txtUID.Location = new System.Drawing.Point(380, 24);
            this.txtUID.Multiline = true;
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(120, 24);
            this.txtUID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(297, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "UID bilgisi  :";
            // 
            // btnChangeUID
            // 
            this.btnChangeUID.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangeUID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUID.Location = new System.Drawing.Point(10, 55);
            this.btnChangeUID.Name = "btnChangeUID";
            this.btnChangeUID.Size = new System.Drawing.Size(227, 24);
            this.btnChangeUID.TabIndex = 3;
            this.btnChangeUID.Text = "Değiştirmeyi dene";
            this.btnChangeUID.UseVisualStyleBackColor = false;
            this.btnChangeUID.Click += new System.EventHandler(this.btnChangeUID_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "UID giriş :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.radioButton7);
            this.groupBox3.Controls.Add(this.radioButton8);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.btnReadSector);
            this.groupBox3.Controls.Add(this.RTxtBlock4);
            this.groupBox3.Controls.Add(this.RTxtBlock3);
            this.groupBox3.Controls.Add(this.RTxtBlock2);
            this.groupBox3.Controls.Add(this.RTxtBlock1);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.Rblock4);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.Rblock3);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.Rblock2);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.Rblock1);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.btnWriteSector);
            this.groupBox3.Controls.Add(this.WTxtBlock4);
            this.groupBox3.Controls.Add(this.WTxtBlock3);
            this.groupBox3.Controls.Add(this.WTxtBlock2);
            this.groupBox3.Controls.Add(this.WTxtBlock1);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.Wblock4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.Wblock3);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Wblock2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Wblock1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(0, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(777, 283);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Karttan veri okuma ve karta veri yazma";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(657, 66);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(14, 13);
            this.radioButton5.TabIndex = 38;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(657, 99);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(14, 13);
            this.radioButton6.TabIndex = 37;
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(657, 138);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(14, 13);
            this.radioButton7.TabIndex = 36;
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(657, 177);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(14, 13);
            this.radioButton8.TabIndex = 35;
            this.radioButton8.TabStop = true;
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(245, 179);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 34;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(245, 140);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 33;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(245, 101);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 32;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(244, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnReadSector
            // 
            this.btnReadSector.BackColor = System.Drawing.SystemColors.Control;
            this.btnReadSector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadSector.Location = new System.Drawing.Point(453, 226);
            this.btnReadSector.Name = "btnReadSector";
            this.btnReadSector.Size = new System.Drawing.Size(197, 24);
            this.btnReadSector.TabIndex = 30;
            this.btnReadSector.Text = "Oku";
            this.btnReadSector.UseVisualStyleBackColor = false;
            this.btnReadSector.Click += new System.EventHandler(this.btnReadSector_Click);
            // 
            // RTxtBlock4
            // 
            this.RTxtBlock4.Location = new System.Drawing.Point(529, 177);
            this.RTxtBlock4.Name = "RTxtBlock4";
            this.RTxtBlock4.ReadOnly = true;
            this.RTxtBlock4.Size = new System.Drawing.Size(121, 20);
            this.RTxtBlock4.TabIndex = 29;
            // 
            // RTxtBlock3
            // 
            this.RTxtBlock3.Location = new System.Drawing.Point(529, 138);
            this.RTxtBlock3.Name = "RTxtBlock3";
            this.RTxtBlock3.ReadOnly = true;
            this.RTxtBlock3.Size = new System.Drawing.Size(121, 20);
            this.RTxtBlock3.TabIndex = 28;
            // 
            // RTxtBlock2
            // 
            this.RTxtBlock2.Location = new System.Drawing.Point(529, 99);
            this.RTxtBlock2.Name = "RTxtBlock2";
            this.RTxtBlock2.ReadOnly = true;
            this.RTxtBlock2.Size = new System.Drawing.Size(121, 20);
            this.RTxtBlock2.TabIndex = 27;
            // 
            // RTxtBlock1
            // 
            this.RTxtBlock1.Location = new System.Drawing.Point(529, 61);
            this.RTxtBlock1.Name = "RTxtBlock1";
            this.RTxtBlock1.ReadOnly = true;
            this.RTxtBlock1.Size = new System.Drawing.Size(121, 20);
            this.RTxtBlock1.TabIndex = 26;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox2.Location = new System.Drawing.Point(529, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 25;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Rblock4
            // 
            this.Rblock4.AutoSize = true;
            this.Rblock4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rblock4.Location = new System.Drawing.Point(496, 178);
            this.Rblock4.Name = "Rblock4";
            this.Rblock4.Size = new System.Drawing.Size(0, 16);
            this.Rblock4.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(450, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Blok :";
            // 
            // Rblock3
            // 
            this.Rblock3.AutoSize = true;
            this.Rblock3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rblock3.Location = new System.Drawing.Point(496, 139);
            this.Rblock3.Name = "Rblock3";
            this.Rblock3.Size = new System.Drawing.Size(0, 16);
            this.Rblock3.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(450, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "Blok :";
            // 
            // Rblock2
            // 
            this.Rblock2.AutoSize = true;
            this.Rblock2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rblock2.Location = new System.Drawing.Point(496, 100);
            this.Rblock2.Name = "Rblock2";
            this.Rblock2.Size = new System.Drawing.Size(0, 16);
            this.Rblock2.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(450, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 16);
            this.label18.TabIndex = 19;
            this.label18.Text = "Blok :";
            // 
            // Rblock1
            // 
            this.Rblock1.AutoSize = true;
            this.Rblock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rblock1.Location = new System.Drawing.Point(496, 65);
            this.Rblock1.Name = "Rblock1";
            this.Rblock1.Size = new System.Drawing.Size(0, 16);
            this.Rblock1.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(450, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 16);
            this.label20.TabIndex = 17;
            this.label20.Text = "Blok :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(450, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 16);
            this.label21.TabIndex = 16;
            this.label21.Text = "Sektör No :";
            // 
            // btnWriteSector
            // 
            this.btnWriteSector.BackColor = System.Drawing.SystemColors.Control;
            this.btnWriteSector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWriteSector.Location = new System.Drawing.Point(41, 227);
            this.btnWriteSector.Name = "btnWriteSector";
            this.btnWriteSector.Size = new System.Drawing.Size(197, 24);
            this.btnWriteSector.TabIndex = 15;
            this.btnWriteSector.Text = "Yaz";
            this.btnWriteSector.UseVisualStyleBackColor = false;
            this.btnWriteSector.Click += new System.EventHandler(this.btnWriteSector_Click);
            // 
            // WTxtBlock4
            // 
            this.WTxtBlock4.Enabled = false;
            this.WTxtBlock4.Location = new System.Drawing.Point(117, 178);
            this.WTxtBlock4.MaxLength = 16;
            this.WTxtBlock4.Name = "WTxtBlock4";
            this.WTxtBlock4.Size = new System.Drawing.Size(121, 20);
            this.WTxtBlock4.TabIndex = 14;
            // 
            // WTxtBlock3
            // 
            this.WTxtBlock3.Enabled = false;
            this.WTxtBlock3.Location = new System.Drawing.Point(117, 139);
            this.WTxtBlock3.MaxLength = 16;
            this.WTxtBlock3.Name = "WTxtBlock3";
            this.WTxtBlock3.Size = new System.Drawing.Size(121, 20);
            this.WTxtBlock3.TabIndex = 13;
            // 
            // WTxtBlock2
            // 
            this.WTxtBlock2.Enabled = false;
            this.WTxtBlock2.Location = new System.Drawing.Point(117, 100);
            this.WTxtBlock2.MaxLength = 16;
            this.WTxtBlock2.Name = "WTxtBlock2";
            this.WTxtBlock2.Size = new System.Drawing.Size(121, 20);
            this.WTxtBlock2.TabIndex = 12;
            // 
            // WTxtBlock1
            // 
            this.WTxtBlock1.Enabled = false;
            this.WTxtBlock1.Location = new System.Drawing.Point(117, 62);
            this.WTxtBlock1.MaxLength = 16;
            this.WTxtBlock1.Name = "WTxtBlock1";
            this.WTxtBlock1.Size = new System.Drawing.Size(121, 20);
            this.WTxtBlock1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox1.Location = new System.Drawing.Point(117, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Wblock4
            // 
            this.Wblock4.AutoSize = true;
            this.Wblock4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Wblock4.Location = new System.Drawing.Point(84, 179);
            this.Wblock4.Name = "Wblock4";
            this.Wblock4.Size = new System.Drawing.Size(0, 16);
            this.Wblock4.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(38, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Blok :";
            // 
            // Wblock3
            // 
            this.Wblock3.AutoSize = true;
            this.Wblock3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Wblock3.Location = new System.Drawing.Point(84, 140);
            this.Wblock3.Name = "Wblock3";
            this.Wblock3.Size = new System.Drawing.Size(0, 16);
            this.Wblock3.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(38, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Blok :";
            // 
            // Wblock2
            // 
            this.Wblock2.AutoSize = true;
            this.Wblock2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Wblock2.Location = new System.Drawing.Point(84, 101);
            this.Wblock2.Name = "Wblock2";
            this.Wblock2.Size = new System.Drawing.Size(0, 16);
            this.Wblock2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(38, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Blok :";
            // 
            // Wblock1
            // 
            this.Wblock1.AutoSize = true;
            this.Wblock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Wblock1.Location = new System.Drawing.Point(84, 66);
            this.Wblock1.Name = "Wblock1";
            this.Wblock1.Size = new System.Drawing.Size(0, 16);
            this.Wblock1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Blok :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sektör No :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // uidChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 485);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "uidChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uidChanege";
            this.Load += new System.EventHandler(this.uidChanege_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCodeUploader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConnectStatus;
        private System.Windows.Forms.ComboBox cmbSerialPorts;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangeUID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnReadUID;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnReadSector;
        private System.Windows.Forms.TextBox RTxtBlock4;
        private System.Windows.Forms.TextBox RTxtBlock3;
        private System.Windows.Forms.TextBox RTxtBlock2;
        private System.Windows.Forms.TextBox RTxtBlock1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label Rblock4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Rblock3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Rblock2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label Rblock1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnWriteSector;
        private System.Windows.Forms.TextBox WTxtBlock4;
        private System.Windows.Forms.TextBox WTxtBlock3;
        private System.Windows.Forms.TextBox WTxtBlock2;
        private System.Windows.Forms.TextBox WTxtBlock1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Wblock4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Wblock3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Wblock2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Wblock1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}