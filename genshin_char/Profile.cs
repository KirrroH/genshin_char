using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace genshin_char
{
    public partial class Profile : Form
    {
        public int ID = 0;

        public Profile(int id_user)
        {
            InitializeComponent();

            ID = id_user;
        }

        private void fill_form()
        {
            string query = $"select servers.name_server, users.name_user, users.birth_date, users.status_user, users.advent_rank, users.world_lv from users join servers on users.id_server = servers.id_server where users.id_user = {ID};";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                txt_server.Text = reader[0].ToString();
                txt_username.Text = reader[1].ToString();
                txt_dob.Text = Convert.ToDateTime(reader[2].ToString()).ToShortDateString();
                dtp_dob.Value = Convert.ToDateTime(reader[2].ToString());
                txt_status.Text = reader[3].ToString();
                txt_ar.Text = reader[4].ToString();
                num_ar.Value = Convert.ToInt32(reader[4].ToString());
                txt_wrldlv.Text = reader[5].ToString();
                num_wrldlv.Value = Convert.ToInt32(reader[5].ToString());
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            fill_form();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            switch (btn_edit.Text)
            {
                case "Редактировать":
                    txt_username.ReadOnly = false;
                    txt_dob.Visible = false;
                    dtp_dob.Visible = true;
                    txt_status.ReadOnly = false;
                    txt_ar.Visible = false;
                    num_ar.Visible = true;
                    txt_wrldlv.Visible = false;
                    num_wrldlv.Visible = true;
                    btn_edit.Text = "Сохранить";
                    break;
                case "Сохранить":
                    if ((txt_username.Text != "") && (num_ar.Value != 0) && (num_wrldlv.Value != 0))
                    {
                        string year = dtp_dob.Value.Year.ToString();
                        string month = dtp_dob.Value.Month.ToString();
                        string day = dtp_dob.Value.Day.ToString();
                        string query_update = $"update users set name_user = '{txt_username.Text}', birth_date = '{year}-{month}-{day}', status_user = '{txt_status.Text}', advent_rank = {num_ar.Value}, world_lv = {num_wrldlv.Value} where id_user = {ID};";
                        MySqlConnection conn = DBUtils.GetDBConnection();
                        MySqlCommand cmd_update = new MySqlCommand(query_update, conn);

                        try
                        {
                            conn.Open();
                            cmd_update.ExecuteNonQuery();
                            conn.Close();
                            fill_form();
                            txt_username.ReadOnly = true;
                            txt_dob.Visible = true;
                            dtp_dob.Visible = false;
                            txt_status.ReadOnly = true;
                            txt_ar.Visible = true;
                            num_ar.Visible = false;
                            txt_wrldlv.Visible = true;
                            num_wrldlv.Visible = false;
                            btn_edit.Text = "Редактировать";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                        }
                    }
                    else MessageBox.Show("У вас не может не быть имени, ранга приключений или уровня мира!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            switch (btn_edit.Text)
            {
                case "Редактировать":
                    Owner.Show();
                    this.Close();
                    break;
                case "Сохранить":
                    if (MessageBox.Show("Изменения не будут сохранены. Вы уверены, что хотите вернуться?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Owner.Show();
                        this.Close();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}