using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bakiye = 0, toplam_satilan, salon1SatilanKoltukSayisi, salon2SatilanKoltukSayisi, biletSayisi;

        private void salon1()
        {
            int Koltuk_Sayisi;
            string Salon_NO;
            Salon_NO = comboBox1.Text;
            Koltuk_Sayisi = Convert.ToInt16(textBox2.Text);
            label5.Text = Koltuk_Sayisi.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam Bakiye:");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam Satılan Koltuk: " + biletSayisi + "\nSalon 1'de Boş Koltuk Sayisi");
        }

        private void salon2()
        {
            int Koltuk_Sayisi;
            string Salon_NO;
            Salon_NO = comboBox1.Text;
            Koltuk_Sayisi = Convert.ToInt16(textBox2.Text);
            label11.Text = Koltuk_Sayisi.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Salon1")
            {
                salon1();
            }
            else if (comboBox1.Text == "Salon2")
            {
                salon2();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Salon1")
            {

                int koltukSayisi = Convert.ToInt32(label5.Text);
                if (koltukSayisi > 0)
                {

                    koltukSayisi--;
                    label5.Text = koltukSayisi.ToString();


                    biletSayisi = Convert.ToInt32(label7.Text);
                    biletSayisi++;
                    label7.Text = biletSayisi.ToString();
                    if (checkBox1.Checked)
                    {
                        bakiye += 100;

                        label16.Text = bakiye.ToString();
                    }
                    else
                    {
                        bakiye += 150;
                        label16.Text = bakiye.ToString();
                    }



                }
                else
                {
                    MessageBox.Show("Salon1'de daha fazla bilet satılamaz!");
                }
            }

            else if (comboBox3.Text == "Salon2")
            {
                int koltukSayisi = Convert.ToInt32(label11.Text);
                if (koltukSayisi > 0)
                {
                    koltukSayisi--;
                    label11.Text = koltukSayisi.ToString();

                    biletSayisi = Convert.ToInt32(label9.Text);
                    biletSayisi++;
                    label9.Text = biletSayisi.ToString();
                    if (checkBox1.Checked)
                    {
                        bakiye += 100;

                        label16.Text = bakiye.ToString();
                    }
                    else
                    {
                        bakiye += 150;
                        label16.Text = bakiye.ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Salon2'de daha fazla bilet satılamaz!");
                }
            }




            salon1SatilanKoltukSayisi = Convert.ToInt16(label7.Text);
            salon2SatilanKoltukSayisi = Convert.ToInt16(label9.Text);
            toplam_satilan = salon1SatilanKoltukSayisi + salon2SatilanKoltukSayisi;
            label18.Text = toplam_satilan++.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Salon1")
            {
                // Salon1'deki koltuk sayısını arttırıyoruz
                int koltukSayisi = Convert.ToInt32(label5.Text);
                koltukSayisi++;
                label5.Text = koltukSayisi.ToString();

                // Salon1'de satılan bilet sayısını bir azaltıyoruz
                biletSayisi = Convert.ToInt32(label7.Text);
                if (biletSayisi > 0) // Satılan bilet sayısı sıfırdan fazla olmalı
                {
                    biletSayisi--;
                    label7.Text = biletSayisi.ToString();
                }
                if (checkBox1.Checked)
                {
                    bakiye -= 100;

                    label16.Text = bakiye.ToString();
                }
                else
                {
                    bakiye -= 150;
                    label16.Text = bakiye.ToString();
                }
                salon1SatilanKoltukSayisi = Convert.ToInt16(label7.Text);
                salon2SatilanKoltukSayisi = Convert.ToInt16(label9.Text);
                toplam_satilan = salon1SatilanKoltukSayisi + salon2SatilanKoltukSayisi;
                label18.Text = toplam_satilan--.ToString();

                MessageBox.Show("Salon1'den Boş Koltuk Silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBox3.Text == "Salon2")
            {
                // Salon2'deki koltuk sayısını arttırıyoruz
                int koltukSayisi = Convert.ToInt32(label11.Text);
                koltukSayisi++;
                label11.Text = koltukSayisi.ToString();

                // Salon2'de satılan bilet sayısını bir azaltıyoruz
                int biletSayisi = Convert.ToInt32(label9.Text);
                if (biletSayisi > 0) // Satılan bilet sayısı sıfırdan fazla olmalı
                {
                    biletSayisi--;
                    label9.Text = biletSayisi.ToString();
                }
                if (checkBox1.Checked)
                {
                    bakiye -= 100;

                    label16.Text = bakiye.ToString();
                }
                else
                {
                    bakiye -= 150;
                    label16.Text = bakiye.ToString();
                }
                salon1SatilanKoltukSayisi = Convert.ToInt16(label7.Text);
                salon2SatilanKoltukSayisi = Convert.ToInt16(label9.Text);
                toplam_satilan = salon1SatilanKoltukSayisi + salon2SatilanKoltukSayisi;
                label18.Text = toplam_satilan--.ToString();

                MessageBox.Show("Salon2'den Boş Koltuk Silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir salon seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
