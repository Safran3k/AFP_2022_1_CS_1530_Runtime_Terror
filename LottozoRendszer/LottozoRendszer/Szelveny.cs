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

        public Szelveny(int darabSzam)
        {
            InitializeComponent();
            generalandoSzamokDb = darabSzam;
        }


        private void Szelveny_Load(object sender, EventArgs e)
        {
            switch (generalandoSzamokDb)
            {
                case 90: // Ötöslottó (90 szám - 5 választható)
                    GombokGeneralasa(generalandoSzamokDb);
                    break;
                case 45: // Hatoslottó (45 szám - 6 választható)
                    GombokGeneralasa(generalandoSzamokDb);
                    break;
                case 35: // Skandinávlottó (35 szám - 7 választható)
                    GombokGeneralasa(generalandoSzamokDb);
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
            int top = flowLayoutPanel1.Top + 70;
            int left = flowLayoutPanel1.Right + 30;
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
                    left = flowLayoutPanel1.Right + 30;
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
            //Számgombok click eseményének helye
        }

        private void ujJatekBt_Click(object sender, EventArgs e)
        {

        }
    }
}
