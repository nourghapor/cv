using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tc, ad, cins="", mevzu="", dil="", yaz="",yas;
            yas = textBox3.Text;
               tc = textBox1.Text;
            ad = textBox2.Text;
            if (radioButton1.Checked==true)
            {
                cins = radioButton1.Text;
            }
            else if (radioButton2.Checked==true)
            {
                cins = radioButton2.Text;
            }
            if (radioButton3.Checked==true)
            {
                mevzu = radioButton3.Text;
            }
            else if (radioButton4.Checked == true)
            {
                mevzu = radioButton4.Text;
            }
            else if(radioButton5.Checked == true)
            {
                mevzu = radioButton5.Text;
            }
            else if (radioButton6.Checked == true)
            {
                mevzu = radioButton6.Text;
            }
            else if (radioButton7.Checked == true)
            {
                mevzu = radioButton7.Text;
            }
            if (checkBox1.Checked==true)
            {
                dil = dil+","+ checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                dil = dil + "," + checkBox2.Text;
            }
            if (checkBox3.Checked == true)
            {
                dil = dil + "," + checkBox3.Text;
            }
            if (checkBox4.Checked == true)
            {
                dil = dil + "," + checkBox4.Text;
            }
            if(checkBox5.Checked == true)
            {
                dil = dil + "," + checkBox5.Text;
            }
            if (checkBox6.Checked == true)
            {
                dil = dil + "," + checkBox6.Text;
            }
            if (checkBox7.Checked==true)
            {
                yaz = yaz + "," + checkBox7;
            }
            if (checkBox9.Checked == true)
            {
                yaz = yaz + "," + checkBox9;
            }
            if (checkBox8.Checked == true)
            {
                yaz = yaz + "," + checkBox8;
            }
            if (checkBox10.Checked == true)
            {
                yaz = yaz + "," + checkBox10;
            }
            if (checkBox11.Checked == true)
            {
                yaz = yaz + "," + checkBox11;
            }
            if (checkBox12.Checked == true)
            {
                yaz = yaz + "," + checkBox12;
            }
            dil=dil.Substring(1);
            yaz=yaz.Substring(1);
            listBox1.Items.Add("isminiz: " + ad + "" + "tcniz: " + tc + "" +"yaşınız: "+yas+""+"cinsiyet: "+cins+""+ "mevzuniet: "+mevzu+""+"bildiğiniz diller"+dil+""+"bilidiğiniz yazlım dilleri"+yaz);

        }


        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                groupBox1.ForeColor = Color.White;
                groupBox2.ForeColor = Color.White;
                groupBox3.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                groupBox1.ForeColor = Color.Black;
                groupBox2.ForeColor = Color.Black;
                groupBox3.ForeColor = Color.Black;
            }
        }
    }
}
