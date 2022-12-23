using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rcs
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }


        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private double fare(double km, int weight)
        {
            string origin = comboboxorigin.Text;
            string desti = comboboxdest.Text;
           

            double dis = km;
            labeldistance.Text = $"Total Distance From {origin} to {desti} = {km}km ";
            double far_dis = dis * 2; // Per km per is 2
            double initial_fare = far_dis * weight / 2;
            labelfare.Text = $"Fare  : {initial_fare} ";
            double sur_charge = initial_fare / 4;
            labelsurcharge.Text = $"Sur Charge : {sur_charge}";
            double finial_fare = initial_fare + sur_charge;
            labeltotal.Text = $"Total :{finial_fare} ";
            labeldate.Text = dateTimePicker1.Text;
            return finial_fare;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string origin = comboboxorigin.Text;
            string desti = comboboxdest.Text;
            int weight = Convert.ToInt32(textBoxweight.Text);


            if (origin == "APE")
            {
                if (desti == "BWP")
                {
                    string price = Convert.ToString(Math.Round(fare(50, weight)));
                   
                }
                else if (desti == "MLT")
                {

                    string price = Convert.ToString(Math.Round(fare(119, weight)));
                 
                }
                else if (desti == "LHR")
                {

                    string price = Convert.ToString(Math.Round(fare(400, weight)));
                  
                }
                else if (desti == "DGK")
                {
                    string price = Convert.ToString(Math.Round(fare(117, weight)));
                   
                }
                else
                {
                    labeldistance.Text = "Not Found";
                }
            }



            else if (origin == "BWP")
            {

                if (desti == "APE")
                {
                    string price = Convert.ToString(Math.Round(fare(50, weight)));
                  
                }
                else if (desti == "MLT")
                {
                    string price = Convert.ToString(Math.Round(fare(117, weight)));
                    
                }
                else if (desti == "LHR")
                {
                    string price = Convert.ToString(Math.Round(fare(350, weight)));
                 
                }
                else if (desti == "DGK")
                {
                    string price = Convert.ToString(Math.Round(fare(123, weight)));
                   
                }
                else
                {
                    labeldistance.Text = "Not Found";
                }



            }
            else if (origin == "MLT")
            {


                if (desti == "APE")
                {
                    string price = Convert.ToString(Math.Round(fare(119, weight)));
                    
                }
                else if (desti == "BWP")
                {
                    string price = Convert.ToString(Math.Round(fare(90, weight)));
                    
                }
                else if (desti == "LHR")
                {
                    string price = Convert.ToString(Math.Round(fare(313, weight)));
                    
                }
                else if (desti == "DGK")
                {
                    string price = Convert.ToString(Math.Round(fare(81, weight)));
                   
                }
                else
                {
                    labeldistance.Text = "Not Found";
                }



            }
            else if (origin == "LHR")
            {

                if (desti == "APE")
                {
                    string price = Convert.ToString(Math.Round(fare(400, weight)));
                  
                }
                else if (desti == "BWP")
                {
                    string price = Convert.ToString(Math.Round(fare(350, weight)));
                    
                }
                else if (desti == "MLT")
                {
                    string price = Convert.ToString(Math.Round(fare(313, weight)));
                   
                }
                else if (desti == "DGK")
                {
                    string price = Convert.ToString(Math.Round(fare(390, weight)));
                   
                }
                else
                {
                    labeldistance.Text = "Not Found";
                }

            }
            else if (origin == "DGK")
            {

                if (desti == "APE")
                {
                    string price = Convert.ToString(Math.Round(fare(117, weight)));

                }
                else if (desti == "BWP")
                {
                    string price = Convert.ToString(Math.Round(fare(123, weight)));

                }
                else if (desti == "MLT")
                {
                    string price = Convert.ToString(Math.Round(fare(81, weight)));

                }
                else if (desti == "LHR")
                {
                    string price = Convert.ToString(Math.Round(fare(390, weight)));
                }
                else
                {
                    labeldistance.Text = "Not Found";
                }



            }
            else
            {
                labeldistance.Text = "Not Found";

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
