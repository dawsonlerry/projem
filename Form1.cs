using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp70
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat, dakika, saniye;
        void temizle()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = "0";
            label2.Text = "0";
            saniye = 0;
            dakika = 0;
            saniye = 0;
            timer1.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Hide();
        }
    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kesilensaat, kesilendadika;
            kesilensaat = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Add(kesilensaat);
            kesilendadika = Convert.ToInt32(textBox2.Text);
            listBox2.Items.Add(kesilendadika);
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult bilgi = MessageBox.Show("Saati başına 0 koymadan sadece tek sayı olarak giriniz, nokta veya başka birşey kullanmayınız", "BILGI KULLANIM!", MessageBoxButtons.OKCancel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult bilgi = MessageBox.Show("TK,TALOS,SQ SAATLERI 8 SAAT OLARAK AYARLANMISTIR", "BILGI KULLANIM!", MessageBoxButtons.OKCancel);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Herhangi Bi Boss ismi Seçmediniz!", "HATA");
            }
            else
            {
                timer1.Enabled = true;
                MessageBox.Show("ALARMI KURDUNUZ SAAT GELDIGINDE ALARM CALACAKTIR", "BASARILI");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = saat.ToString();
            label2.Text = dakika.ToString();
            label3.Text = saniye.ToString();
            saniye++;


            if (saniye >= 60)
            {
                dakika++;
                saniye = 0;

            }
            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }
            if(comboBox1.Text == "Troll King" && label1.Text == "8")
            {
                timer1.Enabled = false;
                DialogResult mesaj = MessageBox.Show("Boss Saati geldi", "ALARM", MessageBoxButtons.OKCancel);
                axWindowsMediaPlayer1.URL = @"C:\Users\Steady\Documents\Visual Studio 2017\Projects\WindowsFormsApp70\WindowsFormsApp70\bin\Debug\muzik\1.mp3";


            }
            if (comboBox1.Text == "Talos" && label1.Text == "8")
            {
                timer1.Enabled = false;
                axWindowsMediaPlayer1.URL = @"C:\Users\Steady\Documents\Visual Studio 2017\Projects\WindowsFormsApp70\WindowsFormsApp70\bin\Debug\muzik\1.mp3";
                DialogResult mesaj = MessageBox.Show("Boss Saati geldi", "ALARM", MessageBoxButtons.OKCancel);
                if(mesaj == DialogResult.OK)
                {
                    axWindowsMediaPlayer1.URL = "";
                }
             
            }
            if (comboBox1.Text == "Snake-Queen" && label2.Text == "1")
            {
                timer1.Enabled = false;
                axWindowsMediaPlayer1.URL = @"C:\Users\Steady\Documents\Visual Studio 2017\Projects\WindowsFormsApp70\WindowsFormsApp70\bin\Debug\muzik\1.mp3";
                DialogResult mesaj = MessageBox.Show("Boss Saati geldi", "ALARM", MessageBoxButtons.OKCancel);
               
            }
            if (comboBox1.Text == "Harpy-Queen" && label1.Text == "6")
            {
                timer1.Enabled = false;
                axWindowsMediaPlayer1.URL = @"C:\Users\Steady\Documents\Visual Studio 2017\Projects\WindowsFormsApp70\WindowsFormsApp70\bin\Debug\muzik\1.mp3";
                DialogResult mesaj = MessageBox.Show("Boss Saati geldi", "ALARM", MessageBoxButtons.OKCancel);
              
            }
            if (comboBox1.Text == "Samma" && label1.Text == "6")
            {
                timer1.Enabled = false;
                axWindowsMediaPlayer1.URL = @"C:\Users\Steady\Documents\Visual Studio 2017\Projects\WindowsFormsApp70\WindowsFormsApp70\bin\Debug\muzik\1.mp3";
                DialogResult mesaj = MessageBox.Show("Boss Saati geldi", "ALARM", MessageBoxButtons.OKCancel);
             
            }
            if (comboBox1.Text == "Deruvish Founder" && label2.Text == "6")
            {
                timer1.Enabled = false;
                axWindowsMediaPlayer1.URL = @"C:\Users\Steady\Documents\Visual Studio 2017\Projects\WindowsFormsApp70\WindowsFormsApp70\bin\Debug\muzik\1.mp3";
                DialogResult mesaj = MessageBox.Show("Boss Saati geldi", "ALARM", MessageBoxButtons.OKCancel);
               
            }
            if (comboBox1.Text == "Shaula" && label1.Text == "6")
            {
                timer1.Enabled = false;
                axWindowsMediaPlayer1.URL = @"C:\Users\Steady\Documents\Visual Studio 2017\Projects\WindowsFormsApp70\WindowsFormsApp70\bin\Debug\muzik\1.mp3";
                DialogResult mesaj = MessageBox.Show("Boss Saati geldi", "ALARM", MessageBoxButtons.OKCancel);
                
            }

            if (label1.Text == textBox1.Text && label2.Text == textBox2.Text)
            {
                timer1.Enabled = false;
                axWindowsMediaPlayer1.URL = @"C:\Users\Steady\Documents\Visual Studio 2017\Projects\WindowsFormsApp70\WindowsFormsApp70\bin\Debug\muzik\1.mp3";
                DialogResult mesaj = MessageBox.Show("Boss Saati geldi", "ALARM", MessageBoxButtons.OKCancel);
                if (mesaj == DialogResult.OK)
                {
                    axWindowsMediaPlayer1.URL = "";
                }

            }
            {

            }
        }
    }
}
