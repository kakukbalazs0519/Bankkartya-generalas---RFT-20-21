using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Credit_card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string number = cardnumber_textbox.Text;
            string elso;
            string masodik;
            string harmadik;
            string negyedik;
            if (cardnumber_textbox.Text.Length == 16)
            {
                elso = number.Substring(0, 4); // első 4 karakter 
                masodik = number.Substring(5, 4); // második 4 karakter
                harmadik = number.Substring(8, 4); // harmadik 4 karakter
                negyedik = number.Substring(12, 4); // negyedik 4 karakter
                CardNumber_Label.Text = string.Format("{0} {1} {2} {3}", elso, masodik, harmadik, negyedik);
            }
            else
            {
                elso = number.Substring(0, 4);
                masodik = number.Substring(5, 4);
                harmadik = number.Substring(8, 4);
                negyedik = number.Substring(12, 3);
                CardNumber_Label.Text = string.Format("{0} {1} {2} {3}", elso, masodik, harmadik, negyedik);
            }
            Card4N_label.Text = cardnumber_textbox.Text.Substring(0, 4);//Első 4 karakter megjelenítő
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"F:\Zoltán\Kakuk Balázs\Redwoods\PCC front.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile(@"F:\Zoltán\Kakuk Balázs\Redwoods\PCC back.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void validlabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
