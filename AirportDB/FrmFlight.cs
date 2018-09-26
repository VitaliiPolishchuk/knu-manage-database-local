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
using System.Data.Entity;

namespace AirportDB
{
    public partial class FrmFlight : Form
    {

        public int com_id;

        private LibraryData.AirportEntities flight_cxt;

        public string connection_string = @"Data Source=LAPTOP-GV54J1BA\SQLEXPRESS;Initial Catalog = Airport; Integrated Security = True";

        public bool changed;
        string name_cat;
        public FrmFlight()
        {
            InitializeComponent();
            changed = false;
            flight_cxt = new LibraryData.AirportEntities();
        }

        public FrmFlight(int cat_id, string cat_name)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ", cat_name);
            flight_cxt = new LibraryData.AirportEntities();
            com_id = cat_id;
            name_cat = cat_name;
            //find_flight();
            changed = false;
            
            var query = (from flight in flight_cxt.Flight
                         join flight_company in flight_cxt.Flight_Company on flight.FlightId equals flight_company.FlightId
                         join company in flight_cxt.Company on flight_company.CompanyId equals company.CompanyId
                         where company.CompanyId == com_id
                         select flight);
            query.Load();
            this.flightBindingSource.DataSource = flight_cxt.Flight.Local.ToBindingList();

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

                    flight_cxt.Dispose();

                    flight_cxt = new LibraryData.AirportEntities();

                    var query = (from flight in flight_cxt.Flight
                                 join flight_company in flight_cxt.Flight_Company on flight.FlightId equals flight_company.FlightId
                                 join company in flight_cxt.Company on flight_company.CompanyId equals company.CompanyId
                                 where company.CompanyId == com_id
                                 select flight);
                    query.Load();

                    this.flightBindingSource.DataSource = flight_cxt.Flight.Local.ToBindingList();

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

                    flight_cxt.Dispose();

                    flight_cxt = new LibraryData.AirportEntities();

                    var query = (from flight in flight_cxt.Flight
                                 join flight_company in flight_cxt.Flight_Company on flight.FlightId equals flight_company.FlightId
                                 join company in flight_cxt.Company on flight_company.CompanyId equals company.CompanyId
                                 where company.CompanyId == com_id
                                 select flight);
                    query.Load();

                    this.flightBindingSource.DataSource = flight_cxt.Flight.Local.ToBindingList();

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
            var NotSavingItem = flight_cxt.ChangeTracker.Entries<LibraryData.Flight>().Where(a => a.State != EntityState.Unchanged).ToList();

            if(NotSavingItem.Count != 0)
            {
                MessageBox.Show("Must save", "Show Category");
            }
            else
            {
                flight_cxt.Dispose();

                flight_cxt = new LibraryData.AirportEntities();

                IQueryable<LibraryData.Flight> query;

                if (!string.IsNullOrWhiteSpace(textBoxPlane.Text) && !string.IsNullOrWhiteSpace(textBoxPrice.Text))
                {
                    int price = Convert.ToInt32(textBoxPrice.Text);

                    query = (from flight in flight_cxt.Flight
                             join flight_company in flight_cxt.Flight_Company on flight.FlightId equals flight_company.FlightId
                             join company in flight_cxt.Company on flight_company.CompanyId equals company.CompanyId

                             join flight_ticket in flight_cxt.Flight_Ticket on flight.FlightId equals flight_ticket.FlightId
                             join ticket in flight_cxt.Ticket on flight_ticket.TicketId equals ticket.TicketId

                             join flight_plane in flight_cxt.Flight_Plane on flight.FlightId equals flight_plane.FlightId
                             join plane in flight_cxt.Plane on flight_plane.PlaneId equals plane.PlaneId

                             where company.CompanyId == com_id && plane.Type == textBoxPlane.Text && ticket.Price <= price
                             select flight);
                }
                else if (!string.IsNullOrWhiteSpace(textBoxPlane.Text))
                {
                    query = (from flight in flight_cxt.Flight
                             join flight_company in flight_cxt.Flight_Company on flight.FlightId equals flight_company.FlightId
                             join company in flight_cxt.Company on flight_company.CompanyId equals company.CompanyId

                             join flight_plane in flight_cxt.Flight_Plane on flight.FlightId equals flight_plane.FlightId
                             join plane in flight_cxt.Plane on flight_plane.PlaneId equals plane.PlaneId

                             where company.CompanyId == com_id && plane.Type == textBoxPlane.Text
                             select flight);
                }
                else if (!string.IsNullOrWhiteSpace(textBoxPrice.Text))
                {
                    int price = Convert.ToInt32(textBoxPrice.Text);

                    query = (from flight in flight_cxt.Flight
                             join flight_company in flight_cxt.Flight_Company on flight.FlightId equals flight_company.FlightId
                             join company in flight_cxt.Company on flight_company.CompanyId equals company.CompanyId

                             join flight_ticket in flight_cxt.Flight_Ticket on flight.FlightId equals flight_ticket.FlightId
                             join ticket in flight_cxt.Ticket on flight_ticket.TicketId equals ticket.TicketId

                             where company.CompanyId == com_id && ticket.Price <= price
                             select flight);
                }
                else
                {
                    query = (from flight in flight_cxt.Flight
                             join flight_company in flight_cxt.Flight_Company on flight.FlightId equals flight_company.FlightId
                             join company in flight_cxt.Company on flight_company.CompanyId equals company.CompanyId

                             where company.CompanyId == com_id
                             select flight);
                }

                query.Load();

                this.flightBindingSource.DataSource = flight_cxt.Flight.Local.ToBindingList();
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