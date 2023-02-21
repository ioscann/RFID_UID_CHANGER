namespace RFID_UID_CHANGER
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu_Panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCircutShema = new System.Windows.Forms.Button();
            this.btnUIDChange = new System.Windows.Forms.Button();
            this.up_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.mdi_Panel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menu_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.up_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Panel
            // 
            this.menu_Panel.BackColor = System.Drawing.Color.Gold;
            this.menu_Panel.Controls.Add(this.pictureBox2);
            this.menu_Panel.Controls.Add(this.pictureBox1);
            this.menu_Panel.Controls.Add(this.btnCircutShema);
            this.menu_Panel.Controls.Add(this.btnUIDChange);
            this.menu_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_Panel.Location = new System.Drawing.Point(0, 0);
            this.menu_Panel.Name = "menu_Panel";
            this.menu_Panel.Size = new System.Drawing.Size(158, 511);
            this.menu_Panel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(78, 295);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCircutShema
            // 
            this.btnCircutShema.BackColor = System.Drawing.Color.Turquoise;
            this.btnCircutShema.FlatAppearance.BorderSize = 0;
            this.btnCircutShema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircutShema.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCircutShema.Location = new System.Drawing.Point(0, 228);
            this.btnCircutShema.Name = "btnCircutShema";
            this.btnCircutShema.Size = new System.Drawing.Size(158, 70);
            this.btnCircutShema.TabIndex = 2;
            this.btnCircutShema.Text = "Devre Şeması";
            this.btnCircutShema.UseVisualStyleBackColor = false;
            this.btnCircutShema.Click += new System.EventHandler(this.btnCircutShema_Click);
            // 
            // btnUIDChange
            // 
            this.btnUIDChange.BackColor = System.Drawing.Color.Turquoise;
            this.btnUIDChange.FlatAppearance.BorderSize = 0;
            this.btnUIDChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUIDChange.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUIDChange.Location = new System.Drawing.Point(0, 161);
            this.btnUIDChange.Name = "btnUIDChange";
            this.btnUIDChange.Size = new System.Drawing.Size(158, 70);
            this.btnUIDChange.TabIndex = 0;
            this.btnUIDChange.Text = "Kart İşlemleri";
            this.btnUIDChange.UseVisualStyleBackColor = false;
            this.btnUIDChange.Click += new System.EventHandler(this.btnUIDChange_Click);
            // 
            // up_Panel
            // 
            this.up_Panel.BackColor = System.Drawing.Color.Gold;
            this.up_Panel.Controls.Add(this.label1);
            this.up_Panel.Controls.Add(this.exitBtn);
            this.up_Panel.Controls.Add(this.btnMinimize);
            this.up_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.up_Panel.Location = new System.Drawing.Point(158, 0);
            this.up_Panel.Name = "up_Panel";
            this.up_Panel.Size = new System.Drawing.Size(777, 26);
            this.up_Panel.TabIndex = 1;
            this.up_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.up_Panel_MouseDown);
            this.up_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.up_Panel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "RFID UID DEĞİŞTİRİCİ";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(754, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(20, 20);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(728, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // mdi_Panel
            // 
            this.mdi_Panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mdi_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdi_Panel.Location = new System.Drawing.Point(158, 26);
            this.mdi_Panel.Name = "mdi_Panel";
            this.mdi_Panel.Size = new System.Drawing.Size(777, 485);
            this.mdi_Panel.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 511);
            this.Controls.Add(this.mdi_Panel);
            this.Controls.Add(this.up_Panel);
            this.Controls.Add(this.menu_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.menu_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.up_Panel.ResumeLayout(false);
            this.up_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_Panel;
        private System.Windows.Forms.Panel up_Panel;
        private System.Windows.Forms.Panel mdi_Panel;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnUIDChange;
        private System.Windows.Forms.Button btnCircutShema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

