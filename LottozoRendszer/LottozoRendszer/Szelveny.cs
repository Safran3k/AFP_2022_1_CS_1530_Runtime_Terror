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
        public Szelveny()
        {
            InitializeComponent();
        }

        private void Szelveny_Load(object sender, EventArgs e)
        {
            Button gomb;
            int top = flowLayoutPanel1.Top + 70;
            int left = flowLayoutPanel1.Right + 30;
            int szelesseg = 45;
            int magassag = 40;

            for (int i = 1; i <= 90; i++)
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
            }
        }
    }
}
