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
            //treeView1.AfterCheck += new TreeViewEventHandler(test);
            button1.Click += new EventHandler(test);
        }

        void test(object sender, EventArgs e)
        {
            add_task form2 = new add_task();
            form2.ShowDialog();
        }

        void test1(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(
                "Du texte",
                "Titre",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error);
        }
    }
}
