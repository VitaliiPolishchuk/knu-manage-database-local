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

namespace AirportDB
{
    public partial class FrmFlight : Form
    {

        public int com_id;

        public string connection_string = @"Data Source=LAPTOP-GV54J1BA\SQLEXPRESS;Initial Catalog = Airport; Integrated Security = True";

        public bool changed;
        string name_cat;
        public FrmFlight()
        {
            InitializeComponent();
            changed = false;
        }

        public FrmFlight(int cat_id, string cat_name)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ", cat_name);

            com_id = cat_id;
            name_cat = cat_name;
            //find_flight();
            changed = false;
            flightByCompanyIdTableAdapter.Fill(airportDataSet1.FlightByCompanyId, com_id);
            cb_FlightAdd_set();
            cb_FlightDelete_set();
        }

        private void cb_FlightAdd_set()
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = connection_string;
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconn;
            sqlcommand.CommandText = "SELECT * FROM Flight " +
                                        " WHERE Flight.FlightId NOT IN ( SELECT Flight_Company.FlightId FROM Flight_Company WHERE Flight_Company.CompanyId = " + com_id + " );"; 
            SqlDataReader sqldr;
            sqlconn.Open();
            sqldr = sqlcommand.ExecuteReader();
            comBoxFlightAdd.Items.Clear();
            while (sqldr.Read())
            {
                comBoxFlightAdd.Items.Add(new Store_Plane(Convert.ToInt32(sqldr[0]), sqldr[1].ToString()));
            }
            sqldr.Close();
            sqlconn.Close();
        }


        private void cb_FlightDelete_set()
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = connection_string;
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconn;
            sqlcommand.CommandText = "SELECT * FROM Flight INNER JOIN Flight_Company ON Flight_Company.FlightId = Flight.FlightId " +
                                    "WHERE Flight_Company.CompanyId =" + com_id;
            SqlDataReader sqldr;
            sqlconn.Open();
            sqldr = sqlcommand.ExecuteReader();
            comBoxFlightDelete.Items.Clear();
            while (sqldr.Read())
            {
                comBoxFlightDelete.Items.Add(new Store_Plane(Convert.ToInt32(sqldr[0]), sqldr[1].ToString()));
            }
            sqldr.Close();
            sqlconn.Close();
        }

        private void cb_eventFlightAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hValueA = ((Store_Plane)comBoxFlightAdd.SelectedItem).idF;
        }

        private void cb_eventFlightDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hValueA = ((Store_Plane)comBoxFlightDelete.SelectedItem).idF;
        }

        private void button_AddFlight_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = connection_string;
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlconn;
                int flight_id = ((Store_Plane)comBoxFlightAdd.SelectedItem).idF;
                sqlcommand.CommandText = "SELECT COUNT(*) FROM Flight_Company WHERE Flight_Company.CompanyId=" + com_id + " AND Flight_Company.FlightId=" + flight_id;
                SqlDataReader sqldr;
                sqlconn.Open();
                sqldr = sqlcommand.ExecuteReader();
                sqldr.Read();
                int idR = Convert.ToInt32(sqldr[0]);
                sqldr.Close();
                if (idR != 0)
                {
                    MessageBox.Show("Такий політ вже існує!", "Помилка");
                }
                else
                {
                    sqlcommand.CommandText = "INSERT INTO Flight_Company (Flight_Company.CompanyId, Flight_Company.FlightId) VALUES (" + com_id + ", " + flight_id + ")";
                    sqlcommand.ExecuteNonQuery();
                    flightByCompanyIdTableAdapter.Fill(this.airportDataSet1.FlightByCompanyId, com_id);
                    cb_FlightAdd_set();
                    cb_FlightDelete_set();
                    comBoxFlightAdd.Text = "";
                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void button_DeleteFlight_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = connection_string;
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlconn;
                int flight_id = ((Store_Plane)comBoxFlightDelete.SelectedItem).idF;
                sqlcommand.CommandText = "SELECT COUNT(*) FROM Flight_Company WHERE Flight_Company.CompanyId = " + com_id + " AND Flight_Company.FlightId=" + flight_id;
                SqlDataReader sqldr;
                sqlconn.Open();
                sqldr = sqlcommand.ExecuteReader();
                sqldr.Read();
                int idR = Convert.ToInt32(sqldr[0]);
                sqldr.Close();
                if (idR == 0)
                {
                    MessageBox.Show("Такого польоту не існує!", "Помилка");
                }
                else
                {
                    sqlcommand.CommandText = "DELETE FROM Flight_Company WHERE Flight_Company.CompanyId = " + com_id + "AND Flight_Company.FlightId = " + flight_id;
                    sqlcommand.ExecuteNonQuery();
                    flightByCompanyIdTableAdapter.Fill(this.airportDataSet1.FlightByCompanyId, com_id);
                    cb_FlightAdd_set();
                    cb_FlightDelete_set();
                    comBoxFlightDelete.Text = "";
                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }


        private void dGVCompany_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (false)
            {
                MessageBox.Show("Must save", "Show Category");
            }
            else
            {
                try
                {
                    int id = (int)dataGridViewFlight.CurrentRow.Cells["flightIdDataGridViewTextBoxColumn"].Value;
                    string info = (string)dataGridViewFlight.CurrentRow.Cells["infoDataGridViewTextBoxColumn"].Value;

                    FrmTicketAndPlane flight = new FrmTicketAndPlane(id, info);

                    flight.ShowDialog(this);

                    flight.Dispose();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(textBoxPrice.Text == "" && textBoxPlane.Text == "")
            {
                flightByCompanyIdTableAdapter.Fill(airportDataSet1.FlightByCompanyId, com_id);
            }
            else if(textBoxPrice.Text == "" && textBoxPlane.Text != "")
            {
                flightByCompanyIdTableAdapter.FillByPlane(airportDataSet1.FlightByCompanyId, com_id, textBoxPlane.Text);
            }
            else if(textBoxPrice.Text != "" && textBoxPlane.Text == "")
            {
                flightByCompanyIdTableAdapter.FillByTicket(airportDataSet1.FlightByCompanyId, com_id, Convert.ToInt32( textBoxPrice.Text));
            }
            else
            {
                flightByCompanyIdTableAdapter.FillByPlaneTicket(airportDataSet1.FlightByCompanyId, com_id, textBoxPlane.Text, Convert.ToInt32(textBoxPrice.Text));
            }
        }
    }

    public class Store_Plane
    {
        public int idF { get; set; }
        public string infoF { get; set; }
        public Store_Plane(int id, string info)
        {
            idF = id;
            infoF = info;
        }
        public override string ToString()
        {
            return infoF;
        }
    }
}