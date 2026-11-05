using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        private Color[] renkler = new Color[]
        {
            Color.Red, Color.Red,
            Color.Blue, Color.Blue,
            Color.Green, Color.Green,
            Color.Yellow, Color.Yellow
        };

        private Panel[] kartlar;
        private Color[] kartRengleri = new Color[8];
        private bool[] acildiMi = new bool[8];

        private int birinciSecim = -1;
        private int ikinciSecim = -1;
        private int xal = 0;
        private int acilanKartSayisi = 0;
        private bool yoxlanilir = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kartlar = new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8 };

            for (int i = 0; i < kartlar.Length; i++)
            {
                kartlar[i].Tag = i;
                kartlar[i].Click += Kart_Click;
            }

            pictureBoxTrue.Visible = false;
            pictureBoxFalse.Visible = false;
            labelXalSay.Text = "0";

            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            Random rnd = new Random();
            Color[] qarisikRenkler = renkler.OrderBy(x => rnd.Next()).ToArray();
            Array.Copy(qarisikRenkler, kartRengleri, qarisikRenkler.Length);

            xal = 0;
            acilanKartSayisi = 0;
            labelXalSay.Text = xal.ToString();
            birinciSecim = -1;
            ikinciSecim = -1;
            pictureBoxTrue.Visible = false;
            pictureBoxFalse.Visible = false;

            for (int i = 0; i < kartlar.Length; i++)
            {
                acildiMi[i] = false;
                kartlar[i].BackColor = Color.White;
                kartlar[i].Enabled = true;
            }
        }

        private void Kart_Click(object sender, EventArgs e)
        {
            if (yoxlanilir) return;

            Panel secilenPanel = (Panel)sender;
            int indeks = (int)secilenPanel.Tag;

            if (acildiMi[indeks]) return;

            acildiMi[indeks] = true;
            secilenPanel.BackColor = kartRengleri[indeks];

            if (birinciSecim == -1)
            {
                birinciSecim = indeks;
            }
            else
            {
                ikinciSecim = indeks;
                yoxlanilir = true;

                Timer timerYoxla = new Timer();
                timerYoxla.Interval = 700;
                timerYoxla.Tick += (s, args) =>
                {
                    timerYoxla.Stop();
                    timerYoxla.Dispose();

                    if (kartRengleri[birinciSecim] == kartRengleri[ikinciSecim])
                    {
                        xal += 1;
                        labelXalSay.Text = xal.ToString();
                        pictureBoxTrue.Visible = true;
                        pictureBoxFalse.Visible = false;

                        acilanKartSayisi += 2;
                    }
                    else
                    {
                        pictureBoxFalse.Visible = true;
                        pictureBoxTrue.Visible = false;

                        kartlar[birinciSecim].BackColor = Color.White;
                        kartlar[ikinciSecim].BackColor = Color.White;
                        acildiMi[birinciSecim] = false;
                        acildiMi[ikinciSecim] = false;
                    }

                    birinciSecim = -1;
                    ikinciSecim = -1;
                    yoxlanilir = false;

                    if (acilanKartSayisi == 8)
                    {
                        MessageBox.Show("Təbriklər, bütün qutular açıldı və oyun bitdi!", "Oyun Bitdi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                timerYoxla.Start();
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void btnCix_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}