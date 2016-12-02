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
        home h;
        int index;
        public add_task(home h, int index)
        {
            this.h = h;
            this.index = index;
            InitializeComponent();
        }

        private void btn_val_Click(object sender, EventArgs e)
        {
            btn_val.Enabled = false;
            button2.Enabled = false;
            string descript = description.Text;
            string titre = title.Text;
            DateTime date_fin = end_date.Value;
            byte prio = 0;
            if (radio_prio1.Checked)
                prio = 1;
            else if (radio_prio2.Checked)
                prio = 2;
            else if (radio_prio3.Checked)
                prio = 3;
            else if (radio_prio4.Checked)
                prio = 4;
            else if (radio_prio5.Checked)
                prio = 5;
            var nouvelletache = new Tache();
            nouvelletache.nom = titre;
            nouvelletache.description = descript;
            nouvelletache.date_creation = DateTime.Now;
            nouvelletache.date_fin = date_fin;
            nouvelletache.etat = false;
            nouvelletache.id_container = h.getContId(index);
            nouvelletache.priorite = prio;
            using (var entities = new Database1Entities())
            {
                var lastId = (from c in entities.Taches
                              orderby c.Id descending
                              select c.Id).First();
                nouvelletache.Id = lastId + 1;
                entities.Taches.Add(nouvelletache);
                entities.SaveChanges();
            }
            h.home_tasks_reload();
            this.Close();
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
