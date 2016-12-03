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
    public partial class modify_task : Form
    {
        home h;
        Tache task;
        public modify_task(home h, Tache task)
        {
            this.h = h;
            this.task = task;
            InitializeComponent();
            title.Text = task.nom;
            description.Text = task.description;
            end_date.Text = task.date_fin.ToString();
            if (task.priorite == 2)
                radio_prio2.Checked = true;
            else if (task.priorite == 3)
                radio_prio3.Checked = true;
            else if (task.priorite == 4)
                radio_prio4.Checked = true;
            else if (task.priorite == 5)
                radio_prio5.Checked = true;
        }

        private void btn_val_Click(object sender, EventArgs e)
        {
            using (var entities = new Database1Entities())
            {
                var taskmodified = (from c in entities.Taches
                                   where c.Id == task.Id
                                   select c).First();
                taskmodified.nom = title.Text;
                taskmodified.description = description.Text;
                taskmodified.date_fin = end_date.Value;
                if (radio_prio1.Checked)
                    taskmodified.priorite = 1;
                else if (radio_prio2.Checked)
                    taskmodified.priorite = 2;
                else if (radio_prio3.Checked)
                    taskmodified.priorite = 3;
                else if (radio_prio4.Checked)
                    taskmodified.priorite = 4;
                else if (radio_prio5.Checked)
                    taskmodified.priorite = 5;
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
