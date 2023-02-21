using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using RFID_UID_CHANGER.Forms;

namespace RFID_UID_CHANGER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int mouseX, mouseY;

        uidChange uidForm = new uidChange();

        schema schemaForm = new schema();

        private void drag(bool Event)
        {
            if (Event == true)
            {
                timer1.Start();
                mouseX = MousePosition.X - this.Left;
                mouseY = MousePosition.Y - this.Top;
            }
            else { timer1.Stop(); }
        }

        void openForm(string form)
        {
            if (form == "uidchange")
            {
                mdi_Panel.Controls.Clear();
                uidForm.TopLevel = false;
                mdi_Panel.Controls.Add(uidForm);

                uidForm.Show();
                uidForm.Dock = DockStyle.Fill;
                uidForm.BringToFront();
            }
            else if (form == "schema")
            {
                mdi_Panel.Controls.Clear();
                schemaForm.TopLevel = false;
                mdi_Panel.Controls.Add(schemaForm);

                schemaForm.Show();
                uidForm.Dock = DockStyle.Fill;
                uidForm.BringToFront();
            }
        }

        void buttonCheck()
        {
            btnCircutShema.BackColor = Color.Turquoise;
            btnUIDChange.BackColor = Color.Turquoise;
        }

        private void btnMinimize_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }

        private void up_Panel_MouseDown(object sender, MouseEventArgs e) { drag(true); }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            bool language = uidChange.language;

            if (language == false)
            {
                DialogResult = MessageBox.Show("Çıkmak istiyor musun ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes) { Application.Exit(); }
            }
            else
            {
                DialogResult = MessageBox.Show("Do you want to go out ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes) { Application.Exit(); }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Left = MousePosition.X - mouseX;
            this.Top = MousePosition.Y - mouseY;
        }

        private void up_Panel_MouseUp(object sender, MouseEventArgs e) 
        { 
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                drag(false);
            }
            else { drag(false); }
        }     

        private void btnCircutShema_Click(object sender, EventArgs e)
        {
            buttonCheck();
            openForm("schema");
            btnCircutShema.BackColor = Color.Green;
            btnCircutShema.Enabled= false;
            btnUIDChange.Enabled= true;
        }

        private void pictureBox1_Click(object sender, EventArgs e) 
        { 
            uidChange.language = false;
            pictureBox1.Enabled = false; 
            pictureBox2.Enabled = true; 
            label1.Text = "RFID UID DEĞİŞTİRİCİ"; 
            btnUIDChange.Text = "Kart işlemleri"; 
            btnCircutShema.Text = "Devre şeması"; 
        }

        private void pictureBox2_Click(object sender, EventArgs e) 
        {
            uidChange.language = true; 
            pictureBox2.Enabled = false; 
            pictureBox1.Enabled = true; 
            label1.Text = "RFID UID CHANGER"; 
            btnUIDChange.Text = "Card porcesses"; 
            btnCircutShema.Text = "Circut schema"; 
        }

        private void btnUIDChange_Click(object sender, EventArgs e)
        {
            buttonCheck();
            openForm("uidchange");
            btnUIDChange.BackColor = Color.Green;
            btnUIDChange.Enabled = false;
            btnCircutShema.Enabled = true;
        }
    }
}
