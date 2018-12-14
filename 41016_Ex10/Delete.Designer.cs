namespace _41016_Ex10 {
    partial class Delete {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Lb_delete = new System.Windows.Forms.Label();
            this.Bt_delete = new System.Windows.Forms.Button();
            this.Tb_delete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lb_delete
            // 
            this.Lb_delete.AutoSize = true;
            this.Lb_delete.Location = new System.Drawing.Point(12, 15);
            this.Lb_delete.Name = "Lb_delete";
            this.Lb_delete.Size = new System.Drawing.Size(65, 12);
            this.Lb_delete.TabIndex = 0;
            this.Lb_delete.Text = "Enter the ID:";
            // 
            // Bt_delete
            // 
            this.Bt_delete.Location = new System.Drawing.Point(48, 40);
            this.Bt_delete.Name = "Bt_delete";
            this.Bt_delete.Size = new System.Drawing.Size(75, 23);
            this.Bt_delete.TabIndex = 1;
            this.Bt_delete.Text = "Delete";
            this.Bt_delete.UseVisualStyleBackColor = true;
            this.Bt_delete.Click += new System.EventHandler(this.Bt_delete_Click);
            // 
            // Tb_delete
            // 
            this.Tb_delete.Location = new System.Drawing.Point(83, 12);
            this.Tb_delete.Name = "Tb_delete";
            this.Tb_delete.Size = new System.Drawing.Size(100, 22);
            this.Tb_delete.TabIndex = 2;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 68);
            this.Controls.Add(this.Tb_delete);
            this.Controls.Add(this.Bt_delete);
            this.Controls.Add(this.Lb_delete);
            this.Name = "Delete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_delete;
        private System.Windows.Forms.Button Bt_delete;
        internal System.Windows.Forms.TextBox Tb_delete;
    }
}