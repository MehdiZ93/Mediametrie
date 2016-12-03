namespace Mediametrie
{
    partial class modify_cont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modify_cont));
            this.label1 = new System.Windows.Forms.Label();
            this.title_cont = new System.Windows.Forms.TextBox();
            this.btn_reset_cont = new System.Windows.Forms.Button();
            this.btn_val_cont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Titre";
            // 
            // title_cont
            // 
            this.title_cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.title_cont.Location = new System.Drawing.Point(11, 45);
            this.title_cont.Name = "title_cont";
            this.title_cont.Size = new System.Drawing.Size(352, 35);
            this.title_cont.TabIndex = 26;
            // 
            // btn_reset_cont
            // 
            this.btn_reset_cont.Location = new System.Drawing.Point(103, 102);
            this.btn_reset_cont.Name = "btn_reset_cont";
            this.btn_reset_cont.Size = new System.Drawing.Size(121, 75);
            this.btn_reset_cont.TabIndex = 25;
            this.btn_reset_cont.Text = "Reset";
            this.btn_reset_cont.UseVisualStyleBackColor = true;
            this.btn_reset_cont.Click += new System.EventHandler(this.btn_reset_cont_Click);
            // 
            // btn_val_cont
            // 
            this.btn_val_cont.Location = new System.Drawing.Point(242, 102);
            this.btn_val_cont.Name = "btn_val_cont";
            this.btn_val_cont.Size = new System.Drawing.Size(121, 75);
            this.btn_val_cont.TabIndex = 24;
            this.btn_val_cont.Text = "Valider";
            this.btn_val_cont.UseVisualStyleBackColor = true;
            this.btn_val_cont.Click += new System.EventHandler(this.btn_val_cont_Click);
            // 
            // modify_cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 190);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title_cont);
            this.Controls.Add(this.btn_reset_cont);
            this.Controls.Add(this.btn_val_cont);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(397, 246);
            this.MinimumSize = new System.Drawing.Size(397, 246);
            this.Name = "modify_cont";
            this.Text = "Modification d\'un container";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title_cont;
        private System.Windows.Forms.Button btn_reset_cont;
        private System.Windows.Forms.Button btn_val_cont;
    }
}