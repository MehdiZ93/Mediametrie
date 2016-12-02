namespace Mediametrie
{
    partial class add_cont
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
            this.label1 = new System.Windows.Forms.Label();
            this.title_cont = new System.Windows.Forms.TextBox();
            this.btn_reset_cont = new System.Windows.Forms.Button();
            this.btn_val_cont = new System.Windows.Forms.Button();
            this.database1DataSet = new Mediametrie.Database1DataSet();
            this.containerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.containerTableAdapter = new Mediametrie.Database1DataSetTableAdapters.ContainerTableAdapter();
            this.tableAdapterManager = new Mediametrie.Database1DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Titre";
            // 
            // title_cont
            // 
            this.title_cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.title_cont.Location = new System.Drawing.Point(12, 41);
            this.title_cont.Name = "title_cont";
            this.title_cont.Size = new System.Drawing.Size(352, 35);
            this.title_cont.TabIndex = 22;
            // 
            // btn_reset_cont
            // 
            this.btn_reset_cont.Location = new System.Drawing.Point(104, 98);
            this.btn_reset_cont.Name = "btn_reset_cont";
            this.btn_reset_cont.Size = new System.Drawing.Size(121, 75);
            this.btn_reset_cont.TabIndex = 21;
            this.btn_reset_cont.Text = "Reset";
            this.btn_reset_cont.UseVisualStyleBackColor = true;
            this.btn_reset_cont.Click += new System.EventHandler(this.btn_reset_cont_Click);
            // 
            // btn_val_cont
            // 
            this.btn_val_cont.Location = new System.Drawing.Point(243, 98);
            this.btn_val_cont.Name = "btn_val_cont";
            this.btn_val_cont.Size = new System.Drawing.Size(121, 75);
            this.btn_val_cont.TabIndex = 20;
            this.btn_val_cont.Text = "Valider";
            this.btn_val_cont.UseVisualStyleBackColor = true;
            this.btn_val_cont.Click += new System.EventHandler(this.btn_reset_val_Click);
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
            // add_cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 190);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title_cont);
            this.Controls.Add(this.btn_reset_cont);
            this.Controls.Add(this.btn_val_cont);
            this.MinimumSize = new System.Drawing.Size(397, 246);
            this.Name = "add_cont";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title_cont;
        private System.Windows.Forms.Button btn_reset_cont;
        private System.Windows.Forms.Button btn_val_cont;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource containerBindingSource;
        private Database1DataSetTableAdapters.ContainerTableAdapter containerTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}