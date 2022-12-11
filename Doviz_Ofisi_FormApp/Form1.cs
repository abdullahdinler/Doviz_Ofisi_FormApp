using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Convert;
using System.Data.SqlClient;

namespace Doviz_Ofisi_FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DovizOfisDB;Integrated Security=True");


        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dovizOfisDBDataSet6.SatilanDoviz' table. You can move, or remove it, as needed.
            this.satilanDovizTableAdapter.Fill(this.dovizOfisDBDataSet6.SatilanDoviz);
            // TODO: This line of code loads data into the 'dovizOfisDBDataSet5.AlinanDoviz' table. You can move, or remove it, as needed.
            this.alinanDovizTableAdapter.Fill(this.dovizOfisDBDataSet5.AlinanDoviz);

            
        }

        private void UsdToplamSatilan(string doviz)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select SUM(AMOUNT) FROM SatilanDoviz WHERE DOVIZ_GENUS = @p1", con);
            com.Parameters.AddWithValue("@p1", doviz);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Lbl_dovizsatılan.Text = dr[0].ToString();
            }

            con.Close();
        }

        private void UsdToplamAlinan(string doviz)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select SUM(AMOUNT) FROM AlinanDoviz WHERE DOVIZ_GENUS = @p1", con);
            com.Parameters.AddWithValue("@p1", doviz);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Lbl_dovizalınan.Text = dr[0].ToString();
            }
            con.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Dolar
            if (comboBox1.Text == "USD")
            {
                string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
                var xmlDocument = new XmlDocument();
                xmlDocument.Load(today);

                // Dolar alış ve satış fıyatları çekildi.
                string dolaralis = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/ForexBuying").InnerXml;
                Txt_DovizAlis.Text = dolaralis;

                string dolarsatiş = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/ForexSelling").InnerXml;
                Txt_DovizSatis.Text = dolarsatiş;
            }

            // Euro
            if (comboBox1.Text == "EUR")
            {
                string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
                var xmlDocument = new XmlDocument();
                xmlDocument.Load(today);


                // Euro alış ve satış fıyatları çekildi.
                string euroAliş = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/ForexBuying").InnerXml;
                Txt_DovizAlis.Text = euroAliş;
                string euroSatis = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/ForexSelling").InnerXml;
                Txt_DovizSatis.Text = euroSatis;
                
            }

            // Sterlin
            if (comboBox1.Text == "GBP")
            {
                string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
                var xmlDocument = new XmlDocument();
                xmlDocument.Load(today);


                // Sterlin alış ve satış fıyatları çekildi.
                string gbpAliş = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/ForexBuying").InnerXml;
                Txt_DovizAlis.Text = gbpAliş;
                string gbpSatis = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/ForexSelling").InnerXml;
                Txt_DovizSatis.Text = gbpSatis;
            }

            // Avusturlya Doları
            if (comboBox1.Text == "AUD")
            {
                string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
                var xmlDocument = new XmlDocument();
                xmlDocument.Load(today);


                // Avusturlya Doları alış ve satış fıyatları çekildi.
                string audAliş = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='AUD']/ForexBuying").InnerXml;
                Txt_DovizAlis.Text = audAliş;
                string audSatis = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='AUD']/ForexSelling").InnerXml;
                Txt_DovizSatis.Text = audSatis;
            }









        }

        private void Txt_DovizAlis_TextChanged(object sender, EventArgs e)
        {
            //Txt_DovizAlis.Text = Txt_DovizAlis.Text.Replace(".", ",");
        }

        private void Txt_DovizSatis_TextChanged(object sender, EventArgs e)
        {
            //Txt_DovizSatis.Text = Txt_DovizSatis.Text.Replace(".", ",");
        }

        private void Txt_Miktar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Miktar.Text))
            {
                MessageBox.Show("Lütfen miktar alanını boş geçmeyiniz.", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
            {
                double kurSatis, kurAlis, tutarSatis, tutarAlis, miktar;
                kurSatis = ToDouble(Txt_DovizSatis.Text);
                kurAlis = ToDouble(Txt_DovizAlis.Text);
                miktar = ToDouble(Txt_Miktar.Text);

                tutarSatis = ToDouble(miktar * kurSatis);
                tutarAlis = ToDouble(miktar * kurAlis);


                Txt_TutarAlis.Text = tutarAlis.ToString();
                Txt_TutarSatis.Text = tutarSatis.ToString();
            }

        }

        private void Btn_SatişYap_Click(object sender, EventArgs e)
        {
            if (Txt_İsim.Text == "" || Txt_İsim.Text == " ")
            {
                MessageBox.Show("Lütfen isim alanını boş geçmeyiniz.", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
            {
                con.Open();
                SqlCommand com = new SqlCommand("insert into SatilanDoviz (NAME,DOVIZ_GENUS,AMOUNT,KUR) VALUES(@p1,@p2,@p3,@P4)", con);
                com.Parameters.AddWithValue("@p1", Txt_İsim.Text);
                com.Parameters.AddWithValue("@p2", comboBox1.Text);
                com.Parameters.AddWithValue("@p3", Txt_TutarSatis.Text);
                com.Parameters.AddWithValue("@p4", Txt_DovizSatis.Text);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Satış başarılı bir şekilde yapıldı.", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                this.satilanDovizTableAdapter.Fill(this.dovizOfisDBDataSet6.SatilanDoviz);
                Txt_İsim.Text = "";
                Txt_Miktar.Text = "";
                Txt_TutarAlis.Text = "";
                Txt_TutarSatis.Text = "";
            }
            UsdToplamSatilan(comboBox2.Text);
        }

        private void Btn_AlisYap_Click(object sender, EventArgs e)
        {
            if (Txt_İsim.Text == "" || Txt_İsim.Text == " ")
            {
                MessageBox.Show("Lütfen isim alanını boş geçmeyiniz.", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
            {
                con.Open();
                SqlCommand com2 = new SqlCommand("insert into AlinanDoviz (NAME,DOVIZ_GENUS,AMOUNT,KUR) VALUES(@p1,@p2,@p3,@P4)", con);
                com2.Parameters.AddWithValue("@p1", Txt_İsim.Text);
                com2.Parameters.AddWithValue("@p2", comboBox1.Text);
                com2.Parameters.AddWithValue("@p3", Txt_TutarAlis.Text);
                com2.Parameters.AddWithValue("@p4", Txt_DovizAlis.Text);
                com2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Alış başarılı bir şekilde yapıldı.", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                this.alinanDovizTableAdapter.Fill(this.dovizOfisDBDataSet5.AlinanDoviz);
                Txt_İsim.Text = "";
                Txt_Miktar.Text = "";
                Txt_TutarAlis.Text = "";
                Txt_TutarSatis.Text = "";
            }
            UsdToplamAlinan(comboBox2.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UsdToplamAlinan(comboBox2.Text); 
            UsdToplamSatilan(comboBox2.Text);
        }
    }
}
