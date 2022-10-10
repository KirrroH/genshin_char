using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace genshin_char
{
    public partial class CharProfile : Form
    {
        public int ID;
        public CharProfile(int id_charlist)
        {
            InitializeComponent();

            ID = id_charlist;
        }

        private void fill_form()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            string query = $"select c.name_char, r.rarity_name, v.name_vision, w.name_weapon, cl.lv, c.bio_char from char_list cl join characters c on cl.id_char = c.id_char join rarity r on c.id_rarity = r.id_rarity join vision v on c.id_vision = v.id_vision join weapon_type w on c.id_weapon = w.id_weapon where cl.id_charlist = {ID}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                txt_charname.Text = reader[0].ToString();
                txt_rarity.Text = reader[1].ToString();
                txt_vision.Text = reader[2].ToString();
                txt_weapon.Text = reader[3].ToString();
                txt_lv.Text = reader[4].ToString();
                num_lv.Value = Convert.ToInt32(reader[4]);
                txt_bio.Text = reader[5].ToString();

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void CharProfile_Load(object sender, EventArgs e)
        {
            fill_form();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            switch(btn_edit.Text)
            {
                case "Изменить":
                    txt_lv.Visible = false;
                    num_lv.Visible = true;
                    btn_delete.Visible = true;
                    btn_edit.Text = "Сохранить";
                    break;
                case "Сохранить":
                    if (num_lv.Value != 0)
                    {
                        string query_lv = $"update char_list set lv = {num_lv.Value} where id_charlist = {ID};";
                        MySqlConnection conn = DBUtils.GetDBConnection();
                        MySqlCommand cmd_lv = new MySqlCommand(query_lv, conn);
                        try
                        {
                            conn.Open();
                            cmd_lv.ExecuteNonQuery();
                            conn.Close();
                            fill_form();
                            txt_lv.Visible = true;
                            num_lv.Visible = false;
                            btn_delete.Visible = false;
                            btn_edit.Text = "Изменить";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                        }
                    }
                    else MessageBox.Show("Уровень не может быть равен нулю!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            switch (btn_edit.Text)
            {
                case "Изменить":
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить этого персонажа из списка?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = $"delete from char_list where id_charlist = {ID};";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Owner.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
            }
        }
    }
}