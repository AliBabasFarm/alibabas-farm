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
using System.Collections;

namespace AliBabasFarmDesktop
{
    public partial class Main : Form
    {
        public MySqlConnection mySqlConnection = new MySqlConnection("Server=ali-babas-farm.tr.gl;Database=alibabas_1773;Uid=alibabas_conn;Pwd='40654065aktas';");
        User currentUser;
        List<int>[] localOrderList;
        private int sortColumn = -1;
        //List<string>[] localRouteList;
        public Main()
        {
            localOrderList = new List<int>[2];
            localOrderList[0] = new List<int>();
            localOrderList[1] = new List<int>();

            //localRouteList = new List<string>[2];
            //localRouteList[0] = new List<string>();
            //localRouteList[1] = new List<string>();

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
                //reader.
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
                    localOrderList[0].Add(i);
                    localOrderList[1].Add(reader.GetInt16("id"));
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
            string query = $"SELECT * FROM `showRouteDraw2`";

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
                    //localRouteList[0].Add(items[1]);
                    //localRouteList[1].Add(items[3]);
                    i++;
                }
            }
        }

        public void RouteDrawListConfiguration()
        {
            listViewRouteDraw.View = View.Details;
            listViewRouteDraw.FullRowSelect = true;
            listViewRouteDraw.CheckBoxes = false;
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


        public void setUser(object user)
        {
            this.currentUser = (User)user;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem eachItem in this.listViewManageOrders.CheckedItems)
            {

                int Selected = Int16.Parse(eachItem.SubItems[0].Text); //directly access "eachItem
                int SelectedId = localOrderList[1].ElementAt(Selected - 1);

                string query = $"UPDATE ORDER_DETAIL INNER JOIN ORDERS ON ORDER_DETAIL.order_id = ORDERS.id INNER JOIN PRODUCT ON ORDER_DETAIL.product_id = PRODUCT.id INNER JOIN USER ON ORDERS.distributor_id = USER.id SET status = 'confirmed' WHERE ORDER_DETAIL.id = {SelectedId}";


                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                }

            }
            ManageOrdersListFill();
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

            string query3 = "SELECT USER.user_name,ORDER_DETAIL.amount FROM ORDER_DETAIL INNER JOIN ORDERS ON ORDER_DETAIL.order_id=ORDERS.id INNER JOIN USER On ORDERS.distributor_id = USER.id WHERE ORDERS.status = 'confirmed' ORDER BY USER.user_name ASC";
            //$"SELECT USER.user_name,ORDER_DETAIL.amount FROM ORDER_DETAIL INNER JOIN ORDERS ON ORDER_DETAIL.order_id=ORDERS.id INNER JOIN USER On ORDERS.distributor_id = USER.id WHERE ORDERS.status = `confirmed` ORDER BY `USER`.`user_name` ASC "
            MySqlCommand cmd3 = new MySqlCommand(query3, mySqlConnection);
            string[] username = new string[100];
            int[] first = new int[100];
            int[] second = new int[100];
            int[] third = new int[100];
            using (MySqlDataReader reader = cmd3.ExecuteReader())
            {
                int l = 0;

                while (reader.Read())
                {

                    username[l] = reader.GetString("user_name");
                    string tempusername = username[l];
                    first[l] = reader.GetInt16("amount");
                    reader.Read();
                    second[l] = reader.GetInt16("amount");
                    reader.Read();
                    third[l] = reader.GetInt16("amount");
                    l++;
                }
            }

            for (int p = 0; username[p] != null; p++)
            {
                ts.Orders.Add(new Order(username[p], first[p], second[p], third[p]));
            }
            ts.Capacity = 600;
            ts.Optimization();
            List<string> story = ts.GetStory();
            string resultList = "";
            foreach (string a in story){
                resultList += a;
                resultList += "\n";
            }
            MessageBox.Show(resultList, "Transportation Plan");
        }

        private void listViewManageOrders_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.
                sortColumn = e.Column;
                // Set the sort order to ascending by default.
                listViewManageOrders.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (listViewManageOrders.Sorting == SortOrder.Ascending)
                    listViewManageOrders.Sorting = SortOrder.Descending;
                else
                    listViewManageOrders.Sorting = SortOrder.Ascending;
            }

            // Call the sort method to manually sort.
            listViewManageOrders.Sort();
            // Set the ListViewItemSorter property to a new ListViewItemComparer
            // object.
            this.listViewManageOrders.ListViewItemSorter = new ListViewItemComparer(e.Column,
                                                              listViewManageOrders.Sorting);

        }

        private void listViewOrderHistory_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.
                sortColumn = e.Column;
                // Set the sort order to ascending by default.
                listViewOrderHistory.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (listViewOrderHistory.Sorting == SortOrder.Ascending)
                    listViewOrderHistory.Sorting = SortOrder.Descending;
                else
                    listViewOrderHistory.Sorting = SortOrder.Ascending;
            }

            // Call the sort method to manually sort.
            listViewOrderHistory.Sort();
            // Set the ListViewItemSorter property to a new ListViewItemComparer
            // object.
            this.listViewOrderHistory.ListViewItemSorter = new ListViewItemComparer(e.Column,
                                                              listViewOrderHistory.Sorting);
        }

        private void listViewManageUsers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.
                sortColumn = e.Column;
                // Set the sort order to ascending by default.
                listViewManageUsers.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (listViewManageUsers.Sorting == SortOrder.Ascending)
                    listViewManageUsers.Sorting = SortOrder.Descending;
                else
                    listViewManageUsers.Sorting = SortOrder.Ascending;
            }

            // Call the sort method to manually sort.
            listViewManageUsers.Sort();
            // Set the ListViewItemSorter property to a new ListViewItemComparer
            // object.
            this.listViewManageUsers.ListViewItemSorter = new ListViewItemComparer(e.Column,
                                                              listViewManageUsers.Sorting);
        }

        private void listViewRouteDraw_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.
                sortColumn = e.Column;
                // Set the sort order to ascending by default.
                listViewRouteDraw.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (listViewRouteDraw.Sorting == SortOrder.Ascending)
                    listViewRouteDraw.Sorting = SortOrder.Descending;
                else
                    listViewRouteDraw.Sorting = SortOrder.Ascending;
            }

            // Call the sort method to manually sort.
            listViewRouteDraw.Sort();
            // Set the ListViewItemSorter property to a new ListViewItemComparer
            // object.
            this.listViewRouteDraw.ListViewItemSorter = new ListViewItemComparer(e.Column,
                                                              listViewRouteDraw.Sorting);
        }
    }
}


public class ListViewItemComparer : IComparer
{

    private int col;
    private SortOrder order;
    public ListViewItemComparer()
    {
        col = 0;
        order = SortOrder.Ascending;
    }
    public ListViewItemComparer(int column, SortOrder order)
    {
        col = column;
        this.order = order;
    }
    public int Compare(object x, object y)
    {
        int returnVal = -1;
        returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                        ((ListViewItem)y).SubItems[col].Text);
        // Determine whether the sort order is descending.
        if (order == SortOrder.Descending)
            // Invert the value returned by String.Compare.
            returnVal *= -1;
        return returnVal;
    }


}