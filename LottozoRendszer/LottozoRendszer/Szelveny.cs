using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottozoRendszer
{
    public partial class Szelveny : Form
    {
        int generalandoSzamokDb = 0;
        byte valaszthatoSzamok = 0;

        public Szelveny(int darabSzam)
        {
            InitializeComponent();
            MaximizeBox = false;
            generalandoSzamokDb = darabSzam;
        }


        private void Szelveny_Load(object sender, EventArgs e)
        {
            nyertesLb.Visible = false;
            nyertesTextLb.Visible = false;
            valasztottLb.Visible = false;
            valasztottTextLb.Visible = false;

            switch (generalandoSzamokDb)
            {
                case 90: // Ötöslottó (90 szám - 5 választható)
                    GombokGeneralasa(generalandoSzamokDb);
                    valaszthatoSzamok = 5;
                    break;
                case 45: // Hatoslottó (45 szám - 6 választható)
                    GombokGeneralasa(generalandoSzamokDb);
                    valaszthatoSzamok = 6;
                    break;
                case 35: // Skandinávlottó (35 szám - 7 választható)
                    GombokGeneralasa(generalandoSzamokDb);
                    valaszthatoSzamok = 7;
                    break;
                default:
                    MessageBox.Show(
                        "Hiba történt a számok generálása közben.",
                        "Hiba",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    break;
            }
        }

        private void GombokGeneralasa(int dbGomb)
        {
            Button gomb;
            int top = panel1.Top + 70;
            int left = panel1.Right + 30;
            int szelesseg = 45;
            int magassag = 40;

            for (int i = 1; i <= dbGomb; i++)
            {
                gomb = new Button();
                gomb.Name = "szamGombok";
                gomb.Top = top;
                gomb.Width = szelesseg;
                gomb.Left = left;
                gomb.Height = magassag;
                gomb.ForeColor = Color.Black;
                gomb.Text = i.ToString();
                gomb.Font = new Font("Cooper Black", 15);
                Controls.Add(gomb);

                if (i % 10 == 0)
                {
                    top += magassag + 5;
                    left = panel1.Right + 30;
                }
                else
                {
                    left += szelesseg + 5;
                }

                gomb.Click += Gomb_Click;
                ujJatekBt.Enabled = false;
            }
        }

        private void Gomb_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if ((sender as Button).ForeColor == Color.Black && JeloltGombokSzama() < valaszthatoSzamok)
                {
                    (sender as Button).ForeColor = Color.Red;
                }
                else if ((sender as Button).ForeColor == Color.Red)
                {
                    (sender as Button).ForeColor = Color.Black;
                }
            }
        }

        private byte JeloltGombokSzama()
        {
            byte jeloltek = 0;
            foreach (Control item in Controls)
            {
                if (item is Button && item.Name == "szamGombok" && item.ForeColor == Color.Red)
                {
                    jeloltek++;
                }
            }
            return jeloltek;
        }

        private void ujJatekBt_Click(object sender, EventArgs e)
        {
            sorsolasBt.Enabled = true;
            ujJatekBt.Enabled = false;

            nyertesTextLb.Visible = true;
            nyertesLb.Text = "";
            nyertesLb.Visible = true;

            valasztottTextLb.Visible = true;
            valasztottLb.Text = "";
            valasztottLb.Visible = true;

            foreach (Control item in Controls)
            {
                if (item is Button && item.Name == "szamGombok")
                {
                    item.Enabled = true;
                    item.ForeColor = Color.Black;
                    item.Click += Gomb_Click;
                }
            }

        }

        private void sorsolasBt_Click(object sender, EventArgs e)
        {  
            nyertesLb.Visible = true;
            nyertesTextLb.Visible = true;
            valasztottLb.Visible = true;
            valasztottTextLb.Visible = true;
            nyertesLb.Text = "";
            valasztottLb.Text = "";


            if (JeloltGombokSzama() == valaszthatoSzamok)
            {
                int[] sorsoltSzamok = new int[valaszthatoSzamok];
                int[] valasztottSzamok = new int[valaszthatoSzamok];

                Random rnd = new Random();
                int i = 0;
                while (i != valaszthatoSzamok)
                {
                    int number = rnd.Next(1, generalandoSzamokDb + 1);
                    if (!sorsoltSzamok.Contains(number))
                    {
                        sorsoltSzamok[i] = number;
                        nyertesLb.Text += (number + " ");
                        i++;
                    }
                }
                int j = 0;
                foreach (Control item in Controls)
                {
                    if (item is Button && item.Name == "szamGombok")
                    {
                        if (item.ForeColor == Color.Red)
                        {
                            valasztottSzamok[j] = int.Parse(item.Text);
                            valasztottLb.Text += (valasztottSzamok[j] + " ");
                            j++;
                        }
                        if (sorsoltSzamok.Contains(int.Parse(item.Text)) && valasztottSzamok.Contains(int.Parse(item.Text)))
                        {
                            item.ForeColor = Color.Green;
                        }
                        else if (!sorsoltSzamok.Contains(int.Parse(item.Text)) && valasztottSzamok.Contains(int.Parse(item.Text)))
                        {
                            item.ForeColor = Color.Blue;
                        }
                        else if(sorsoltSzamok.Contains(int.Parse(item.Text)) && !valasztottSzamok.Contains(int.Parse(item.Text)))
                        {
                            item.ForeColor = Color.Red;
                        }
                        item.Click -= Gomb_Click;
                    }

                }
                sorsolasBt.Enabled = false;
                ujJatekBt.Enabled = true;


                FajlKezelo sorsol = new FajlKezelo(sorsoltSzamok, valasztottSzamok);
                sorsol.FajlbaIras();
            }
            else
            {
                MessageBox.Show("Nem elegendő számot jelölt ki!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Szelveny_FormClosing(object sender, FormClosingEventArgs e)
        {
            SzValasztoForm ujAblak = new SzValasztoForm();

            if (DialogResult.Yes == MessageBox.Show("Bezárja az ablakot?", "Bezárás", MessageBoxButtons.YesNo))
            {
                Hide();
                ujAblak.ShowDialog();
                Dispose();
                Close();
            }
        }
    }
}
