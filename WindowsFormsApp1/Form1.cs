using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        private void Listeguncelleme()
        {

           
            foreach (Ilanlar Ilan in IlanlarListe.IlanListesi)
            {
               IlanEkle(Ilan);
            }
        }

        private void IlanEkle(Ilanlar ilan)
        {
            ListViewItem listViewItem = new ListViewItem(new string[]
 {
                ilan.marka,
                ilan.seri,
                ilan.model,
                ilan.yil,
                ilan.yakit,
                ilan.vites,
                ilan.km,
                ilan.Renk,
                ilan.Sehir,
                ilan.Garanti,
                ilan.Durumu,
                ilan.Kimden
 });
            listViewItem.Tag = ilan;
            textBox1.Text = ilan.ekbilgi;

            listView1.Items.Add(listViewItem);
        }

        private void JsonKaydetme()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosya = saveFileDialog1.FileName;

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(IlanlarListe.IlanListesi);
                File.WriteAllText(dosya, json);
            }   

        }
        private void Jsonacma()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosya = openFileDialog1.FileName;

                string json = File.ReadAllText(dosya);
                IlanlarListe.IlanListesi = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Ilanlar>>(json);

                Listeguncelleme();
            }
        }
        private void xmlkaydedici()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosya = saveFileDialog1.FileName;

                XmlSerializer xml = new XmlSerializer(typeof(List<Ilanlar>));
                StreamWriter sw = new StreamWriter(dosya);
                xml.Serialize(sw, IlanlarListe.IlanListesi);

                sw.Flush();
                sw.Close();
                sw.Dispose();
            }

        }
        private void xmlacici()
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosya = openFileDialog1.FileName;

                XmlSerializer xml = new XmlSerializer(typeof(List<Ilanlar>));
                StreamReader sr = new StreamReader(dosya);
                IlanlarListe.IlanListesi = (List<Ilanlar>)xml.Deserialize(sr);

                sr.Close();
                sr.Dispose();

                Listeguncelleme();
            }
        }
       private void csvkaydedici()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosya = saveFileDialog1.FileName;

                StreamWriter sw = new StreamWriter(dosya);
                CsvHelper.CsvWriter csv = new CsvHelper.CsvWriter(sw, System.Globalization.CultureInfo.CurrentCulture);
                csv.WriteRecords(IlanlarListe.IlanListesi);

                sw.Flush();
                sw.Close();
                sw.Dispose();
            }
        }
        private void csvacici()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosya = openFileDialog1.FileName;

                StreamReader sr = new StreamReader(dosya);
                CsvHelper.CsvReader csv = new CsvHelper.CsvReader(sr, System.Globalization.CultureInfo.CurrentCulture);
                IlanlarListe.IlanListesi = csv.GetRecords<Ilanlar>().ToList();

                sr.Close();
                sr.Dispose();

                Listeguncelleme();

            }

        }

        private void csvKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            csvkaydedici();
        }

        private void csvAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            csvacici();
        }

        private void jsonKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JsonKaydetme();
        }

        private void jsonAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jsonacma();   
        }

        private void xmlKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xmlkaydedici();
        }

        private void xmlAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xmlacici();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // araba ekle 

            eklemeformu eklemeformu = new eklemeformu();

            if (eklemeformu.ShowDialog() == DialogResult.OK)
            {
                Listeguncelleme();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // araba düzenle 

            if (listView1.SelectedItems.Count == 0)
                return;
            Ilanlar ilanlar = listView1.SelectedItems[0].Tag as Ilanlar;
            eklemeformu eklemeformu = new eklemeformu() { Text = "Araba Düzenle" };
            eklemeformu.ilanguncelle(ilanlar);
            if (eklemeformu.ShowDialog() == DialogResult.OK)
            {
                var index = IlanlarListe.IlanListesi.FindIndex(x => x.ID == ilanlar.ID);
                IlanlarListe.IlanListesi.RemoveAt(index);
                IlanlarListe.IlanListesi.Insert(index, eklemeformu.Ilanlar1);
            }
            Listeguncelleme();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // araba sil 
            if (listView1.SelectedItems.Count == 0)
                return;

            if (MessageBox.Show(
               "Silinsin mi",
               "Silmeyi onayla",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) != DialogResult.OK)
                return;

            var ilan = listView1.SelectedItems[0].Tag as Ilanlar;
            Ilanlar silinecekIlan = IlanlarListe.IlanListesi.Find(x => x.ID == ilan.ID);
            IlanlarListe.IlanListesi.Remove(silinecekIlan);
            Listeguncelleme();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ilan = listView1.SelectedItems[0].Tag as Ilanlar;
            pictureBox1.Load(ilan.Resim);
        }
    }



    }




    









