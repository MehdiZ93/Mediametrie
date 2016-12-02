﻿using System;
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
            /*if (list_cont.SelectedIndex != -1)
            {
                btn_modify_cont.Enabled = true;
                btn_del_cont.Enabled = true;
                head_tasks_rem.Text = list_cont.SelectedValue.ToString();
                int size_list = aff_taches.Items.Count;
                int nbr_checked_list = aff_taches.CheckedItems.Count;
                nb_elem.Text = nbr_checked_list + " / " + size_list;
            }*/
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            if (aff_taches.SelectedIndex != -1)
            {
                btn_modify_task.Enabled = true;
                btn_del_task.Enabled = true;
            }
        }

        private void btn_add_task_Click(object sender, EventArgs e)
        {
            add_task form2 = new add_task();
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
            DialogResult dialogResult = MessageBox.Show(
                "Voulez-vous vraiment supprimer : \"" + list_cont.SelectedValue.ToString() + "\" ?",
                "Suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                list_cont.Items.Remove(list_cont.SelectedItem);
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

        private void btn_add_cont_Click(object sender, EventArgs e)
        {
            add_cont form = new add_cont();
            form.ShowDialog();
        }
    }
}