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
using Z.Expressions;

namespace rcs
{
    public partial class home : Form
    {

     
        public home()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\Projects\New folder\db.mdf"";Integrated Security=True;Connect Timeout=30");
      


        private void Index()
        {
            conn.Open();
            string query = "select * from  Transactions";
            SqlDataAdapter sda = new SqlDataAdapter(query,conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();

        }

        private double fare(double km,int weight)
        {
          
            double dis = km;
            double far_dis = dis * 2; // Per km per is 2
            double initial_fare = far_dis * weight / 2;
            double sur_charge = initial_fare / 4;
            double finial_fare = initial_fare + sur_charge;
            string route = comboBoxOrigin.Text + "-" + comboBoxDesti.Text;
            textBoxroute.Text = route;
            return finial_fare;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
            Index();
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            string origin = comboBoxOrigin.Text;
            string desti = comboBoxDesti.Text;
            int weight = Convert.ToInt32(textBoxweight.Text);




            if (origin == "APE")
            {
                if (desti == "BWP")
                {
                    string price = Convert.ToString(Math.Round(fare(50, weight)));
                    textBoxprice.Text = price;
                }
                else if (desti == "MLT")
                {

                    string price = Convert.ToString(Math.Round(fare(119, weight)));
                    textBoxprice.Text = price;
                }
                else if (desti == "LHR")
                {

                    string price = Convert.ToString(Math.Round(fare(400, weight)));
                    textBoxprice.Text = price;
                }
                else if (desti == "DGK")
                {
                    string price = Convert.ToString(Math.Round(fare(117, weight)));
                    textBoxprice.Text = price;
                }
                else
                {
                    textBoxprice.Text = "Not Found";
                }
            }



            else if (origin == "BWP")
            {

                if (desti == "APE")
                {
                    string price = Convert.ToString(Math.Round(fare(50, weight)));
                    textBoxprice.Text = price;
                }
                else if (desti == "MLT")
                {
                    string price = Convert.ToString(Math.Round(fare(117, weight)));
                    textBoxprice.Text = price;
                }
                else if (desti == "LHR")
                {
                    string price = Convert.ToString(Math.Round(fare(350, weight)));
                    textBoxprice.Text = price;
                }
                else if (desti == "DGK")
                {
                    string price = Convert.ToString(Math.Round(fare(123, weight)));
                    textBoxprice.Text = price;
                }
                else
                {
                    textBoxprice.Text = "Not Found";
                }



            }
            else if (origin == "MLT")
            {


                if (desti == "APE")
                {
                    string price = Convert.ToString(Math.Round(fare(119, weight)));
                    textBoxprice.Text = price;
                }
                else if (desti == "BWP")
                {
                    string price = Convert.ToString(Math.Round(fare(90, weight)));
                    textBoxprice.Text = price;
                }
                else if (desti == "LHR")
                {
                    string price = Convert.ToString(Math.Round(fare(313, weight)));
                    textBoxprice.Text = price;
                }
                else if (desti == "DGK")
                {
                    string price = Convert.ToString(Math.Round(fare(81, weight)));
                    textBoxprice.Text = price;
                }
                else
                {
                    textBoxprice.Text = "Not Found";
                }



            }
            else if (origin == "LHR")
            {

                if (desti == "APE")
                {
                    string price = Convert.ToString(Math.Round(fare(400, weight)));
                    textBoxprice.Text = price;
                }
                else if (desti == "BWP")
                {
                    string price = Convert.ToString(Math.Round(fare(350, weight)));
                    textBoxprice.Text = price;
                }
                else if (desti == "MLT")
                {
                    string price = Convert.ToString(Math.Round(fare(313, weight)));
                    textBoxprice.Text = price;
                }
                else if (desti == "DGK")
                {
                    string price = Convert.ToString(Math.Round(fare(390, weight)));
                    textBoxprice.Text = price;
                }
                else
                {
                    textBoxprice.Text = "Not Found";
                }

            }
            else if (origin == "DGK")
            {

                if (desti == "APE")
                {
                    string price = Convert.ToString(Math.Round(fare(117, weight)));
                    textBoxprice.Text = price;
                }
                else if (desti == "BWP")
                {
                    string price = Convert.ToString(Math.Round(fare(123, weight)));
                    textBoxprice.Text = price;
                }
                else if (desti == "MLT")
                {
                    string price = Convert.ToString(Math.Round(fare(81, weight)));
                    textBoxprice.Text = price;
                }
                else if (desti == "LHR")
                {
                    string price = Convert.ToString(Math.Round(fare(390, weight)));
                    textBoxprice.Text = price;
                }
                else
                {
                    textBoxprice.Text = "Not Found";
                }



            }
            else
            {
                textBoxprice.Text = "Not Found";

            }


            comboBoxDesti.Text = "";
            comboBoxOrigin.Text = "";
            textBoxweight.Clear();


            string  NewGuid = System.Guid.NewGuid().ToString().Replace("-","").ToUpper();
            string unid = "";

            for(int i=0; i<10; i++)
            {
                unid += NewGuid[i];
            }

            textBoxid.Text = unid;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Transactions VALUES (@Id,@Date,@Name,@Parcel,@Route,@Price)",conn);
            cmd.CommandType=CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", textBoxid.Text);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Name", textBoxname.Text);
            cmd.Parameters.AddWithValue("@Parcel", textBoxparcel.Text);
            cmd.Parameters.AddWithValue("@Route", textBoxroute.Text);
            cmd.Parameters.AddWithValue("@Price",textBoxprice.Text);
            if(conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd.ExecuteNonQuery();
            conn.Close();

            textBoxid.Clear();
            textBoxname.Clear();
            textBoxparcel.Clear();
            textBoxprice.Clear();
            textBoxroute.Clear();
            dateTimePicker1.Text = "";

           
            Index();


        }
        public string id = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            textBoxid.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            textBoxname.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            textBoxparcel.Text = dataGridView1.Rows[e.RowIndex].Cells["Parcel"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["Date"].Value.ToString();
            textBoxprice.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            textBoxroute.Text = dataGridView1.Rows[e.RowIndex].Cells["Route"].Value.ToString();





        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Transactions SET Name=@Name,Parcel=@Parcel,Date=@Date,Price=@Price,Route=@Route WHERE Id=@id", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Name", textBoxname.Text);
            cmd.Parameters.AddWithValue("@Parcel", textBoxparcel.Text);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Price", textBoxprice.Text);
            cmd.Parameters.AddWithValue("@Id", textBoxid.Text);
            cmd.Parameters.AddWithValue("@Route", textBoxroute.Text);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd.ExecuteNonQuery();
            conn.Close();

            
            Index();

            textBoxid.Clear();
            textBoxname.Clear();
            textBoxparcel.Clear();
            textBoxprice.Clear();
            textBoxroute.Clear();
            dateTimePicker1.Text = "";
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Transactions WHERE Id=@id", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", textBoxid.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


            Index();
            MessageBox.Show("Deleted");
            textBoxid.Clear();
            textBoxname.Clear();
            textBoxparcel.Clear();
            textBoxprice.Clear();
            textBoxroute.Clear();
            dateTimePicker1.Text = "";

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {

            textBoxid.Clear();
            textBoxname.Clear();
            textBoxparcel.Clear();
            textBoxprice.Clear();
            textBoxroute.Clear();
            dateTimePicker1.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
