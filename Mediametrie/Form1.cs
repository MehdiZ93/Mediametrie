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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tacheBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tacheBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.Tache'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tacheTableAdapter.Fill(this.database1DataSet.Tache);

        }
    }
}
