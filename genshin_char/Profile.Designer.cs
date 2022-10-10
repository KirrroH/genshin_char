namespace genshin_char
{
    partial class Profile
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.num_ar = new System.Windows.Forms.NumericUpDown();
            this.num_wrldlv = new System.Windows.Forms.NumericUpDown();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.txt_dob = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_ar = new System.Windows.Forms.TextBox();
            this.txt_wrldlv = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_ar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_wrldlv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Сервер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ранг приключений";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Уровень мира";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "День рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Статус";
            // 
            // txt_server
            // 
            this.txt_server.Location = new System.Drawing.Point(145, 10);
            this.txt_server.Name = "txt_server";
            this.txt_server.ReadOnly = true;
            this.txt_server.Size = new System.Drawing.Size(204, 22);
            this.txt_server.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(145, 38);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(204, 22);
            this.txt_username.TabIndex = 1;
            // 
            // num_ar
            // 
            this.num_ar.Location = new System.Drawing.Point(145, 165);
            this.num_ar.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.num_ar.Name = "num_ar";
            this.num_ar.Size = new System.Drawing.Size(84, 22);
            this.num_ar.TabIndex = 2;
            this.num_ar.Visible = false;
            // 
            // num_wrldlv
            // 
            this.num_wrldlv.Location = new System.Drawing.Point(145, 193);
            this.num_wrldlv.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.num_wrldlv.Name = "num_wrldlv";
            this.num_wrldlv.Size = new System.Drawing.Size(84, 22);
            this.num_wrldlv.TabIndex = 2;
            this.num_wrldlv.Visible = false;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dob.Location = new System.Drawing.Point(145, 67);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(115, 22);
            this.dtp_dob.TabIndex = 3;
            this.dtp_dob.Value = new System.DateTime(2022, 10, 9, 2, 39, 0, 0);
            this.dtp_dob.Visible = false;
            // 
            // txt_dob
            // 
            this.txt_dob.Location = new System.Drawing.Point(145, 67);
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.ReadOnly = true;
            this.txt_dob.Size = new System.Drawing.Size(115, 22);
            this.txt_dob.TabIndex = 1;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(12, 229);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(154, 30);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Редактировать";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 265);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(98, 30);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_ar
            // 
            this.txt_ar.Location = new System.Drawing.Point(145, 165);
            this.txt_ar.Name = "txt_ar";
            this.txt_ar.ReadOnly = true;
            this.txt_ar.Size = new System.Drawing.Size(84, 22);
            this.txt_ar.TabIndex = 6;
            // 
            // txt_wrldlv
            // 
            this.txt_wrldlv.Location = new System.Drawing.Point(145, 193);
            this.txt_wrldlv.Name = "txt_wrldlv";
            this.txt_wrldlv.ReadOnly = true;
            this.txt_wrldlv.Size = new System.Drawing.Size(84, 22);
            this.txt_wrldlv.TabIndex = 6;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(145, 95);
            this.txt_status.Multiline = true;
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(204, 64);
            this.txt_status.TabIndex = 7;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 307);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_wrldlv);
            this.Controls.Add(this.txt_ar);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dtp_dob);
            this.Controls.Add(this.num_wrldlv);
            this.Controls.Add(this.num_ar);
            this.Controls.Add(this.txt_dob);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_server);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мой профиль";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_ar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_wrldlv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.NumericUpDown num_ar;
        private System.Windows.Forms.NumericUpDown num_wrldlv;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.TextBox txt_dob;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_ar;
        private System.Windows.Forms.TextBox txt_wrldlv;
        private System.Windows.Forms.TextBox txt_status;
    }
}