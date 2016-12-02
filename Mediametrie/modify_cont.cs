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
    public partial class modify_cont : Form
    {
        home h;
        int index;
        public modify_cont(home h, string text, int index)
        {
            this.h = h;
            this.index = index;
            InitializeComponent();
            title_cont.Text = text;
        }

        private void btn_val_cont_Click(object sender, EventArgs e)
        {
            int i = 0;
            btn_reset_cont.Enabled = false;
            btn_val_cont.Enabled = false;
            string text = title_cont.Text;
            using (var con = new Database1Entities())
            {
                var listCont = from c in con.Containers
                               select c;
                foreach(var cont in listCont)
                {
                    if (i == this.index)
                        cont.nom = text;
                    i++;
                }
                con.SaveChanges();
            }
            h.home_reload();
            this.Close();
        }

        private void btn_reset_cont_Click(object sender, EventArgs e)
        {
            title_cont.Text = "";
        }
    }
}
