namespace Mediametrie
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.head_tasks_rem = new System.Windows.Forms.TextBox();
            this.nb_elem = new System.Windows.Forms.TextBox();
            this.containerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Mediametrie.Database1DataSet();
            this.containerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.description = new System.Windows.Forms.TextBox();
            this.aff_taches = new System.Windows.Forms.CheckedListBox();
            this.btn_add_task = new System.Windows.Forms.Button();
            this.btn_modify_task = new System.Windows.Forms.Button();
            this.btn_del_task = new System.Windows.Forms.Button();
            this.btn_del_cont = new System.Windows.Forms.Button();
            this.btn_modify_cont = new System.Windows.Forms.Button();
            this.btn_add_cont = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.containerTableAdapter = new Mediametrie.Database1DataSetTableAdapters.ContainerTableAdapter();
            this.tableAdapterManager = new Mediametrie.Database1DataSetTableAdapters.TableAdapterManager();
            this.containerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.list_cont = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // head_tasks_rem
            // 
            this.head_tasks_rem.BackColor = System.Drawing.SystemColors.Window;
            this.head_tasks_rem.Enabled = false;
            this.head_tasks_rem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head_tasks_rem.ForeColor = System.Drawing.Color.Black;
            this.head_tasks_rem.Location = new System.Drawing.Point(224, 23);
            this.head_tasks_rem.Name = "head_tasks_rem";
            this.head_tasks_rem.ReadOnly = true;
            this.head_tasks_rem.Size = new System.Drawing.Size(535, 53);
            this.head_tasks_rem.TabIndex = 1;
            // 
            // nb_elem
            // 
            this.nb_elem.BackColor = System.Drawing.SystemColors.Window;
            this.nb_elem.Enabled = false;
            this.nb_elem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb_elem.Location = new System.Drawing.Point(765, 23);
            this.nb_elem.Name = "nb_elem";
            this.nb_elem.ReadOnly = true;
            this.nb_elem.Size = new System.Drawing.Size(101, 53);
            this.nb_elem.TabIndex = 4;
            // 
            // containerBindingSource1
            // 
            this.containerBindingSource1.DataMember = "Container";
            this.containerBindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // containerBindingSource
            // 
            this.containerBindingSource.DataMember = "Container";
            this.containerBindingSource.DataSource = this.database1DataSet;
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.description.Enabled = false;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(224, 417);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(642, 163);
            this.description.TabIndex = 6;
            // 
            // aff_taches
            // 
            this.aff_taches.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aff_taches.FormattingEnabled = true;
            this.aff_taches.Location = new System.Drawing.Point(224, 82);
            this.aff_taches.Name = "aff_taches";
            this.aff_taches.Size = new System.Drawing.Size(642, 329);
            this.aff_taches.TabIndex = 7;
            this.aff_taches.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.aff_taches.Click += new System.EventHandler(this.checkedListBox1_Click);
            // 
            // btn_add_task
            // 
            this.btn_add_task.Enabled = false;
            this.btn_add_task.Location = new System.Drawing.Point(292, 587);
            this.btn_add_task.Name = "btn_add_task";
            this.btn_add_task.Size = new System.Drawing.Size(166, 36);
            this.btn_add_task.TabIndex = 8;
            this.btn_add_task.Text = "Ajouter une tâche";
            this.btn_add_task.UseVisualStyleBackColor = true;
            this.btn_add_task.Click += new System.EventHandler(this.btn_add_task_Click);
            // 
            // btn_modify_task
            // 
            this.btn_modify_task.Enabled = false;
            this.btn_modify_task.Location = new System.Drawing.Point(464, 587);
            this.btn_modify_task.Name = "btn_modify_task";
            this.btn_modify_task.Size = new System.Drawing.Size(166, 36);
            this.btn_modify_task.TabIndex = 9;
            this.btn_modify_task.Text = "Modifier tâche";
            this.btn_modify_task.UseVisualStyleBackColor = true;
            this.btn_modify_task.Click += new System.EventHandler(this.btn_modify_task_Click);
            // 
            // btn_del_task
            // 
            this.btn_del_task.Enabled = false;
            this.btn_del_task.Location = new System.Drawing.Point(636, 587);
            this.btn_del_task.Name = "btn_del_task";
            this.btn_del_task.Size = new System.Drawing.Size(166, 36);
            this.btn_del_task.TabIndex = 10;
            this.btn_del_task.Text = "Supprimer tâche";
            this.btn_del_task.UseVisualStyleBackColor = true;
            this.btn_del_task.Click += new System.EventHandler(this.btn_del_task_Click);
            // 
            // btn_del_cont
            // 
            this.btn_del_cont.Enabled = false;
            this.btn_del_cont.Location = new System.Drawing.Point(22, 586);
            this.btn_del_cont.Name = "btn_del_cont";
            this.btn_del_cont.Size = new System.Drawing.Size(185, 36);
            this.btn_del_cont.TabIndex = 11;
            this.btn_del_cont.Text = "Supprimer container";
            this.btn_del_cont.UseVisualStyleBackColor = true;
            this.btn_del_cont.Click += new System.EventHandler(this.btn_del_cont_Click);
            // 
            // btn_modify_cont
            // 
            this.btn_modify_cont.Enabled = false;
            this.btn_modify_cont.Location = new System.Drawing.Point(22, 544);
            this.btn_modify_cont.Name = "btn_modify_cont";
            this.btn_modify_cont.Size = new System.Drawing.Size(185, 36);
            this.btn_modify_cont.TabIndex = 12;
            this.btn_modify_cont.Text = "Modifier container";
            this.btn_modify_cont.UseVisualStyleBackColor = true;
            this.btn_modify_cont.Click += new System.EventHandler(this.btn_modify_cont_Click);
            // 
            // btn_add_cont
            // 
            this.btn_add_cont.Location = new System.Drawing.Point(22, 502);
            this.btn_add_cont.Name = "btn_add_cont";
            this.btn_add_cont.Size = new System.Drawing.Size(185, 36);
            this.btn_add_cont.TabIndex = 13;
            this.btn_add_cont.Text = "Ajouter un container";
            this.btn_add_cont.UseVisualStyleBackColor = true;
            this.btn_add_cont.Click += new System.EventHandler(this.btn_add_cont_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(12, 422);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(206, 210);
            this.textBox3.TabIndex = 14;
            // 
            // containerTableAdapter
            // 
            this.containerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContainerTableAdapter = this.containerTableAdapter;
            this.tableAdapterManager.TacheTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Mediametrie.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // containerBindingSource2
            // 
            this.containerBindingSource2.DataMember = "Container";
            this.containerBindingSource2.DataSource = this.database1DataSet;
            // 
            // list_cont
            // 
            this.list_cont.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.list_cont.FormattingEnabled = true;
            this.list_cont.ItemHeight = 29;
            this.list_cont.Location = new System.Drawing.Point(12, 23);
            this.list_cont.Name = "list_cont";
            this.list_cont.Size = new System.Drawing.Size(206, 406);
            this.list_cont.TabIndex = 15;
            this.list_cont.Click += new System.EventHandler(this.list_cont_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.list_cont);
            this.Controls.Add(this.btn_add_cont);
            this.Controls.Add(this.btn_modify_cont);
            this.Controls.Add(this.btn_del_cont);
            this.Controls.Add(this.btn_del_task);
            this.Controls.Add(this.btn_modify_task);
            this.Controls.Add(this.btn_add_task);
            this.Controls.Add(this.aff_taches);
            this.Controls.Add(this.head_tasks_rem);
            this.Controls.Add(this.nb_elem);
            this.Controls.Add(this.description);
            this.Controls.Add(this.textBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "home";
            this.Text = "Gestionnaire de tâches";
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox head_tasks_rem;
        private System.Windows.Forms.TextBox nb_elem;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.CheckedListBox aff_taches;
        private System.Windows.Forms.Button btn_add_task;
        private System.Windows.Forms.Button btn_modify_task;
        private System.Windows.Forms.Button btn_del_task;
        private System.Windows.Forms.Button btn_del_cont;
        private System.Windows.Forms.Button btn_modify_cont;
        private System.Windows.Forms.Button btn_add_cont;
        private System.Windows.Forms.TextBox textBox3;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource containerBindingSource;
        private Database1DataSetTableAdapters.ContainerTableAdapter containerTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource containerBindingSource1;
        private System.Windows.Forms.BindingSource containerBindingSource2;
        private System.Windows.Forms.ListBox list_cont;
    }
}

