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
        }

        private void btn_OtosLotto_Click(object sender, EventArgs e)
        {
            Szelveny ujAblak = new Szelveny(90);
            ujAblak.Show();
            Hide();
        }

        private void btn_HatosLotto_Click(object sender, EventArgs e)
        {
            Szelveny ujAblak = new Szelveny(45);
            ujAblak.Show();
            Hide();
        }

        private void btn_SkandinavLotto_Click(object sender, EventArgs e)
        {
            Szelveny ujAblak = new Szelveny(35);
            ujAblak.Show();
            Hide();
        }
    }
}
