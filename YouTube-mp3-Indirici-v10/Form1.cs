using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; //TR// input-output kullanacağımız için //EN// for use Input-Output
using VideoLibrary; //TR// Video indirme işlemi
using MediaToolkit; //TR// Mp4'ü MP3 formatına çevirmek.
using System.Net; //TR// Internet Kullanacagımız için //EN// for use Net



namespace YouTube_mp3_Indirici_v10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool FormatDurum = true;

        //True ise -> MP3 false ise ->MP4 indir.

     

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            FormatDurum = false;
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() {   Description="Lütfen Kaydetmek istediğiniz klasörü seçin." })
            {

                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    labelVideoAd.Visible = true;

                    GetVideoTitle();
                    labelStatus.Text = "İndirme işlemi başladı. Lütfen bekleyiniz...";
                    labelStatus.ForeColor = Color.Red;
                    var yt = YouTube.Default;
                    var video = await yt.GetVideoAsync(textBox1.Text);
                    File.WriteAllBytes(fdb.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());



                    var inputFile = new MediaToolkit.Model.MediaFile { Filename = fdb.SelectedPath + @"\" + video.FullName };

                    var outputFile = new MediaToolkit.Model.MediaFile { Filename = $"{fdb.SelectedPath + @"\" + video.FullName}.mp3" };

                    using (var enging = new Engine())
                    {
                        enging.GetMetadata(inputFile);
                        enging.Convert(inputFile, outputFile);
                    }

                    if(FormatDurum == true)
                    {

                        File.Delete(fdb.SelectedPath + @"\" + video.FullName);
                    }
                    else
                    {
                        File.Delete($"{fdb.SelectedPath + @"\" + video.FullName}.mp3");
                    }

                    labelStatus.Text = "İndirme işlemi başarıyla tamamlandı.";
                    labelStatus.ForeColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir dosya yolu seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        void GetVideoTitle()
        {

            if(textBox1.Text =="")
            {
                MessageBox.Show("Video Linki Boş Bırakılamaz", "Uyarı");
            }
            else { 
            WebRequest istek = HttpWebRequest.Create(textBox1.Text);
            WebResponse yanit;
            yanit = istek.GetResponse();
            StreamReader bilgiler = new StreamReader(yanit.GetResponseStream());
            string gelen = bilgiler.ReadToEnd();
            int baslangic = gelen.IndexOf("<title>")  +  7;
            int bitis = gelen.Substring(baslangic).IndexOf("</title>");
            string gelenBilgiler = gelen.Substring(baslangic, bitis);
            labelVideoName.Text = (gelenBilgiler);
            }



        }

        private void labelHeader_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonMP3_CheckedChanged(object sender, EventArgs e)
        {
            FormatDurum = true;
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void buttonYapistir_Click(object sender, EventArgs e)
        {
          
            GetVideoTitle();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Uygulama MbK tarafından tasarlanmıştır.", "Hakkında");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                this.Close();
            }
            else if (secenek == DialogResult.No)
            {
                
            }

           
        }
    }
}
