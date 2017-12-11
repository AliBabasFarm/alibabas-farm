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
using Direction_optimized;

namespace AliBabasFarmDesktop
{
    public partial class Main : Form
    {
        public MySqlConnection mySqlConnection = new MySqlConnection("Server=ali-babas-farm.tr.gl;Database=alibabas_1773;Uid=alibabas_conn;Pwd='40654065aktas';");
        User currentUser;
        public Main()
        {
            InitializeComponent();
            ManageOrdersListConfiguration();
            OrderHistoryListConfiguration();
            ManageUsersListConfiguration();
            RouteDrawListConfiguration();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
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

            if (currentUser.getAuthority() == 1)
            {
                tabControl.TabPages.Remove(tabPageManageUsers);
            }

            //call which index selected.
            tabControl_TabIndexChanged(sender, e);

        }

        private void tabControl_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                ManageOrdersListFill();
            }
            else if (tabControl.SelectedIndex == 1)
            {
                OrderHistoryListFill();
            }
            else if (tabControl.SelectedIndex == 2)
            {
                if (currentUser.getAuthority() == 1)
                {
                    RouteDrawListFill();
                }
                else
                {

                    ManageUsersListFill();
                }
            }
            else if (tabControl.SelectedIndex == 3)
            {
                RouteDrawListFill();
            }
        }

        public void ManageOrdersListFill()
        {
            listViewManageOrders.Items.Clear();

            string query = $"SELECT * FROM `showManageOrder`";

            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                int i = 1;
                while (reader.Read())
                {
                    string[] items = new string[6];

                    items[0] = i.ToString();
                    items[1] = reader.GetString("full_name");
                    items[2] = reader.GetString("name");
                    items[3] = reader.GetString("amount");
                    items[4] = reader.GetString("status");
                    items[5] = reader.GetString("create_date");
                    listViewManageOrders.Items.Add(new ListViewItem(items));
                    i++;
                }
            }
        }

        public void ManageOrdersListConfiguration()
        {
            listViewManageOrders.View = View.Details;
            listViewManageOrders.FullRowSelect = true;
            listViewManageOrders.CheckBoxes = true;
            listViewManageOrders.Columns.Add("Nr.", 20);
            listViewManageOrders.Columns.Add("Distributor", 75);
            listViewManageOrders.Columns.Add("Product", 75);
            listViewManageOrders.Columns.Add("Amount", 75);
            listViewManageOrders.Columns.Add("Status", 75);
            listViewManageOrders.Columns.Add("Date", 75);
        }

        public void OrderHistoryListFill()
        {
            listViewOrderHistory.Items.Clear();
            string query = $"SELECT * FROM `showOrderHistory`";

            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                int i = 1;
                while (reader.Read())
                {
                    string[] items = new string[6];

                    items[0] = i.ToString();
                    items[1] = reader.GetString("full_name");
                    items[2] = reader.GetString("name");
                    items[3] = reader.GetString("amount");
                    items[4] = reader.GetString("status");
                    items[5] = reader.GetString("create_date");
                    listViewOrderHistory.Items.Add(new ListViewItem(items));
                    i++;
                }
            }
        }

        public void OrderHistoryListConfiguration()
        {
            listViewOrderHistory.View = View.Details;
            listViewOrderHistory.FullRowSelect = true;
            listViewOrderHistory.Columns.Add("Nr.", 20);
            listViewOrderHistory.Columns.Add("Distributor", 75);
            listViewOrderHistory.Columns.Add("Product", 75);
            listViewOrderHistory.Columns.Add("Amount", 75);
            listViewOrderHistory.Columns.Add("Status", 75);
            listViewOrderHistory.Columns.Add("Date", 75);
        }

        public void ManageUsersListFill()
        {
            listViewManageUsers.Items.Clear();
            string query = $"SELECT * FROM `manageUser`";

            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                int i = 1;
                while (reader.Read())
                {
                    string[] items = new string[7];

                    items[0] = i.ToString();
                    items[1] = reader.GetString("full_name");
                    items[2] = reader.GetString("user_name");
                    items[3] = reader.GetString("password");
                    items[4] = reader.GetString("address");
                    items[5] = reader.GetString("email");
                    items[6] = reader.GetString("user_type");
                    listViewManageUsers.Items.Add(new ListViewItem(items));
                    i++;
                }
            }
        }

        public void ManageUsersListConfiguration()
        {
            listViewManageUsers.View = View.Details;
            listViewManageUsers.FullRowSelect = true;
            listViewManageUsers.Columns.Add("Nr.", 20);
            listViewManageUsers.Columns.Add("Full Name", 75);
            listViewManageUsers.Columns.Add("Username", 75);
            listViewManageUsers.Columns.Add("Password", 75);
            listViewManageUsers.Columns.Add("Address", 75);
            listViewManageUsers.Columns.Add("E-Mail", 75);
            listViewManageUsers.Columns.Add("Type", 75);
        }

        public void RouteDrawListFill()
        {
            listViewRouteDraw.Items.Clear();
            string query = $"SELECT * FROM `showRouteDraw`";

            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                int i = 1;
                while (reader.Read())
                {
                    string[] items = new string[6];

                    items[0] = i.ToString();
                    items[1] = reader.GetString("full_name");
                    items[2] = reader.GetString("name");
                    items[3] = reader.GetString("amount");
                    items[4] = reader.GetString("status");
                    items[5] = reader.GetString("create_date");
                    listViewRouteDraw.Items.Add(new ListViewItem(items));
                    i++;
                }
            }
        }

        public void RouteDrawListConfiguration()
        {
            listViewRouteDraw.View = View.Details;
            listViewRouteDraw.FullRowSelect = true;
            listViewRouteDraw.CheckBoxes = true;
            listViewRouteDraw.Columns.Add("Nr.", 20);
            listViewRouteDraw.Columns.Add("Distributor", 75);
            listViewRouteDraw.Columns.Add("Product", 75);
            listViewRouteDraw.Columns.Add("Amount", 75);
            listViewRouteDraw.Columns.Add("Status", 75);
            listViewRouteDraw.Columns.Add("Date", 75);
        }

        private void buttonSelectAllMO_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewManageOrders.Items.Count; i++)
            {
                listViewManageOrders.Items[i].Checked = true;
            }
        }

        private void buttonDeselectAllMO_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewManageOrders.Items.Count; i++)
            {
                listViewManageOrders.Items[i].Checked = false;
            }
        }

        private void buttonSelectAllRD_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewRouteDraw.Items.Count; i++)
            {
                listViewRouteDraw.Items[i].Checked = true;
            }
        }

        private void buttonDeselectAllRD_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewRouteDraw.Items.Count; i++)
            {
                listViewRouteDraw.Items[i].Checked = false;
            }
        }

        public void setUser(object user)
        {
            this.currentUser = (User)user;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            var checkedItems = this.listViewManageOrders.CheckedItems;

            string query = $"SELECT * FROM `showManageOrder`";

            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

            }
        }

        private void buttonDrawRoute_Click(object sender, EventArgs e)
        {
            string[] point1 = new string[100];
            string[] point2 = new string[100];
            int[] distance = new int[100];
            string[] poolpoints = new string[8];

            string query = $"SELECT * FROM `ROAD`";

            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            int j = 0;
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                for (j = 0; reader.Read(); j++)
                {
                    point1[j] = reader.GetString("point1");
                    point2[j] = reader.GetString("point2");
                    distance[j] = reader.GetInt16("distance");
                }
            }


            //////////////////////////////////////////////////////

            string query2 = $"SELECT * FROM `POOLPOINT`";

            MySqlCommand cmd2 = new MySqlCommand(query2, mySqlConnection);
            int i = 0;
            using (MySqlDataReader reader = cmd2.ExecuteReader())
            {

                for (i = 0; reader.Read(); i++)
                {
                    poolpoints[i] = reader.GetString("name");
                }
            }



            TransportationOptimization ts = new TransportationOptimization();

            for (int k = 0; k < i; k++)
            {
                ts.Cities.Add(poolpoints[k]);
            }

            for (int l = 0; l < j; l++)
            {
                ts.Map.Add(new Edge(point1[l], point2[l], distance[l]));
            }



            ts.Orders.Add(new Order("D", 50, 50, 50));
            ts.Orders.Add(new Order("E", 50, 50, 50));
            ts.Orders.Add(new Order("F", 50, 50, 50));
            ts.Orders.Add(new Order("G", 50, 50, 50));
            ts.Orders.Add(new Order("A", 50, 50, 50));



            //ts.Map.Add(new Edge("A", "B", 15));
            //ts.Map.Add(new Edge("B", "C", 10));
            //ts.Map.Add(new Edge("C", "H", 20));

            //ts.Map.Add(new Edge("F", "E", 12));
            //ts.Map.Add(new Edge("A", "D", 20));
            //ts.Map.Add(new Edge("A", "F", 14));

            //ts.Map.Add(new Edge("F", "B", 8));
            //ts.Map.Add(new Edge("B", "E", 13));
            //ts.Map.Add(new Edge("E", "G", 14));

            //ts.Map.Add(new Edge("C", "G", 9));
            //ts.Map.Add(new Edge("G", "H", 15));
            //ts.Map.Add(new Edge("C", "D", 5));

            //ts.Map.Add(new Edge("E", "C", 16));
            //ts.Map.Add(new Edge("E", "H", 25));
            //ts.Map.Add(new Edge("A", "C", 18));
            //ts.Map.Add(new Edge("D", "H", 16));

            ts.Optimization();
            MessageBox.Show("Bitti");
            List<string> story =
                ts.GetStory();
            MessageBox.Show("Bitti");
        }

        public void PoolpointFill(string[] poolpoints)
        {
            string query = $"SELECT * FROM `POOLPOINT`";

            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                for (int j = 0; reader.Read(); j++)
                {
                    poolpoints[j] = reader.GetString("name");
                }
            }
        }

        public void RoadFill(string[] point1, string[] point2, int[] distance)
        {
            string query = $"SELECT * FROM `ROAD`";

            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                for (int j = 0; reader.Read(); j++)
                {
                    point1[j] = reader.GetString("point1");
                    point2[j] = reader.GetString("point2");
                    distance[j] = reader.GetInt16("distance");
                }
            }
        }



    }
}
