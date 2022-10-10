using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace genshin_char
{
    public partial class Search : Form
    {
        public int ID;
        public string pyro, electro, hydro, cryo, anemo, geo, dendro;
        public string sword, claymore, bow, spear, catalyst;
        public string r_4, r_5;

        public Search(int id_user)
        {
            InitializeComponent();

            ID = id_user;
        }

        private void check_pyro_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pyro.Checked == true) pyro = "1";
            else pyro = "";
        }

        private void check_electro_CheckedChanged(object sender, EventArgs e)
        {
            if (check_electro.Checked == true) electro = "2";
            else electro = "";
        }

        private void check_hydro_CheckedChanged(object sender, EventArgs e)
        {
            if (check_hydro.Checked == true) hydro = "3";
            else hydro = "";
        }

        private void check_cryo_CheckedChanged(object sender, EventArgs e)
        {
            if (check_cryo.Checked == true) cryo = "4";
            else cryo = "";
        }

        private void check_anemo_CheckedChanged(object sender, EventArgs e)
        {
            if (check_anemo.Checked == true) anemo = "5";
            else anemo = "";
        }

        private void check_geo_CheckedChanged(object sender, EventArgs e)
        {
            if (check_geo.Checked == true) geo = "6";
            else geo = "";
        }

        private void check_dendro_CheckedChanged(object sender, EventArgs e)
        {
            if (check_dendro.Checked == true) dendro = "7";
            else dendro = "";
        }

        private void check_sword_CheckedChanged(object sender, EventArgs e)
        {
            if (check_sword.Checked == true) sword = "1";
            else sword = "";
        }

        private void check_claymore_CheckedChanged(object sender, EventArgs e)
        {
            if (check_claymore.Checked == true) claymore = "2";
            else claymore = "";
        }

        private void check_bow_CheckedChanged(object sender, EventArgs e)
        {
            if (check_bow.Checked == true) bow = "3";
            else bow = "";
        }

        private void check_spear_CheckedChanged(object sender, EventArgs e)
        {
            if (check_spear.Checked == true) spear = "4";
            else spear = "";
        }

        private void check_catalyst_CheckedChanged(object sender, EventArgs e)
        {
            if (check_catalyst.Checked == true) catalyst = "5";
            else catalyst = "";
        }

        private void check_4_CheckedChanged(object sender, EventArgs e)
        {
            if (check_4.Checked == true) r_4 = "1";
            else r_4 = "";
        }

        private void check_5_CheckedChanged(object sender, EventArgs e)
        {
            if (check_5.Checked == true) r_5 = "2";
            else r_5 = "";
        }

        private void fill_form(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();
                sda.Fill(dataTable);
                dgv_chars.DataSource = dataTable;
                dgv_chars.ClearSelection();
                dgv_chars.Columns[0].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            fill_form($"select c.id_char, c.name_char as 'Имя персонажа', r.rarity_name as 'Редкость', v.name_vision as 'Глаз бога', w.name_weapon as 'Тип оружия' from characters c join rarity r on c.id_rarity = r.id_rarity join vision v on c.id_vision = v.id_vision join weapon_type w on c.id_weapon = w.id_weapon where c.id_char not in ({DataBank.ID_list}) order by c.name_char asc;");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string where = "", name_char = "", vision = "", weapon = "", rarity = "";

            if (txt_name.Text != "") name_char = $"and c.name_char like '%{txt_name.Text}%'";

            string vision_all = pyro + electro + hydro + cryo + anemo + geo + dendro;
            if (vision_all != "")
            {
                string result = string.Join<char>(",", vision_all);

                vision = $" and c.id_vision in ({result})";
            }

            string weapon_all = sword + claymore + bow + spear + catalyst;
            if (weapon_all != "")
            {
                string result = string.Join<char>(",", weapon_all);

                weapon = $" and c.id_weapon in ({result})";
            }

            string rarity_all = r_4 + r_5;
            if (rarity_all != "")
            {
                string result = string.Join<char>(",", rarity_all);

                rarity = $" and c.id_rarity in ({result})";
            }

            if ((name_char != "") || (vision != "") || (weapon != "") || (rarity != "")) where = name_char + vision + weapon + rarity;
            fill_form($"select c.id_char, c.name_char as 'Имя персонажа', r.rarity_name as 'Редкость', v.name_vision as 'Глаз бога', w.name_weapon as 'Тип оружия' from characters c join rarity r on c.id_rarity = r.id_rarity join vision v on c.id_vision = v.id_vision join weapon_type w on c.id_weapon = w.id_weapon where c.id_char not in ({DataBank.ID_list}){where} order by c.name_char asc;");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgv_chars_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;

            if (selectedRow > -1)
            {
                DataGridViewRow row = dgv_chars.Rows[selectedRow];
                int id_char = Convert.ToInt32(row.Cells[0].Value);
                AddChar win = new AddChar(ID, id_char);
                win.Owner = this;
                win.Show();
                this.Hide();
                clear();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void clear()
        {
            txt_name.Clear();
            check_pyro.Checked = false;
            check_electro.Checked = false;
            check_hydro.Checked = false;
            check_cryo.Checked = false;
            check_anemo.Checked = false;
            check_geo.Checked = false;
            check_dendro.Checked = false;
            check_sword.Checked = false;
            check_claymore.Checked = false;
            check_bow.Checked = false;
            check_spear.Checked = false;
            check_catalyst.Checked = false;
            check_4.Checked = false;
            check_5.Checked = false;
            fill_form($"select c.id_char, c.name_char as 'Имя персонажа', r.rarity_name as 'Редкость', v.name_vision as 'Глаз бога', w.name_weapon as 'Тип оружия' from characters c join rarity r on c.id_rarity = r.id_rarity join vision v on c.id_vision = v.id_vision join weapon_type w on c.id_weapon = w.id_weapon where c.id_char not in ({DataBank.ID_list}) order by c.name_char asc;");
        }
    }
}