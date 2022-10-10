using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;

namespace genshin_char
{
    public partial class Charlist : Form
    {
        public int ID;
        public Charlist(int id_user)
        {
            InitializeComponent();

            ID = id_user;
        }

        private void fill_form (string query_char)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            string query_count = $"select count(*) from char_list where id_user = {ID};";
            MySqlCommand cmd_count = new MySqlCommand(query_count, conn);

            MySqlDataAdapter sda = new MySqlDataAdapter(query_char, conn);
            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();
                lbl_char.Text = $"Всего персонажей: {cmd_count.ExecuteScalar()}";
                sda.Fill(dataTable);
                dgv_charlist.DataSource = dataTable;
                dgv_charlist.ClearSelection();
                dgv_charlist.Columns[0].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void Charlist_Load(object sender, EventArgs e)
        {
            fill_form($"select cl.id_charlist, c.name_char as 'Имя персонажа', r.rarity_name as 'Редкость', v.name_vision as 'Глаз бога', w.name_weapon as 'Тип оружия', cl.lv as 'Уровень' from char_list cl join characters c on cl.id_char = c.id_char join rarity r on c.id_rarity = r.id_rarity join vision v on c.id_vision = v.id_vision join weapon_type w on c.id_weapon = w.id_weapon where cl.id_user = {ID} order by cl.lv desc;");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (dgv_charlist.Rows.Count > 0)
            {
                DGVPrinter print = new DGVPrinter();
                print.Title = "Ваши персонажи!";
                print.PageNumbers = false;
                print.PageNumberInHeader = false;
                print.PorportionalColumns = true;
                print.HeaderCellAlignment = StringAlignment.Center;
                dgv_charlist.ClearSelection();
                print.PrintDataGridView(dgv_charlist);
            }
            else MessageBox.Show("В таблице нет ни одной записи!", "Ошибка!");
        }

        private void btn_addChar_Click(object sender, EventArgs e)
        {
            string query = $"select id_char from char_list where id_user = {ID};";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                DataBank.ID_list = "";
                while (reader.Read())
                {
                    DataBank.ID_list += reader[0].ToString() + ",";
                }
                reader.Close();
                conn.Close();
                DataBank.ID_list = DataBank.ID_list.Remove(DataBank.ID_list.Length - 1);
                Search win = new Search(ID);
                win.Owner = this;
                win.Show();
                this.Hide();
                txt_search.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            fill_form($"select cl.id_charlist, c.name_char as 'Имя персонажа', r.rarity_name as 'Редкость', v.name_vision as 'Глаз бога', w.name_weapon as 'Тип оружия', cl.lv as 'Уровень' from char_list cl join characters c on cl.id_char = c.id_char join rarity r on c.id_rarity = r.id_rarity join vision v on c.id_vision = v.id_vision join weapon_type w on c.id_weapon = w.id_weapon where cl.id_user = {ID} order by cl.lv desc;");
            txt_search.Clear();
        }

        private void dgv_charlist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            if (selectedRow > -1)
            {
                DataGridViewRow row = dgv_charlist.Rows[selectedRow];
                int id_charlist = Convert.ToInt32(row.Cells[0].Value.ToString());
                CharProfile win = new CharProfile(id_charlist);
                win.Owner = this;
                win.Show();
                this.Hide();
                txt_search.Clear();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            fill_form($"select cl.id_charlist, c.name_char as 'Имя персонажа', r.rarity_name as 'Редкость', v.name_vision as 'Глаз бога', w.name_weapon as 'Тип оружия', cl.lv as 'Уровень' from char_list cl join characters c on cl.id_char = c.id_char join rarity r on c.id_rarity = r.id_rarity join vision v on c.id_vision = v.id_vision join weapon_type w on c.id_weapon = w.id_weapon where cl.id_user = {ID} and concat(c.name_char, r.rarity_name, v.name_vision, w.name_weapon) like '%{txt_search.Text}%' order by cl.lv desc;");
        }
    }
}