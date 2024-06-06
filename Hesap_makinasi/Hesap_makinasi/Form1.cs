using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hesap_makinası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public char _islem;
        public bool _clear;
        public int _sayi1;


        
        private List<string> gecmis = new List<string>();
        private void Ekran_tbox_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if ( _clear)
            { 
                Ekran_tbox.Text = "";
             _clear = false;

            }


            if (Ekran_tbox.Text == "0" )Ekran_tbox.Text = "";

            Ekran_tbox.Text += "1";
            işlem_lbl.Text += "1";
        }

        private void btn_toplam_Click(object sender, EventArgs e)
        {
             _islem = '+';
             _clear=true;
             _sayi1 =Convert.ToInt32(Ekran_tbox.Text);
            işlem_lbl.Text += "+";
        }

        private void esittir_btn_Click(object sender, EventArgs e)
        {
            int sayi2 = Convert.ToInt32(Ekran_tbox.Text);
            int sonuc;
            işlem_lbl.Text = " ";

            switch ( _islem)
            {
                case '+':
                    sonuc =  _sayi1+sayi2 ;
                    break;
                case '-':
                    sonuc = _sayi1 - sayi2;
                    break;
                case '*':
                    sonuc = _sayi1 * sayi2;
                    break;
                case '/':
                    if (sayi2 != 0)
                    {
                        sonuc = _sayi1 / sayi2;
                    }
                    else
                    {
                        MessageBox.Show("Bölen 0 olamaz !");
                        return;
                    }
                    break;
                    

                default:
                    sonuc = 0;
                    break;
            }


            // İşlem geçmişine ekleme
            string gecmisGirdisi = $"{_sayi1} {_islem} {sayi2} = {sonuc}";
            gecmis.Add(gecmisGirdisi);
            GecmisiGuncelle();

            Ekran_tbox.Text = Convert.ToString(sonuc);
        }
        private void GecmisiGuncelle()
        {

            geçmiş2_lbl.Text= " ";
            foreach (string girdisi in gecmis)
            {
                geçmiş2_lbl.Text=Convert.ToString(girdisi);
            }
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            if ( _clear)
            {
                Ekran_tbox.Text = "";
                 _clear = false;
            }


            if (Ekran_tbox.Text == "0") Ekran_tbox.Text = "";

            Ekran_tbox.Text += "2";
            işlem_lbl.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if ( _clear)
            {
                Ekran_tbox.Text = "";
                 _clear = false;
            }


            if (Ekran_tbox.Text == "0") Ekran_tbox.Text = "";

            işlem_lbl.Text += "3";
            Ekran_tbox.Text += "3";
        }

        private void eksi_btn_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _clear = true;
            _sayi1 = Convert.ToInt32(Ekran_tbox.Text);
            işlem_lbl.Text += "-";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (_clear)
            {
                Ekran_tbox.Text = "";
                _clear = false;
            }


            if (Ekran_tbox.Text == "0") Ekran_tbox.Text = "";

            Ekran_tbox.Text += "4";
            işlem_lbl.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (_clear)
            {
                Ekran_tbox.Text = "";
                _clear = false;
            }


            if (Ekran_tbox.Text == "0") Ekran_tbox.Text = "";

            Ekran_tbox.Text += "5";
            işlem_lbl.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (_clear)
            {
                Ekran_tbox.Text = "";
                _clear = false;
            }


            if (Ekran_tbox.Text == "0") Ekran_tbox.Text = "";

            Ekran_tbox.Text += "6";
            işlem_lbl.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (_clear)
            {
                Ekran_tbox.Text = "";
                _clear = false;
            }


            if (Ekran_tbox.Text == "0") Ekran_tbox.Text = "";

            Ekran_tbox.Text += "7";
            işlem_lbl.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (_clear)
            {
                Ekran_tbox.Text = "";
                _clear = false;
            }


            if (Ekran_tbox.Text == "0") Ekran_tbox.Text = "";
            işlem_lbl.Text += "8";
            Ekran_tbox.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (_clear)
            {
                Ekran_tbox.Text = "";
                _clear = false;
            }


            if (Ekran_tbox.Text == "0") Ekran_tbox.Text = "";

            Ekran_tbox.Text += "9";
            işlem_lbl.Text += "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (_clear)
            {
                Ekran_tbox.Text = "";
                _clear = false;
            }


            if (Ekran_tbox.Text == "0") Ekran_tbox.Text = "";

            Ekran_tbox.Text += "0"; işlem_lbl.Text += "0";
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _clear = true;
            _sayi1 = Convert.ToInt32(Ekran_tbox.Text);
            işlem_lbl.Text += "*";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ekran_tbox.Text = " ";
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {

            _islem = '/';
            _clear = true;
            _sayi1 = Convert.ToInt32(Ekran_tbox.Text);
            işlem_lbl.Text += "/";

        }

        private void kare_btn_Click(object sender, EventArgs e)
        {
            try
            {
                
                // Kullanıcının girdiği sayıyı oku
                double number = double.Parse(Ekran_tbox.Text);

                

                // Sayının karekökünü hesapla
                double karekok = Math.Sqrt(number);

                // Sonucu göster
                Ekran_tbox.Text = $"Karekök: {karekok}";
            }
            catch (FormatException)
            {
                // Kullanıcı geçersiz bir giriş yaptığında
                MessageBox.Show("Lütfen geçerli bir sayı girin.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ekran_tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<char> _sayi = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',',' };

            if (!_sayi.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    }

