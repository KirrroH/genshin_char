namespace genshin_char
{
    partial class Charlist
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_addChar = new System.Windows.Forms.Button();
            this.lbl_char = new System.Windows.Forms.Label();
            this.dgv_charlist = new System.Windows.Forms.DataGridView();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_charlist)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 345);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 30);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_addChar
            // 
            this.btn_addChar.Location = new System.Drawing.Point(692, 345);
            this.btn_addChar.Name = "btn_addChar";
            this.btn_addChar.Size = new System.Drawing.Size(96, 30);
            this.btn_addChar.TabIndex = 0;
            this.btn_addChar.Text = "Добавить";
            this.btn_addChar.UseVisualStyleBackColor = true;
            this.btn_addChar.Click += new System.EventHandler(this.btn_addChar_Click);
            // 
            // lbl_char
            // 
            this.lbl_char.AutoSize = true;
            this.lbl_char.Location = new System.Drawing.Point(9, 12);
            this.lbl_char.Name = "lbl_char";
            this.lbl_char.Size = new System.Drawing.Size(134, 16);
            this.lbl_char.TabIndex = 1;
            this.lbl_char.Text = "Всего персонажей: ";
            // 
            // dgv_charlist
            // 
            this.dgv_charlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_charlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_charlist.Location = new System.Drawing.Point(12, 44);
            this.dgv_charlist.Name = "dgv_charlist";
            this.dgv_charlist.ReadOnly = true;
            this.dgv_charlist.RowHeadersWidth = 51;
            this.dgv_charlist.RowTemplate.Height = 24;
            this.dgv_charlist.Size = new System.Drawing.Size(776, 290);
            this.dgv_charlist.TabIndex = 2;
            this.dgv_charlist.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_charlist_CellContentDoubleClick);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(611, 345);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 30);
            this.btn_print.TabIndex = 0;
            this.btn_print.Text = "Печать";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(514, 345);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(91, 30);
            this.btn_refresh.TabIndex = 0;
            this.btn_refresh.Text = "Обновить";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(568, 9);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(220, 22);
            this.txt_search.TabIndex = 4;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // Charlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_charlist);
            this.Controls.Add(this.lbl_char);
            this.Controls.Add(this.btn_addChar);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_back);
            this.Name = "Charlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список персонажей";
            this.Load += new System.EventHandler(this.Charlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_charlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_addChar;
        private System.Windows.Forms.Label lbl_char;
        private System.Windows.Forms.DataGridView dgv_charlist;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
    }
}