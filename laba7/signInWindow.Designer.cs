namespace laba7
{
    partial class signInWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_signIn = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_signIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в информационную систему!";
            // 
            // btn_signIn
            // 
            this.btn_signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_signIn.Location = new System.Drawing.Point(12, 79);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(100, 24);
            this.btn_signIn.TabIndex = 2;
            this.btn_signIn.Text = "Вход";
            this.btn_signIn.UseVisualStyleBackColor = true;
            this.btn_signIn.Click += new System.EventHandler(this.btn_signIn_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(12, 53);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(145, 20);
            this.tb_password.TabIndex = 3;
            // 
            // lbl_signIn
            // 
            this.lbl_signIn.AutoSize = true;
            this.lbl_signIn.Location = new System.Drawing.Point(163, 60);
            this.lbl_signIn.Name = "lbl_signIn";
            this.lbl_signIn.Size = new System.Drawing.Size(0, 13);
            this.lbl_signIn.TabIndex = 4;
            // 
            // signInWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 126);
            this.Controls.Add(this.lbl_signIn);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.btn_signIn);
            this.Controls.Add(this.label1);
            this.Name = "signInWindow";
            this.Text = "signInWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_signIn;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_signIn;
    }
}