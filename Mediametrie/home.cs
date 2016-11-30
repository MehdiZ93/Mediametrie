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

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                btn_modify_cont.Enabled = true;
                btn_del_cont.Enabled = true;
                head_tasks_rem.Text = listBox1.SelectedItem.ToString();
                int size_list = checkedListBox1.Items.Count;
                int nbr_checked_list = checkedListBox1.CheckedItems.Count;
                nb_elem.Text = nbr_checked_list + " / " + size_list;
            }
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex != -1)
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
                "Voulez-vous vraiment supprimer : \"" + checkedListBox1.SelectedItem.ToString() + "\" ?",
                "Suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
                btn_modify_task.Enabled = false;
                btn_del_task.Enabled = false;
                int size_list = checkedListBox1.Items.Count;
                int nbr_checked_list = checkedListBox1.CheckedItems.Count;
                nb_elem.Text = nbr_checked_list + " / " + size_list;
            }
        }

        private void btn_del_cont_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Voulez-vous vraiment supprimer : \"" + listBox1.SelectedItem.ToString() + "\" ?",
                "Suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                btn_modify_cont.Enabled = false;
                btn_del_cont.Enabled = false;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.GetItemCheckState(checkedListBox1.SelectedIndex) == CheckState.Checked)
            {
                int size_list = checkedListBox1.Items.Count;
                int nbr_checked_list = checkedListBox1.CheckedItems.Count;
                nb_elem.Text = nbr_checked_list - 1 + " / " + size_list;
            }
            else
            {
                int size_list = checkedListBox1.Items.Count;
                int nbr_checked_list = checkedListBox1.CheckedItems.Count;
                nb_elem.Text = nbr_checked_list + 1 + " / " + size_list;
            }
        }
    }
}