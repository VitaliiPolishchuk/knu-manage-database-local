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
    public partial class FrmTicketAndPlane : Form
    {
        public int fl_id;

        public string connection_string = @"Data Source=LAPTOP-GV54J1BA\SQLEXPRESS;Initial Catalog = Airport; Integrated Security = True";

        public FrmTicketAndPlane()
        {
            InitializeComponent();
        }

        public FrmTicketAndPlane(int id_fl, string info_fl)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ", info_fl);

            fl_id = id_fl;

            flightPlaneTableAdapter.Fill(this.airportDataSet.FlightPlane, fl_id);
            cb_PlaneAdd_set();
            cb_PlaneDelete_set();
            flightTicketTableAdapter.Fill(this.airportDataSet.FlightTicket, fl_id);
            cb_TicketAdd_set();
            cb_TicketDelete_set();
        }

        private void cb_PlaneAdd_set()
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = connection_string;
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconn;
            sqlcommand.CommandText = "SELECT * FROM Plane " +
                                        " WHERE Plane.PlaneId NOT IN ( SELECT Flight_Plane.PlaneId FROM Flight_Plane WHERE Flight_Plane.FlightId = " + fl_id + " );";
            SqlDataReader sqldr;
            sqlconn.Open();
            sqldr = sqlcommand.ExecuteReader();
            comBoxPlaneAdd.Items.Clear();
            while (sqldr.Read())
            {
                comBoxPlaneAdd.Items.Add(new Store_Plane(Convert.ToInt32(sqldr[0]), sqldr[1].ToString()));
            }
            sqldr.Close();
            sqlconn.Close();
        }


        private void cb_PlaneDelete_set()
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = connection_string;
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconn;
            sqlcommand.CommandText = "SELECT * FROM Plane INNER JOIN Flight_Plane ON Flight_Plane.PlaneId = Plane.PlaneId " +
                                    "WHERE Flight_Plane.FlightId =" + fl_id;
            SqlDataReader sqldr;
            sqlconn.Open();
            sqldr = sqlcommand.ExecuteReader();
            comBoxPlaneDelete.Items.Clear();
            while (sqldr.Read())
            {
                comBoxPlaneDelete.Items.Add(new Store_Plane(Convert.ToInt32(sqldr[0]), sqldr[1].ToString()));
            }
            sqldr.Close();
            sqlconn.Close();
        }

        private void cb_eventPlaneAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hValueA = ((Store_Plane)comBoxPlaneAdd.SelectedItem).idP;
        }

        private void cb_eventPlaneDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hValueA = ((Store_Plane)comBoxPlaneDelete.SelectedItem).idP;
        }

        private void button_AddPlane_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = connection_string;
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlconn;
                int plane_id = ((Store_Plane)comBoxPlaneAdd.SelectedItem).idP;
                sqlcommand.CommandText = "SELECT COUNT(*) FROM Flight_Plane WHERE Flight_Plane.FlightId= " + fl_id + " AND Flight_Plane.PlaneId=" + plane_id;
                SqlDataReader sqldr;
                sqlconn.Open();
                sqldr = sqlcommand.ExecuteReader();
                sqldr.Read();
                int idR = Convert.ToInt32(sqldr[0]);
                sqldr.Close();
                if (idR != 0)
                {
                    MessageBox.Show("Такий літак вже існує!", "Помилка");
                }
                else
                {
                    sqlcommand.CommandText = "INSERT INTO Flight_Plane (Flight_Plane.PlaneId, Flight_Plane.FlightId) VALUES (" + plane_id + ", " + fl_id + ")";
                    sqlcommand.ExecuteNonQuery();
                    flightPlaneTableAdapter.Fill(this.airportDataSet.FlightPlane, fl_id);
                    cb_PlaneAdd_set();
                    cb_PlaneDelete_set();
                    comBoxPlaneAdd.Text = "";
                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void button_DeletePlane_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = connection_string;
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlconn;
                int plane_id = ((Store_Plane)comBoxPlaneDelete.SelectedItem).idP;
                sqlcommand.CommandText = "SELECT COUNT(*) FROM Flight_Plane WHERE Flight_Plane.FlightId=" + fl_id + " AND Flight_Plane.PlaneId=" + plane_id;
                SqlDataReader sqldr;
                sqlconn.Open();
                sqldr = sqlcommand.ExecuteReader();
                sqldr.Read();
                int idR = Convert.ToInt32(sqldr[0]);
                sqldr.Close();
                if (idR == 0)
                {
                    MessageBox.Show("Такого літака не існує!", "Помилка");
                }
                else
                {
                    sqlcommand.CommandText = "DELETE FROM Flight_Plane WHERE Flight_Plane.FlightId = " + fl_id + " AND Flight_Plane.PlaneId = " + plane_id;
                    sqlcommand.ExecuteNonQuery();
                    flightPlaneTableAdapter.Fill(this.airportDataSet.FlightPlane, fl_id);
                    cb_PlaneAdd_set();
                    cb_PlaneDelete_set();
                    comBoxPlaneDelete.Text = "";
                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void cb_TicketAdd_set()
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = connection_string;
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconn;
            sqlcommand.CommandText = "SELECT * FROM Ticket " +
                                        " WHERE Ticket.TicketId NOT IN ( SELECT Flight_Ticket.TicketId FROM Flight_Ticket WHERE Flight_Ticket.FlightId = " + fl_id + " );";
            SqlDataReader sqldr;
            sqlconn.Open();
            sqldr = sqlcommand.ExecuteReader();
            comBoxTicketAdd.Items.Clear();
            while (sqldr.Read())
            {
                comBoxTicketAdd.Items.Add(new Store_Ticket(Convert.ToInt32(sqldr[0]), sqldr[1].ToString()));
            }
            sqldr.Close();
            sqlconn.Close();
        }


        private void cb_TicketDelete_set()
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = connection_string;
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconn;
            sqlcommand.CommandText = "SELECT * FROM Ticket INNER JOIN Flight_Ticket ON Flight_Ticket.TicketId = Ticket.TicketId " +
                                    "WHERE Flight_Ticket.FlightId =" + fl_id;
            SqlDataReader sqldr;
            sqlconn.Open();
            sqldr = sqlcommand.ExecuteReader();
            comBoxTicketDelete.Items.Clear();
            while (sqldr.Read())
            {
                comBoxTicketDelete.Items.Add(new Store_Ticket(Convert.ToInt32(sqldr[0]), sqldr[1].ToString()));
            }
            sqldr.Close();
            sqlconn.Close();
        }

        private void cb_eventTicketAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hValueA = ((Store_Ticket)comBoxTicketAdd.SelectedItem).idT;
        }

        private void cb_eventTicketDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hValueA = ((Store_Ticket)comBoxTicketDelete.SelectedItem).idT;
        }

        private void button_AddTicket_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = connection_string;
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlconn;
                int ticket_id = ((Store_Ticket)comBoxTicketAdd.SelectedItem).idT;
                sqlcommand.CommandText = "SELECT COUNT(*) FROM Flight_Ticket WHERE Flight_Ticket.FlightId= " + fl_id + " AND Flight_Ticket.TicketId=" + ticket_id;
                SqlDataReader sqldr;
                sqlconn.Open();
                sqldr = sqlcommand.ExecuteReader();
                sqldr.Read();
                int idR = Convert.ToInt32(sqldr[0]);
                sqldr.Close();
                if (idR != 0)
                {
                    MessageBox.Show("Такий літак вже існує!", "Помилка");
                }
                else
                {
                    sqlcommand.CommandText = "INSERT INTO Flight_Ticket (Flight_Ticket.TicketId, Flight_Ticket.FlightId) VALUES (" + ticket_id + ", " + fl_id + ")";
                    sqlcommand.ExecuteNonQuery();
                    flightTicketTableAdapter.Fill(this.airportDataSet.FlightTicket, fl_id);
                    cb_TicketAdd_set();
                    cb_TicketDelete_set();
                    comBoxTicketAdd.Text = "";
                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void button_DeleteTicket_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = connection_string;
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlconn;
                int ticket_id = ((Store_Ticket)comBoxTicketDelete.SelectedItem).idT;
                sqlcommand.CommandText = "SELECT COUNT(*) FROM Flight_Ticket WHERE Flight_Ticket.FlightId=" + fl_id + " AND Flight_Ticket.TicketId=" + ticket_id;
                SqlDataReader sqldr;
                sqlconn.Open();
                sqldr = sqlcommand.ExecuteReader();
                sqldr.Read();
                int idR = Convert.ToInt32(sqldr[0]);
                sqldr.Close();
                if (idR == 0)
                {
                    MessageBox.Show("Такого літака не існує!", "Помилка");
                }
                else
                {
                    sqlcommand.CommandText = "DELETE FROM Flight_Ticket WHERE Flight_Ticket.FlightId = " + fl_id + " AND Flight_Ticket.TicketId = " + ticket_id;
                    sqlcommand.ExecuteNonQuery();
                    flightTicketTableAdapter.Fill(this.airportDataSet.FlightTicket, fl_id);
                    cb_TicketAdd_set();
                    cb_TicketDelete_set();
                    comBoxTicketDelete.Text = "";
                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        public class Store_Plane
        {
            public int idP { get; set; }
            public string nameP { get; set; }
            public Store_Plane(int id, string info)
            {
                idP = id;
                nameP = info;
            }
            public override string ToString()
            {
                return nameP;
            }
        }


        public class Store_Ticket
        {
            public int idT { get; set; }
            public string priceT { get; set; }
            public Store_Ticket(int id, string info)
            {
                idT = id;
                priceT = info;
            }
            public override string ToString()
            {
                return priceT;
            }
        }
    }


}
