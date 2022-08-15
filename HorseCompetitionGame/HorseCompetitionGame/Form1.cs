using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseCompetitionGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int birinciatsaguzaklik, ikinciatsaguzaklik;
        int deger = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Enabled = false;
            button1.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsaguzaklik = pictureBox2.Left;
            ikinciatsaguzaklik = pictureBox3.Left;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Text = "0";
            button3.Text = "0";
            deger = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();//açık pencereyi kapatır
            Application.Exit();//açık olan tüm formları kapatır
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            deger = Convert.ToInt32(button3.Text);
            deger++;
            button3.Text = deger.ToString();
            if (deger==10)
            {
                deger = 0;
                int saniye = Convert.ToInt32(button2.Text);
                saniye++;
                button2.Text = saniye.ToString();
                deger = 0;
                button3.Text = deger.ToString();
            }
            int birinciatgenislik, ikinciatgenislik,bitis;
            birinciatgenislik = pictureBox2.Width;
            ikinciatgenislik = pictureBox3.Width;
            bitis = pictureBox1.Left;
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 13);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 13);

            if (pictureBox2.Left+birinciatgenislik>bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("Birinci kulvardaki at kazandı!");
            }
            if (pictureBox3.Left+ikinciatgenislik>bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("ikinci kulvardaki at kazandı!");
            }

            if (pictureBox2.Left>pictureBox3.Left)
            {
                label1.Text=("Birinci kulvardaki at süratlenerek öne geçti ");
                
            }
            if (pictureBox2.Left < pictureBox3.Left)
            {
                label1.Text=("İkinci kulvardaki at hızlanarak öne geçti");
                
            }
        }
    }
}
