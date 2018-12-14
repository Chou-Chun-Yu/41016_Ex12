namespace _41016_Ex10 {
    partial class Newdata {
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
            this.Tb_id = new System.Windows.Forms.TextBox();
            this.Lb_id = new System.Windows.Forms.Label();
            this.Lb_name = new System.Windows.Forms.Label();
            this.Tb_name = new System.Windows.Forms.TextBox();
            this.Lb_chi = new System.Windows.Forms.Label();
            this.Tb_chi = new System.Windows.Forms.TextBox();
            this.Lb_eng = new System.Windows.Forms.Label();
            this.Tb_eng = new System.Windows.Forms.TextBox();
            this.Lb_math = new System.Windows.Forms.Label();
            this.Tb_math = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Bt_OK
            // 
            this.Bt_OK.Location = new System.Drawing.Point(39, 152);
            this.Bt_OK.Name = "Bt_OK";
            this.Bt_OK.Size = new System.Drawing.Size(75, 23);
            this.Bt_OK.TabIndex = 0;
            this.Bt_OK.Text = "新增";
            this.Bt_OK.UseVisualStyleBackColor = true;
            this.Bt_OK.Click += new System.EventHandler(this.Bt_OK_Click);
            // 
            // Tb_id
            // 
            this.Tb_id.Location = new System.Drawing.Point(51, 12);
            this.Tb_id.Name = "Tb_id";
            this.Tb_id.Size = new System.Drawing.Size(100, 22);
            this.Tb_id.TabIndex = 1;
            // 
            // Lb_id
            // 
            this.Lb_id.AutoSize = true;
            this.Lb_id.Location = new System.Drawing.Point(12, 15);
            this.Lb_id.Name = "Lb_id";
            this.Lb_id.Size = new System.Drawing.Size(29, 12);
            this.Lb_id.TabIndex = 2;
            this.Lb_id.Text = "學號";
            // 
            // Lb_name
            // 
            this.Lb_name.AutoSize = true;
            this.Lb_name.Location = new System.Drawing.Point(12, 43);
            this.Lb_name.Name = "Lb_name";
            this.Lb_name.Size = new System.Drawing.Size(29, 12);
            this.Lb_name.TabIndex = 4;
            this.Lb_name.Text = "姓名";
            // 
            // Tb_name
            // 
            this.Tb_name.Location = new System.Drawing.Point(51, 40);
            this.Tb_name.Name = "Tb_name";
            this.Tb_name.Size = new System.Drawing.Size(100, 22);
            this.Tb_name.TabIndex = 3;
            // 
            // Lb_chi
            // 
            this.Lb_chi.AutoSize = true;
            this.Lb_chi.Location = new System.Drawing.Point(12, 71);
            this.Lb_chi.Name = "Lb_chi";
            this.Lb_chi.Size = new System.Drawing.Size(29, 12);
            this.Lb_chi.TabIndex = 6;
            this.Lb_chi.Text = "國文";
            // 
            // Tb_chi
            // 
            this.Tb_chi.Location = new System.Drawing.Point(51, 68);
            this.Tb_chi.Name = "Tb_chi";
            this.Tb_chi.Size = new System.Drawing.Size(100, 22);
            this.Tb_chi.TabIndex = 5;
            // 
            // Lb_eng
            // 
            this.Lb_eng.AutoSize = true;
            this.Lb_eng.Location = new System.Drawing.Point(12, 99);
            this.Lb_eng.Name = "Lb_eng";
            this.Lb_eng.Size = new System.Drawing.Size(29, 12);
            this.Lb_eng.TabIndex = 8;
            this.Lb_eng.Text = "英文";
            // 
            // Tb_eng
            // 
            this.Tb_eng.Location = new System.Drawing.Point(51, 96);
            this.Tb_eng.Name = "Tb_eng";
            this.Tb_eng.Size = new System.Drawing.Size(100, 22);
            this.Tb_eng.TabIndex = 7;
            // 
            // Lb_math
            // 
            this.Lb_math.AutoSize = true;
            this.Lb_math.Location = new System.Drawing.Point(12, 127);
            this.Lb_math.Name = "Lb_math";
            this.Lb_math.Size = new System.Drawing.Size(29, 12);
            this.Lb_math.TabIndex = 10;
            this.Lb_math.Text = "數學";
            // 
            // Tb_math
            // 
            this.Tb_math.Location = new System.Drawing.Point(51, 124);
            this.Tb_math.Name = "Tb_math";
            this.Tb_math.Size = new System.Drawing.Size(100, 22);
            this.Tb_math.TabIndex = 9;
            // 
            // Newdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 184);
            this.Controls.Add(this.Lb_math);
            this.Controls.Add(this.Tb_math);
            this.Controls.Add(this.Lb_eng);
            this.Controls.Add(this.Tb_eng);
            this.Controls.Add(this.Lb_chi);
            this.Controls.Add(this.Tb_chi);
            this.Controls.Add(this.Lb_name);
            this.Controls.Add(this.Tb_name);
            this.Controls.Add(this.Lb_id);
            this.Controls.Add(this.Tb_id);
            this.Controls.Add(this.Bt_OK);
            this.Name = "Newdata";
            this.Text = "Newdata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_OK;
        private System.Windows.Forms.Label Lb_id;
        internal System.Windows.Forms.TextBox Tb_id;
        private System.Windows.Forms.Label Lb_name;
        internal System.Windows.Forms.TextBox Tb_name;
        private System.Windows.Forms.Label Lb_chi;
        internal System.Windows.Forms.TextBox Tb_chi;
        private System.Windows.Forms.Label Lb_eng;
        internal System.Windows.Forms.TextBox Tb_eng;
        private System.Windows.Forms.Label Lb_math;
        internal System.Windows.Forms.TextBox Tb_math;
        
    }
}