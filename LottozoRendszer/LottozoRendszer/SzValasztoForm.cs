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
    public partial class SzValasztoForm : Form
    {
        public SzValasztoForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void btn_OtosLotto_Click(object sender, EventArgs e)
        {
            Szelveny ujAblak = new Szelveny(90);
            Hide();
            ujAblak.ShowDialog();
            Close();
        }

        private void btn_HatosLotto_Click(object sender, EventArgs e)
        {
            Szelveny ujAblak = new Szelveny(45);
            Hide();
            ujAblak.ShowDialog();
            Close();
        }

        private void btn_SkandinavLotto_Click(object sender, EventArgs e)
        {
            Szelveny ujAblak = new Szelveny(35);
            Hide();
            ujAblak.ShowDialog();
            Close();
        }

        private void SzValasztoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
