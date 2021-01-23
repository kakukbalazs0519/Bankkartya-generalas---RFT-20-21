﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Credit_card
{
    public partial class Form1 : Form
    {
        public AdatbázisQleDb odb;
        protected string tipus="";
        protected int hanyszor = 1;
        public Form1()
        {
            InitializeComponent();
            Atlatszo(CardNumber_Label);
            Atlatszo(validlabel);
            Atlatszo(Namelabel);
            Atlatszo(Card4N_label);
            atlatszo(Alairas_label);
            atlatszo(CCV_label);
            odb = AdatbázisQleDb.PeldanySzerez();
            odb.Kapcsolódás(Environment.CurrentDirectory + @"\Creditcard.accdb");

        }
        public class AdatbázisQleDb
        {
            protected DataSet ds;
            protected OleDbDataAdapter oda;
            protected DataTable dt;
            protected OleDbCommand oc;
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + @"\Creditcard.accdb" + ";");

            #region Singleton

            public AdatbázisQleDb()
            {
            }
            public static AdatbázisQleDb sajat;
            public static AdatbázisQleDb PeldanySzerez()
            {
                if (sajat == null) sajat = new AdatbázisQleDb();
                return sajat;
            }

            #endregion

            public bool Kapcsolódás(string Adatbázisfájl)
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (OleDbException ode)
                {

                    MessageBox.Show(ode.Message);
                    return false;
                }
                finally
                {
                    Lekapcsolódás();
                }
            }
            public void Lekapcsolódás()
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    //conn.Dispose();
                }
            }

            public void Mentes(string Kartya_tipus, string Kartya_szama,bool valodi,string ervenyesseg,string tulajdonos)
            {
                try
                {
                    conn.Open();
                    string query = String.Format("INSERT INTO Credit_card (Kartya_tipus, Kartya_szama, Valodi, Ervenyessegi_ido, Tulajdonos) VALUES ('{0}','{1}',{2},'{3}','{4}');", Kartya_tipus, Kartya_szama, Convert.ToBoolean(valodi), ervenyesseg, tulajdonos);
                    oda = new OleDbDataAdapter(query, conn);
                    ds = new DataSet();
                    oda.Fill(ds);
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); }
                finally { Lekapcsolódás(); }
            }
            public int Code(string lekérdezés)
            {
                try
                {
                    conn.Open();
                    ds = new DataSet();//Összes tábla megjelenítése
                    oc = new OleDbCommand(lekérdezés, conn);
                    OleDbDataReader odr;
                    odr = oc.ExecuteReader();//Adatkeresés
                    int count = 0;
                    while (odr.Read())
                    {
                        count += 1;
                    }
                    switch (count)
                    {
                        case 0: odr.Close(); return 0;
                        default:
                            odr.Close();
                            MessageBox.Show("Van már ilyen kódszám!");
                            
                            return 1;
                    }
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); /*Logger.Error(ode.Message, "Lekérdezői hiba!");*/ }
                finally { Lekapcsolódás(); }
                return 0;
            }
        }
        public static Generate gen = new Generate();

        private void Atlatszo(Label x)
        {
            var pos = this.PointToScreen(x.Location);
            pos = pictureBox1.PointToClient(pos);
            x.Parent = pictureBox1;
            x.Location = pos;
            x.BackColor = Color.Transparent;
        }
        private void atlatszo(Label y)
        {
            var pos = this.PointToScreen(y.Location);
            pos = pictureBox2.PointToClient(pos);
            y.Parent = pictureBox2;
            y.Location = pos;
            y.BackColor = Color.Transparent;
        }
        private void CardTipus(object sender, EventArgs e)
        {
            Valódi_checkbox.Checked = false;
            try
            {
                RadioButton btn = sender as RadioButton;
                if (btn != null && btn.Checked)
                {
                    tipus = btn.Text;
                    switch (btn.Text)
                    {
                        
                        case "Amex": cardnumber_textbox.Text = string.Format(Generate.GenerateCardNumber(Generate.AMEX_PREFIX_LIST, 16));
                            CardNumber_Label.ForeColor = Color.Blue;
                            break;
                        case "Diners": cardnumber_textbox.Text = string.Format(Generate.GenerateCardNumber(Generate.DINERS_PREFIX_LIST, 16));
                            CardNumber_Label.ForeColor = Color.CadetBlue;
                            break;
                        case "Discover": cardnumber_textbox.Text = string.Format(Generate.GenerateCardNumber(Generate.DISCOVER_PREFIX_LIST, 16));
                            CardNumber_Label.ForeColor = Color.Orange;
                            break;
                        case "Enroute": cardnumber_textbox.Text = string.Format(Generate.GenerateCardNumber(Generate.ENROUTE_PREFIX_LIST, 16));
                            CardNumber_Label.ForeColor = Color.Silver;
                            break;
                        case "JCB-15": cardnumber_textbox.Text = string.Format(Generate.GenerateCardNumber(Generate.JCB_15_PREFIX_LIST, 15));
                            CardNumber_Label.ForeColor = Color.LimeGreen;
                            break;
                        case "JCB-16": cardnumber_textbox.Text = string.Format(Generate.GenerateCardNumber(Generate.JCB_16_PREFIX_LIST, 16));
                            CardNumber_Label.ForeColor = Color.Lime;
                            break;
                        case "Mastercard": cardnumber_textbox.Text = string.Format(Generate.GenerateCardNumber(Generate.MASTERCARD_PREFIX_LIST, 16));
                            CardNumber_Label.ForeColor = Color.OrangeRed;
                            break;
                        case "Visa": cardnumber_textbox.Text = string.Format(Generate.GenerateCardNumber(Generate.VISA_PREFIX_LIST, 16));
                            CardNumber_Label.ForeColor = Color.RoyalBlue;
                            break;
                        case "Voyager": cardnumber_textbox.Text = string.Format(Generate.GenerateCardNumber(Generate.VOYAGER_PREFIX_LIST, 16));
                            CardNumber_Label.ForeColor = Color.Goldenrod;
                            break;
                        default: throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kártya típus hiba!");
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (cardnumber_textbox.Text.Length == 16 && hanyszor==1|| cardnumber_textbox.Text.Length == 15 && hanyszor==1)
            {
                hanyszor += 1;
                kiír();
                CCV_label.Text= gen.CVV(cardnumber_textbox.Text);
            }
            
        }
        private void kiír()
        {
            try
            {
                string number = cardnumber_textbox.Text;
                /*int x = odb.Code(String.Format("Select Kartya_szama from Credit_card where Kartya_szama = {0}", number));
                  switch (x)
                  {
                      case 0: break;
                      default: CardTipus(sender, e);
                          break;
                  }*/
                string elso;
                string masodik;
                string harmadik;
                string negyedik;
                //string otodik;

                if (cardnumber_textbox.Text.Length == 16)
                {
                    elso = number.Substring(0, 4);
                    masodik = number.Substring(4, 4);
                    harmadik = number.Substring(8, 4);
                    negyedik = number.Substring(12, 4);
                    CardNumber_Label.Text = string.Format("{0} {1} {2} {3}", elso, masodik, harmadik, negyedik);
                }
                else
                {
                    elso = number.Substring(0, 4);
                    masodik = number.Substring(4, 4);
                    harmadik = number.Substring(8, 4);
                    negyedik = number.Substring(12, 3);
                    CardNumber_Label.Text = string.Format("{0} {1} {2} {3}", elso, masodik, harmadik, negyedik);
                }
                Card4N_label.Text = cardnumber_textbox.Text.Substring(0, 4);

                if (gen.Valódi(cardnumber_textbox.Text))
                {
                    Valódi_checkbox.Checked = true;
                }
                //ApplyStyleTo(CardNumber_Label);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void ApplyStyleTo(Label label)
        {
            label.ForeColor = GetLabelForeColor(label.Text);
        }

        private Color GetLabelForeColor(string text)
        {
            if (text.Substring(5, 1) == text)
            {
                text.Substring(5, 1);
                //Szín
            }
            return (text != null && text.Substring(5, 1) == text) ? Color.Red : Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void Validnumber_textBox_TextChanged(object sender, EventArgs e)
        {
            validlabel.Text = dateTimePicker1.Value.Date.ToString("MM/yy");
            validlabel.Text = validlabel.Text.Replace(".", "/");
        }

        private void Cardtulaj_textBox1_TextChanged(object sender, EventArgs e)
        {
            Namelabel.Text = Cardtulaj_textBox1.Text;
            Alairas_label.Text = Cardtulaj_textBox1.Text;
        }
        private void cardnumber_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46 && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void Cardtulaj_textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Mentes_button_Click(object sender, EventArgs e)
        {
            try
            {
                odb = new AdatbázisQleDb();
                odb.Mentes(tipus, cardnumber_textbox.Text, Valódi_checkbox.Checked, Convert.ToString(dateTimePicker1.Value), Namelabel.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                throw;
            }
           
        }



    }
}
