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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void list_cont_Click(object sender, EventArgs e)
        {
            var curr_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            aff_taches.Items.Clear();
            if (list_cont.SelectedIndex > 2)
            {
                int i = 0;
                int id = 0;
                btn_add_task.Enabled = true;
                btn_modify_cont.Enabled = true;
                btn_del_cont.Enabled = true;
                using (var entities = new Database1Entities())
                {
                    var listCont = from cont in entities.Containers
                                   select cont;
                    foreach (var match in listCont)
                    {
                        if (i == list_cont.SelectedIndex)
                            id = match.Id;
                        i++;
                    }
                    var liste_tache = from c in entities.Taches
                                      where c.id_container == id
                                      select c;
                    foreach (var item in liste_tache)
                    {
                        aff_taches.Items.Add(item.nom);
                    }
                }
                head_tasks_rem.Text = list_cont.SelectedItem.ToString();
                int size_list = aff_taches.Items.Count;
                int nbr_checked_list = aff_taches.CheckedItems.Count;
                nb_elem.Text = nbr_checked_list + " / " + size_list;
            }
            else if (list_cont.SelectedIndex == 0)
            {
                btn_add_task.Enabled = false;
                btn_modify_cont.Enabled = false;
                btn_del_cont.Enabled = false;
                using (var entities = new Database1Entities())
                {
                    var liste_tache = from c in entities.Taches
                                      where c.priorite > 3
                                      select c;
                    foreach (var item in liste_tache)
                    {
                        aff_taches.Items.Add(item.nom);
                    }
                }
                head_tasks_rem.Text = list_cont.SelectedItem.ToString();
                int size_list = aff_taches.Items.Count;
                int nbr_checked_list = aff_taches.CheckedItems.Count;
                nb_elem.Text = nbr_checked_list + " / " + size_list;
            }
            else if (list_cont.SelectedIndex == 1)
            {
                btn_add_task.Enabled = false;
                btn_modify_cont.Enabled = false;
                btn_del_cont.Enabled = false;
                using (var entities = new Database1Entities())
                {
                    var liste_tache = from c in entities.Taches
                                      where c.etat == false
                                      select c;
                    foreach (var item in liste_tache)
                    {
                        aff_taches.Items.Add(item.nom);
                    }
                }
                head_tasks_rem.Text = list_cont.SelectedItem.ToString();
                int size_list = aff_taches.Items.Count;
                int nbr_checked_list = aff_taches.CheckedItems.Count;
                nb_elem.Text = nbr_checked_list + " / " + size_list;
            }
            else if (list_cont.SelectedIndex == 2)
            {
                btn_add_task.Enabled = false;
                btn_modify_cont.Enabled = false;
                btn_del_cont.Enabled = false;
                using (var entities = new Database1Entities())
                {
                    var liste_tache = from c in entities.Taches
                                      where c.date_fin == curr_date
                                      select c;
                    foreach (var item in liste_tache)
                    {
                        aff_taches.Items.Add(item.nom);
                    }
                }
                head_tasks_rem.Text = list_cont.SelectedItem.ToString();
                int size_list = aff_taches.Items.Count;
                int nbr_checked_list = aff_taches.CheckedItems.Count;
                nb_elem.Text = nbr_checked_list + " / " + size_list;
            }
    }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            var curr_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if (aff_taches.SelectedIndex != -1)
            {
                if (list_cont.SelectedIndex > 2)
                {
                    int id = 0;
                    int i = 0;
                    int j = 0;
                    btn_modify_task.Enabled = true;
                    btn_del_task.Enabled = true;
                    using (var entities = new Database1Entities())
                    {
                        var listCont = from cont in entities.Containers
                                       select cont;
                        foreach (var match in listCont)
                        {
                            if (i == list_cont.SelectedIndex)
                                id = match.Id;
                            i++;
                        }
                        var listTask = from c in entities.Taches
                                       where c.id_container == id
                                       select c;
                        foreach (var selected in listTask)
                        {
                            if (j == aff_taches.SelectedIndex)
                                description.Text = selected.description;
                            j++;
                        }
                    }
                }
                else if (list_cont.SelectedIndex == 0)
                {
                    int j = 0;
                    btn_modify_task.Enabled = true;
                    btn_del_task.Enabled = true;
                    using (var entities = new Database1Entities())
                    {
                        var listTask = from c in entities.Taches
                                       where c.priorite > 3
                                       select c;
                        foreach (var selected in listTask)
                        {
                            if (j == aff_taches.SelectedIndex)
                                description.Text = selected.description;
                            j++;
                        }
                    }
                }
                else if (list_cont.SelectedIndex == 1)
                {
                    int j = 0;
                    btn_modify_task.Enabled = true;
                    btn_del_task.Enabled = true;
                    using (var entities = new Database1Entities())
                    {
                        var listTask = from c in entities.Taches
                                       where c.etat == false
                                       select c;
                        foreach (var selected in listTask)
                        {
                            if (j == aff_taches.SelectedIndex)
                                description.Text = selected.description;
                            j++;
                        }
                    }
                }
                else if (list_cont.SelectedIndex == 2)
                {
                    int j = 0;
                    btn_modify_task.Enabled = true;
                    btn_del_task.Enabled = true;
                    using (var entities = new Database1Entities())
                    {
                        var listTask = from c in entities.Taches
                                       where c.date_fin == curr_date
                                       select c;
                        foreach (var selected in listTask)
                        {
                            if (j == aff_taches.SelectedIndex)
                                description.Text = selected.description;
                            j++;
                        }
                    }
                }
            }
        }

        private void btn_add_task_Click(object sender, EventArgs e)
        {
            add_task form2 = new add_task(this);
            form2.ShowDialog();
        }

        private void btn_del_task_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Voulez-vous vraiment supprimer : \"" + aff_taches.SelectedValue.ToString() + "\" ?",
                "Suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                aff_taches.Items.Remove(aff_taches.SelectedItem);
                btn_modify_task.Enabled = false;
                btn_del_task.Enabled = false;
                int size_list = aff_taches.Items.Count;
                int nbr_checked_list = aff_taches.CheckedItems.Count;
                nb_elem.Text = nbr_checked_list + " / " + size_list;
            }
        }

        private void btn_del_cont_Click(object sender, EventArgs e)
        {
            int i = 0;
            DialogResult dialogResult = MessageBox.Show(
                "Voulez-vous vraiment supprimer : \"" + list_cont.SelectedItem.ToString() + "\" ?",
                "Suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                using (var entities = new Database1Entities())
                {
                    var listCont = from c in entities.Containers
                                   select c;
                    foreach(var item in listCont)
                    {
                        if (i == list_cont.SelectedIndex)
                            entities.Containers.Remove(item);
                        i++;
                    }
                    entities.SaveChanges();
                }
                home_reload();
                head_tasks_rem.Text = "";
                nb_elem.Text = "";
                btn_modify_cont.Enabled = false;
                btn_del_cont.Enabled = false;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (aff_taches.GetItemCheckState(aff_taches.SelectedIndex) == CheckState.Checked)
            {
                int size_list = aff_taches.Items.Count;
                int nbr_checked_list = aff_taches.CheckedItems.Count;
                nb_elem.Text = nbr_checked_list - 1 + " / " + size_list;
            }
            else
            {
                int size_list = aff_taches.Items.Count;
                int nbr_checked_list = aff_taches.CheckedItems.Count;
                nb_elem.Text = nbr_checked_list + 1 + " / " + size_list;
            }
        }

        private void home_Load(object sender, EventArgs e)
        {
            using (var entities = new Database1Entities())
            {
                foreach(var names in entities.Containers)
                {
                    list_cont.Items.Add(names.nom);
                }
            }
        }

        public void home_reload()
        {
            list_cont.Items.Clear();
            using (var entities = new Database1Entities())
            {
                foreach (var names in entities.Containers)
                {
                    list_cont.Items.Add(names.nom);
                }
            }
            aff_taches.Items.Clear();
            head_tasks_rem.Text = "";
            nb_elem.Text = "";
        }

        private void btn_add_cont_Click(object sender, EventArgs e)
        {
            add_cont form = new add_cont(this);
            form.ShowDialog();
        }

        private void btn_modify_cont_Click(object sender, EventArgs e)
        {
            btn_modify_cont.Enabled = false;
            btn_del_cont.Enabled = false;
            modify_cont form = new modify_cont(this, list_cont.SelectedItem.ToString(), list_cont.SelectedIndex);
            form.ShowDialog();
        }
    }
}