namespace genshin_char
{
    partial class Auth
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_server = new System.Windows.Forms.ComboBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.link_hide = new System.Windows.Forms.LinkLabel();
            this.link_show = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(101, 33);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(198, 22);
            this.txt_login.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Пароль";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(101, 81);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(198, 22);
            this.txt_pass.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Сервер";
            // 
            // combo_server
            // 
            this.combo_server.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_server.FormattingEnabled = true;
            this.combo_server.Location = new System.Drawing.Point(101, 152);
            this.combo_server.Name = "combo_server";
            this.combo_server.Size = new System.Drawing.Size(198, 24);
            this.combo_server.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(163, 200);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 30);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Вход";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // link_hide
            // 
            this.link_hide.ActiveLinkColor = System.Drawing.Color.Blue;
            this.link_hide.AutoSize = true;
            this.link_hide.Location = new System.Drawing.Point(98, 107);
            this.link_hide.Name = "link_hide";
            this.link_hide.Size = new System.Drawing.Size(104, 16);
            this.link_hide.TabIndex = 4;
            this.link_hide.TabStop = true;
            this.link_hide.Text = "Скрыть пароль";
            this.link_hide.Visible = false;
            this.link_hide.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link_hide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_hide_LinkClicked);
            // 
            // link_show
            // 
            this.link_show.ActiveLinkColor = System.Drawing.Color.Blue;
            this.link_show.AutoSize = true;
            this.link_show.Location = new System.Drawing.Point(98, 107);
            this.link_show.Name = "link_show";
            this.link_show.Size = new System.Drawing.Size(120, 16);
            this.link_show.TabIndex = 5;
            this.link_show.TabStop = true;
            this.link_show.Text = "Показать пароль";
            this.link_show.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link_show.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_show_LinkClicked);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 242);
            this.Controls.Add(this.link_show);
            this.Controls.Add(this.link_hide);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.combo_server);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genshin Impact Characters";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_server;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel link_hide;
        private System.Windows.Forms.LinkLabel link_show;
    }
}

