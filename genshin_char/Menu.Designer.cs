namespace genshin_char
{
    partial class Menu
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
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_char = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_profile
            // 
            this.btn_profile.Location = new System.Drawing.Point(38, 13);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(197, 30);
            this.btn_profile.TabIndex = 0;
            this.btn_profile.Text = "Мой профиль";
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_char
            // 
            this.btn_char.Location = new System.Drawing.Point(38, 49);
            this.btn_char.Name = "btn_char";
            this.btn_char.Size = new System.Drawing.Size(197, 30);
            this.btn_char.TabIndex = 0;
            this.btn_char.Text = "Мои персонажи";
            this.btn_char.UseVisualStyleBackColor = true;
            this.btn_char.Click += new System.EventHandler(this.btn_char_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(38, 85);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(197, 30);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Выйти из аккаунта";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(38, 121);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(197, 30);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Выйти из приложения";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 165);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_char);
            this.Controls.Add(this.btn_profile);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_char;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_exit;
    }
}