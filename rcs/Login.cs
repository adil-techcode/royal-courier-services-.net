using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace rcs
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        




        private void button1_Click(object sender, EventArgs e)
        {
            textboxuname.Clear();
            textboxpw.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\Projects\New folder\db.mdf"";Integrated Security=True;Connect Timeout=30");

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Login where username = @username and password = @password   ", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", textboxuname.Text);
                cmd.Parameters.AddWithValue("@password", textboxpw.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                
                DataTable dtable =new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Show();
                    
                        
                }
                else
                {
                    MessageBox.Show("Invalid Username and Password");

                }

            }
            catch
            {
                MessageBox.Show(" database error");

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
