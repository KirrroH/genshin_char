namespace genshin_char
{
    partial class AddChar
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
            this.num_lv = new System.Windows.Forms.NumericUpDown();
            this.txt_bio = new System.Windows.Forms.TextBox();
            this.txt_weapon = new System.Windows.Forms.TextBox();
            this.txt_vision = new System.Windows.Forms.TextBox();
            this.txt_rarity = new System.Windows.Forms.TextBox();
            this.txt_charname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_lv)).BeginInit();
            this.SuspendLayout();
            // 
            // num_lv
            // 
            this.num_lv.Location = new System.Drawing.Point(124, 122);
            this.num_lv.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.num_lv.Name = "num_lv";
            this.num_lv.Size = new System.Drawing.Size(70, 22);
            this.num_lv.TabIndex = 21;
            // 
            // txt_bio
            // 
            this.txt_bio.Location = new System.Drawing.Point(124, 150);
            this.txt_bio.Multiline = true;
            this.txt_bio.Name = "txt_bio";
            this.txt_bio.ReadOnly = true;
            this.txt_bio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_bio.Size = new System.Drawing.Size(219, 83);
            this.txt_bio.TabIndex = 15;
            // 
            // txt_weapon
            // 
            this.txt_weapon.Location = new System.Drawing.Point(124, 94);
            this.txt_weapon.Name = "txt_weapon";
            this.txt_weapon.ReadOnly = true;
            this.txt_weapon.Size = new System.Drawing.Size(219, 22);
            this.txt_weapon.TabIndex = 17;
            // 
            // txt_vision
            // 
            this.txt_vision.Location = new System.Drawing.Point(124, 66);
            this.txt_vision.Name = "txt_vision";
            this.txt_vision.ReadOnly = true;
            this.txt_vision.Size = new System.Drawing.Size(219, 22);
            this.txt_vision.TabIndex = 18;
            // 
            // txt_rarity
            // 
            this.txt_rarity.Location = new System.Drawing.Point(124, 38);
            this.txt_rarity.Name = "txt_rarity";
            this.txt_rarity.ReadOnly = true;
            this.txt_rarity.Size = new System.Drawing.Size(219, 22);
            this.txt_rarity.TabIndex = 19;
            // 
            // txt_charname
            // 
            this.txt_charname.Location = new System.Drawing.Point(124, 10);
            this.txt_charname.Name = "txt_charname";
            this.txt_charname.ReadOnly = true;
            this.txt_charname.Size = new System.Drawing.Size(219, 22);
            this.txt_charname.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Уровень";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Тип оружия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Глаз бога";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Редкость";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Имя персонажа";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(10, 293);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 30);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(10, 250);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(108, 30);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // AddChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 334);
            this.Controls.Add(this.num_lv);
            this.Controls.Add(this.txt_bio);
            this.Controls.Add(this.txt_weapon);
            this.Controls.Add(this.txt_vision);
            this.Controls.Add(this.txt_rarity);
            this.Controls.Add(this.txt_charname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Name = "AddChar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить персонажа";
            this.Load += new System.EventHandler(this.AddChar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_lv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_lv;
        private System.Windows.Forms.TextBox txt_bio;
        private System.Windows.Forms.TextBox txt_weapon;
        private System.Windows.Forms.TextBox txt_vision;
        private System.Windows.Forms.TextBox txt_rarity;
        private System.Windows.Forms.TextBox txt_charname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_add;
    }
}