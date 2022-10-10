using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace genshin_char
{
    public partial class AddChar : Form
    {
        public int ID_U, ID_C;

        public AddChar(int id_user, int id_char)
        {
            InitializeComponent();

            ID_U = id_user;
            ID_C = id_char;
        }

        private void AddChar_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            string query = $"select c.name_char, r.rarity_name, v.name_vision, w.name_weapon, c.bio_char from characters c join rarity r on c.id_rarity = r.id_rarity join vision v on c.id_vision = v.id_vision join weapon_type w on c.id_weapon = w.id_weapon where c.id_char = {ID_C};";
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
                txt_bio.Text = reader[4].ToString();

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (num_lv.Value > 0)
            {
                string query_insert = $"insert into char_list (id_user, id_char, lv) values ({ID_U}, {ID_C}, {num_lv.Value});";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd_insert = new MySqlCommand(query_insert, conn);
                string query_id = "select id_char from char_list where id_charlist = (select max(id_charlist) from char_list);";
                MySqlCommand cmd_id = new MySqlCommand(query_id, conn);

                try
                {
                    conn.Open();
                    cmd_insert.ExecuteNonQuery();
                    int id_new = Convert.ToInt32(cmd_id.ExecuteScalar());
                    conn.Close();
                    DataBank.ID_list += $",{id_new}";
                    Owner.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
            }
            else MessageBox.Show("Установите уровень!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление персонажа?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Owner.Show();
                this.Close();
            }
        }
    }
}