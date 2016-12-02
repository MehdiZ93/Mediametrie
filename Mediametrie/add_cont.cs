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
    public partial class add_cont : Form
    {
        home h;
        public add_cont(home h)
        {
            this.h = h;
            InitializeComponent();
        }

        private void btn_reset_val_Click(object sender, EventArgs e)
        {
            btn_reset_cont.Enabled = false;
            btn_val_cont.Enabled = false;
            string text = title_cont.Text;
            var newcontainer = new Container();
            newcontainer.nom = text;
            newcontainer.etat = true;
            using (var con = new Database1Entities())
            {
                var lastId = (from c in con.Containers
                              orderby c.Id descending
                              select c.Id).First();
                newcontainer.Id = lastId + 1;
                con.Containers.Add(newcontainer);
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
