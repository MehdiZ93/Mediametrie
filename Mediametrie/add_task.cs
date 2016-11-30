using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediametrie
{
    public partial class add_task : Form
    {
        public add_task()
        {
            InitializeComponent();
        }

        private void btn_val_Click(object sender, EventArgs e)
        {
            string descript = description.Text;
            string titre = title.Text;
            DateTime date_fin = end_date.Value;
            int prio = 0;
            if (radio_prio1.Checked)
                prio = Int32.Parse(radio_prio1.Text);
            else if (radio_prio2.Checked)
                prio = Int32.Parse(radio_prio2.Text);
            else if (radio_prio3.Checked)
                prio = Int32.Parse(radio_prio3.Text);
            else if (radio_prio4.Checked)
                prio = Int32.Parse(radio_prio4.Text);
            else if (radio_prio5.Checked)
                prio = Int32.Parse(radio_prio5.Text);
            MessageBox.Show(date_fin.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            description.Text = "";
            title.Text = "";
            end_date.Value = DateTime.Now;
            radio_prio1.Checked = true;
            radio_prio2.Checked = false;
            radio_prio3.Checked = false;
            radio_prio4.Checked = false;
            radio_prio5.Checked = false;
        }
    }
}
