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
    public partial class Welcome : Form
    {
        public MySqlConnection mySqlConnection = new MySqlConnection("Server=ali-babas-farm.tr.gl;Database=alibabas_1773;Uid=alibabas_conn;Pwd='40654065aktas';");
        User currentUser;
        public Welcome()
        {
            currentUser = new User();
            InitializeComponent();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string uName = textBoxUsername.Text;
            string pass = textBoxPassword.Text;


            if (currentUser.login(uName, pass))
            {
                this.Hide();
                Main main = new Main();
                main.setUser(currentUser);
                main.Show();
            }
            else
            {
            }

        }


        public void TextGotFocus(Object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Username or E-Mail")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(Object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "Username or E-Mail";
                tb.ForeColor = Color.LightGray;
            }
        }

        public void PassGotFocus(Object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Password")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        public void PassLostFocus(Object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "Password";
                tb.ForeColor = Color.LightGray;
            }
        }

        private void Welcome_Load_1(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection.Open();
                if (mySqlConnection.State != ConnectionState.Closed)
                {
                }
                else
                {
                    MessageBox.Show("Unable to connect!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBoxUsername.GotFocus += new EventHandler(this.TextGotFocus);
            textBoxUsername.LostFocus += new EventHandler(this.TextLostFocus);
            textBoxUsername.Text = "Username or E-Mail";
            textBoxUsername.ForeColor = Color.LightGray;
            textBoxUsername.TextAlign = HorizontalAlignment.Center;

            textBoxPassword.GotFocus += new EventHandler(this.PassGotFocus);
            textBoxPassword.LostFocus += new EventHandler(this.PassLostFocus);
        }
    }
}
