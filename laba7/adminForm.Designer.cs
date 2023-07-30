namespace laba7
{
    partial class adminForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.btn_admin = new System.Windows.Forms.Button();
            this.rtb_admin = new System.Windows.Forms.RichTextBox();
            this.chb_1 = new System.Windows.Forms.CheckBox();
            this.chb_2 = new System.Windows.Forms.CheckBox();
            this.lbl_hint = new System.Windows.Forms.Label();
            this.chb_3 = new System.Windows.Forms.CheckBox();
            this.chb_4 = new System.Windows.Forms.CheckBox();
            this.chb_5 = new System.Windows.Forms.CheckBox();
            this.chb_6 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_resignIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_admin_database = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_admin
            // 
            this.dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin.Location = new System.Drawing.Point(12, 12);
            this.dgv_admin.Name = "dgv_admin";
            this.dgv_admin.Size = new System.Drawing.Size(787, 452);
            this.dgv_admin.TabIndex = 0;
            // 
            // btn_admin
            // 
            this.btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_admin.Location = new System.Drawing.Point(689, 475);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(110, 78);
            this.btn_admin.TabIndex = 2;
            this.btn_admin.Text = "Выполнить запрос";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // rtb_admin
            // 
            this.rtb_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_admin.Location = new System.Drawing.Point(12, 470);
            this.rtb_admin.Name = "rtb_admin";
            this.rtb_admin.Size = new System.Drawing.Size(413, 103);
            this.rtb_admin.TabIndex = 3;
            this.rtb_admin.Text = "";
            // 
            // chb_1
            // 
            this.chb_1.AutoSize = true;
            this.chb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb_1.Location = new System.Drawing.Point(431, 475);
            this.chb_1.Name = "chb_1";
            this.chb_1.Size = new System.Drawing.Size(194, 24);
            this.chb_1.TabIndex = 4;
            this.chb_1.Text = "Получить все данные";
            this.chb_1.UseVisualStyleBackColor = true;
            this.chb_1.CheckedChanged += new System.EventHandler(this.chb_1_CheckedChanged);
            // 
            // chb_2
            // 
            this.chb_2.AutoSize = true;
            this.chb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb_2.Location = new System.Drawing.Point(431, 505);
            this.chb_2.Name = "chb_2";
            this.chb_2.Size = new System.Drawing.Size(252, 24);
            this.chb_2.TabIndex = 5;
            this.chb_2.Text = "Получить данные с условием";
            this.chb_2.UseVisualStyleBackColor = true;
            this.chb_2.CheckedChanged += new System.EventHandler(this.chb_2_CheckedChanged);
            // 
            // lbl_hint
            // 
            this.lbl_hint.AutoSize = true;
            this.lbl_hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_hint.Location = new System.Drawing.Point(8, 576);
            this.lbl_hint.Name = "lbl_hint";
            this.lbl_hint.Size = new System.Drawing.Size(165, 20);
            this.lbl_hint.TabIndex = 6;
            this.lbl_hint.Text = "Ожидание запроса...";
            // 
            // chb_3
            // 
            this.chb_3.AutoSize = true;
            this.chb_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb_3.Location = new System.Drawing.Point(431, 535);
            this.chb_3.Name = "chb_3";
            this.chb_3.Size = new System.Drawing.Size(163, 24);
            this.chb_3.TabIndex = 7;
            this.chb_3.Text = "Групповой запрос";
            this.chb_3.UseVisualStyleBackColor = true;
            this.chb_3.CheckedChanged += new System.EventHandler(this.chb_3_CheckedChanged);
            // 
            // chb_4
            // 
            this.chb_4.AutoSize = true;
            this.chb_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb_4.Location = new System.Drawing.Point(431, 565);
            this.chb_4.Name = "chb_4";
            this.chb_4.Size = new System.Drawing.Size(160, 24);
            this.chb_4.TabIndex = 8;
            this.chb_4.Text = "Создать таблицу";
            this.chb_4.UseVisualStyleBackColor = true;
            this.chb_4.CheckedChanged += new System.EventHandler(this.chb_4_CheckedChanged);
            // 
            // chb_5
            // 
            this.chb_5.AutoSize = true;
            this.chb_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb_5.Location = new System.Drawing.Point(431, 596);
            this.chb_5.Name = "chb_5";
            this.chb_5.Size = new System.Drawing.Size(160, 24);
            this.chb_5.TabIndex = 9;
            this.chb_5.Text = "Изменть таблицу";
            this.chb_5.UseVisualStyleBackColor = true;
            this.chb_5.CheckedChanged += new System.EventHandler(this.chb_5_CheckedChanged);
            // 
            // chb_6
            // 
            this.chb_6.AutoSize = true;
            this.chb_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb_6.Location = new System.Drawing.Point(431, 627);
            this.chb_6.Name = "chb_6";
            this.chb_6.Size = new System.Drawing.Size(179, 24);
            this.chb_6.TabIndex = 10;
            this.chb_6.Text = "Добавить сущность";
            this.chb_6.UseVisualStyleBackColor = true;
            this.chb_6.CheckedChanged += new System.EventHandler(this.chb_6_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(619, 682);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Вы вошли как админ :)";
            // 
            // btn_resignIn
            // 
            this.btn_resignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_resignIn.Location = new System.Drawing.Point(689, 559);
            this.btn_resignIn.Name = "btn_resignIn";
            this.btn_resignIn.Size = new System.Drawing.Size(110, 61);
            this.btn_resignIn.TabIndex = 12;
            this.btn_resignIn.Text = "Сменить профиль";
            this.btn_resignIn.UseVisualStyleBackColor = true;
            this.btn_resignIn.Click += new System.EventHandler(this.btn_resignIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(805, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Введите название базы данных";
            // 
            // tb_admin_database
            // 
            this.tb_admin_database.Location = new System.Drawing.Point(809, 35);
            this.tb_admin_database.Name = "tb_admin_database";
            this.tb_admin_database.Size = new System.Drawing.Size(100, 20);
            this.tb_admin_database.TabIndex = 15;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 715);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_admin_database);
            this.Controls.Add(this.btn_resignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chb_6);
            this.Controls.Add(this.chb_5);
            this.Controls.Add(this.chb_4);
            this.Controls.Add(this.chb_3);
            this.Controls.Add(this.lbl_hint);
            this.Controls.Add(this.chb_2);
            this.Controls.Add(this.chb_1);
            this.Controls.Add(this.rtb_admin);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.dgv_admin);
            this.Name = "adminForm";
            this.Text = "SQL в С#";
            this.Load += new System.EventHandler(this.adminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_admin;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.RichTextBox rtb_admin;
        private System.Windows.Forms.CheckBox chb_1;
        private System.Windows.Forms.CheckBox chb_2;
        private System.Windows.Forms.Label lbl_hint;
        private System.Windows.Forms.CheckBox chb_3;
        private System.Windows.Forms.CheckBox chb_4;
        private System.Windows.Forms.CheckBox chb_5;
        private System.Windows.Forms.CheckBox chb_6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_resignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_admin_database;
    }
}

