namespace laba7
{
    partial class guestForm
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
            this.dgv_guest = new System.Windows.Forms.DataGridView();
            this.rtb_guest = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_hint_guest = new System.Windows.Forms.Label();
            this.chb_3 = new System.Windows.Forms.CheckBox();
            this.chb_2 = new System.Windows.Forms.CheckBox();
            this.chb_1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reSignIn = new System.Windows.Forms.Button();
            this.tb_guest_database = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_guest)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_guest
            // 
            this.dgv_guest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_guest.Location = new System.Drawing.Point(12, 12);
            this.dgv_guest.Name = "dgv_guest";
            this.dgv_guest.Size = new System.Drawing.Size(486, 310);
            this.dgv_guest.TabIndex = 0;
            // 
            // rtb_guest
            // 
            this.rtb_guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_guest.Location = new System.Drawing.Point(12, 328);
            this.rtb_guest.Name = "rtb_guest";
            this.rtb_guest.Size = new System.Drawing.Size(266, 145);
            this.rtb_guest.TabIndex = 1;
            this.rtb_guest.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(542, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выполнить запрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_guest_Click);
            // 
            // lbl_hint_guest
            // 
            this.lbl_hint_guest.AutoSize = true;
            this.lbl_hint_guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_hint_guest.Location = new System.Drawing.Point(12, 476);
            this.lbl_hint_guest.Name = "lbl_hint_guest";
            this.lbl_hint_guest.Size = new System.Drawing.Size(0, 18);
            this.lbl_hint_guest.TabIndex = 3;
            // 
            // chb_3
            // 
            this.chb_3.AutoSize = true;
            this.chb_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb_3.Location = new System.Drawing.Point(284, 388);
            this.chb_3.Name = "chb_3";
            this.chb_3.Size = new System.Drawing.Size(163, 24);
            this.chb_3.TabIndex = 10;
            this.chb_3.Text = "Групповой запрос";
            this.chb_3.UseVisualStyleBackColor = true;
            this.chb_3.CheckedChanged += new System.EventHandler(this.chb_3_CheckedChanged);
            // 
            // chb_2
            // 
            this.chb_2.AutoSize = true;
            this.chb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb_2.Location = new System.Drawing.Point(284, 358);
            this.chb_2.Name = "chb_2";
            this.chb_2.Size = new System.Drawing.Size(252, 24);
            this.chb_2.TabIndex = 9;
            this.chb_2.Text = "Получить данные с условием";
            this.chb_2.UseVisualStyleBackColor = true;
            this.chb_2.CheckedChanged += new System.EventHandler(this.chb_2_CheckedChanged);
            // 
            // chb_1
            // 
            this.chb_1.AutoSize = true;
            this.chb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb_1.Location = new System.Drawing.Point(284, 328);
            this.chb_1.Name = "chb_1";
            this.chb_1.Size = new System.Drawing.Size(194, 24);
            this.chb_1.TabIndex = 8;
            this.chb_1.Text = "Получить все данные";
            this.chb_1.UseVisualStyleBackColor = true;
            this.chb_1.CheckedChanged += new System.EventHandler(this.chb_1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(488, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Вы вошли как гость :)";
            // 
            // btn_reSignIn
            // 
            this.btn_reSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_reSignIn.Location = new System.Drawing.Point(542, 403);
            this.btn_reSignIn.Name = "btn_reSignIn";
            this.btn_reSignIn.Size = new System.Drawing.Size(110, 70);
            this.btn_reSignIn.TabIndex = 12;
            this.btn_reSignIn.Text = "Сменить профиль";
            this.btn_reSignIn.UseVisualStyleBackColor = true;
            this.btn_reSignIn.Click += new System.EventHandler(this.btn_reSignIn_Click);
            // 
            // tb_guest_database
            // 
            this.tb_guest_database.Location = new System.Drawing.Point(508, 35);
            this.tb_guest_database.Name = "tb_guest_database";
            this.tb_guest_database.Size = new System.Drawing.Size(100, 20);
            this.tb_guest_database.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(504, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Введите название базы данных";
            // 
            // guestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 605);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_guest_database);
            this.Controls.Add(this.btn_reSignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chb_3);
            this.Controls.Add(this.chb_2);
            this.Controls.Add(this.chb_1);
            this.Controls.Add(this.lbl_hint_guest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtb_guest);
            this.Controls.Add(this.dgv_guest);
            this.Name = "guestForm";
            this.Text = "guestForm";
            this.Load += new System.EventHandler(this.guestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_guest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_guest;
        private System.Windows.Forms.RichTextBox rtb_guest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_hint_guest;
        private System.Windows.Forms.CheckBox chb_3;
        private System.Windows.Forms.CheckBox chb_2;
        private System.Windows.Forms.CheckBox chb_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reSignIn;
        private System.Windows.Forms.TextBox tb_guest_database;
        private System.Windows.Forms.Label label2;
    }
}