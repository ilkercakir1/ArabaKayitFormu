using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class eklemeformu : Form
    {
        public Ilanlar Ilanlar1;
        private string resimilan;

        public eklemeformu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // tamam buton 
            string grup = "";

            if (kimdencb.SelectedItem == null) grup = "";
            else grup =kimdencb.SelectedItem.ToString();

            Ilanlar1 = new Ilanlar()
            {
                ID = Guid.NewGuid(),
                marka = markatxt.Text,
                seri  = seritxt.Text,
                model = modeltxt.Text,
                yil = yildtp.Text,
                yakit = yakitcb.Text,
                vites = vitescb.Text,
                km = kmnup.Text,
                Renk = renktxt.Text,
                Sehir = sehirtxt.Text,
                Garanti = garanticb.Text,
                Durumu = durumcb.Text,
                Kimden = kimdencb.Text,
                ekbilgi = ekbilgitxt.Text,
                Resim = resimilan,
            };
            IlanlarListe.IlanListesi.Add(Ilanlar1);


            this.DialogResult = DialogResult.OK;

        }
        public void IlanEkle (Ilanlar Ilan)
        {
            markatxt.Text = Ilan.marka;
            seritxt.Text = Ilan.seri;
            modeltxt.Text = Ilan.model;
            yildtp.Text = Ilan.yil;
            yakitcb.Text = Ilan.yakit;
            vitescb.Text = Ilan.vites;
            kmnup.Text = Ilan.km;
            renktxt.Text = Ilan.Renk;
            sehirtxt.Text = Ilan.Sehir;
            garanticb.Text = Ilan.Garanti;
            durumcb.Text = Ilan.Durumu;
            kimdencb.Text = Ilan.Kimden;
            ekbilgitxt.Text = Ilan.Garanti + " " + Ilan.Durumu + " " + Ilan.Kimden + " " + Ilan.Sehir + "" + Ilan.km;
            if (!string.IsNullOrEmpty(resimilan)) pictureBox1.Load(resimilan);
        }

        private void resimeklelbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter =
            "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif" +
            "|PNG Portable Network Graphics (*.png)|*.png" +
            "|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|*.jpg;*.jpeg;*.jfif" +
            "|BMP Windows Bitmap (*.bmp)|*.bmp" +
            "|TIF Tagged Imaged File Format (*.tif *.tiff)|*.tif;*.tiff" +
            "|GIF Graphics Interchange Format (*.gif)|*.gif";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                resimilan = openFileDialog.FileName;
                pictureBox1.Load(resimilan);
            }
        }
         public void ilanguncelle(Ilanlar Ilan)
        {
            markatxt.Text = Ilan.marka;
            seritxt.Text = Ilan.seri;
            modeltxt.Text = Ilan.model;
            yildtp.Text = Ilan.yil;
            yakitcb.Text = Ilan.yakit;
            vitescb.Text = Ilan.vites;
            kmnup.Text = Ilan.km;
            renktxt.Text = Ilan.Renk;
            sehirtxt.Text = Ilan.Sehir;
            garanticb.Text = Ilan.Garanti;
            durumcb.Text = Ilan.Durumu;
            kimdencb.Text = Ilan.Kimden;
            ekbilgitxt.Text = Ilan.Garanti + " " + Ilan.Durumu + " " + Ilan.Kimden + " " + Ilan.Sehir + "" + Ilan.km;
            if (!string.IsNullOrEmpty(resimilan)) pictureBox1.Load(resimilan);

        }

    }
}
