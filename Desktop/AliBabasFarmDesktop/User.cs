using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AliBabasFarmDesktop
{
    class User
    {
        int id;
        string fullName;
        string username;
        string password;
        string address;
        string email;
        int authority;  //0: admin, 1: company official, 2: distributor

        public MySqlConnection mySqlConnection = new MySqlConnection("Server=ali-babas-farm.tr.gl;Database=alibabas_1773;Uid=alibabas_conn;Pwd='40654065aktas';");

        public User()
        {
            try
            {
                mySqlConnection.Open();
                if (mySqlConnection.State != ConnectionState.Closed)
                {
                }
                else
                {
                    MessageBox.Show("Maalesef Bağlantı Yapılamadı...!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int getUser()
        {
            return id;
        }
        public int getAuthority()
        {
            return authority;
        }

        public void updateUser()
        {

        }

        public bool login(string uName, string pass)
        {
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();
            adapter = new MySqlDataAdapter($"SELECT `user_name`, `password`, `user_type` FROM `USER` WHERE `user_name` = '{uName}' AND `password` = {pass} AND `user_type` != 'distributor'", mySqlConnection);
            adapter.Fill(table);
            string query = $"SELECT * FROM `USER` WHERE `user_name` = '{uName}' AND `password` = {pass} AND `user_type` != 'distributor' ";
            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Username Or Password Are Invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                table.Clear();
                return false;
            }
            else
            {
                MessageBox.Show("Bağlantı Başarılı Bir Şekilde Gerçekleşti" + table.ToString());
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    this.id = reader.GetInt16("id");
                    this.fullName = reader.GetString("full_name");
                    this.username = reader.GetString("user_name");
                    this.password = reader.GetString("password");
                    this.address = reader.GetString("address");
                    this.email = reader.GetString("email");
                    this.authority = reader.GetInt16("authority");
                }
                table.Clear();
                return true;
            }







        }


    }


}
