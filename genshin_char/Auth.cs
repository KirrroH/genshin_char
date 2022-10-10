using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace genshin_char
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();

            txt_pass.UseSystemPasswordChar = true;
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            string query_combo = "select name_server from servers;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmd_combo = new MySqlCommand(query_combo, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd_combo.ExecuteReader();
                while (reader.Read())
                {
                    combo_server.Items.Add(reader[0].ToString());
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if ((txt_login.Text != "") && (txt_pass.Text != "") && (combo_server.SelectedIndex != -1))
            {
                string query_login = $"select id_login from login where login = '{txt_login.Text}' and pass = '{txt_pass.Text}';";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd_login = new MySqlCommand(query_login, conn);

                try
                {
                    conn.Open();
                    int id_login = 0;
                    id_login = Convert.ToInt32(cmd_login.ExecuteScalar());

                    if (id_login != 0)
                    {
                        string query_user = $"select id_user from users where id_login = {id_login} and id_server = {combo_server.SelectedIndex + 1};";
                        MySqlCommand cmd_user = new MySqlCommand(query_user, conn);

                        try
                        {
                            int id_user = 0;
                            id_user = Convert.ToInt32(cmd_user.ExecuteScalar());
                            
                            if (id_user != 0)
                            {
                                Menu win = new Menu(id_user);
                                win.Owner = this;
                                this.Hide();
                                win.Show();
                                txt_login.Clear();
                                txt_pass.Clear();
                                combo_server.SelectedIndex = -1;
                            }
                            else MessageBox.Show("У вас нет аккаунта на этом сервере!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                        }
                    }
                    else MessageBox.Show("Логин или пароль введены неверно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
            }
            else MessageBox.Show("Все поля должны быть заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void link_show_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_pass.UseSystemPasswordChar = false;
            link_show.Visible = false;
            link_hide.Visible = true;
        }

        private void link_hide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
            link_show.Visible = true;
            link_hide.Visible = false;
        }
    }
}