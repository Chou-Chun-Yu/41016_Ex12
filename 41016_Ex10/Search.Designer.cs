namespace _41016_Ex10 {
    partial class Search {
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
            this.Bt_OK = new System.Windows.Forms.Button();
            this.Lb_search = new System.Windows.Forms.Label();
            this.Tb_Search = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Bt_OK
            // 
            this.Bt_OK.Location = new System.Drawing.Point(47, 87);
            this.Bt_OK.Name = "Bt_OK";
            this.Bt_OK.Size = new System.Drawing.Size(75, 23);
            this.Bt_OK.TabIndex = 0;
            this.Bt_OK.Text = "查詢";
            this.Bt_OK.UseVisualStyleBackColor = true;
            this.Bt_OK.Click += new System.EventHandler(this.Bt_OK_Click);
            // 
            // Lb_search
            // 
            this.Lb_search.AutoSize = true;
            this.Lb_search.Location = new System.Drawing.Point(19, 20);
            this.Lb_search.Name = "Lb_search";
            this.Lb_search.Size = new System.Drawing.Size(113, 12);
            this.Lb_search.TabIndex = 1;
            this.Lb_search.Text = "請輸入要查詢的學號";
            // 
            // Tb_Search
            // 
            this.Tb_Search.Location = new System.Drawing.Point(32, 45);
            this.Tb_Search.Name = "Tb_Search";
            this.Tb_Search.Size = new System.Drawing.Size(100, 22);
            this.Tb_Search.TabIndex = 2;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 123);
            this.Controls.Add(this.Tb_Search);
            this.Controls.Add(this.Lb_search);
            this.Controls.Add(this.Bt_OK);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_OK;
        private System.Windows.Forms.Label Lb_search;
        private System.Windows.Forms.TextBox Tb_Search;
    }
}