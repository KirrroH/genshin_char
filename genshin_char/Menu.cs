using System;
using System.Windows.Forms;

namespace genshin_char
{
    public partial class Menu : Form
    {
        public int ID;

        public Menu(int id_user)
        {
            InitializeComponent();

            ID = id_user;
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Profile win = new Profile(ID);
            win.Owner = this;
            win.Show();
            this.Hide();
        }

        private void btn_char_Click(object sender, EventArgs e)
        {
            Charlist win = new Charlist(ID);
            win.Owner = this;
            win.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}