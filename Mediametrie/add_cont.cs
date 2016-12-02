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

        public add_cont()
        {
            InitializeComponent();
        }

        private void btn_reset_val_Click(object sender, EventArgs e)
        {
            string text = title_cont.Text;
            var newcontainer = new Container();
            newcontainer.nom = text;
            newcontainer.Id = 4;
            newcontainer.etat = true;
            using (var con = new Database1Entities())
            {
                con.Containers.Add(newcontainer);
                con.SaveChanges();
            }
            this.Close();
        }

        private void btn_reset_cont_Click(object sender, EventArgs e)
        {
            title_cont.Text = "";
        }
    }
}
