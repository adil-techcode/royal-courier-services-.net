using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace rcs
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\Projects\New folder\db.mdf"";Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Transactions where Id = @Id ", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", textBox1.Text);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
