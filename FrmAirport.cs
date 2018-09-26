using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportDB
{
    public partial class formAirport : Form
    {
        bool changedCompany = false;
        public formAirport()
        {
            InitializeComponent();
        }

        private void formAirport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.Flight' table. You can move, or remove it, as needed.
            this.flightTableAdapter.Fill(this.airportDataSet.Flight);
            // TODO: This line of code loads data into the 'airportDataSet.Ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.airportDataSet.Ticket);
            // TODO: This line of code loads data into the 'airportDataSet.Plane' table. You can move, or remove it, as needed.
            this.planeTableAdapter.Fill(this.airportDataSet.Plane);
            // TODO: This line of code loads data into the 'airportDataSet.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.airportDataSet.Company);

        }

        private void buttonSaveCustomer_Click(object sender, EventArgs e)
        {
            this.ticketTableAdapter.Update(this.airportDataSet.Ticket);
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewCustomer.CurrentRow.Cells["ticketIdDataGridViewTextBoxColumn"].Value;

                global::System.Nullable<int> au_count = qTableAdapter1.SQCountTicketId_In_FlightTicket(id);

                if(au_count == 0)
                {
                    ticketBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Ticket have relationship", "Try delete ticket");
                }
            }
            catch
            {
                MessageBox.Show("Error", "Some kind of Error");
            }
        }

        private void buttonSaveCompany_Click(object sender, EventArgs e)
        {
            companyTableAdapter.Update(this.airportDataSet.Company);
            changedCompany = true;
        }

        private void buttonDeleteCompany_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewCompany.CurrentRow.Cells["companyIdDataGridViewTextBoxColumn"].Value;

                global::System.Nullable<int> au_count = qTableAdapter1.SQCountCompanyId_In_FlightCompany(id);

                if (au_count == 0)
                {
                    companyBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Company have relationship", "Try delete company");
                }
            }
            catch
            {
                MessageBox.Show("Error", "Some kind of Error");
            }
        }

        private void buttonSavePlane_Click(object sender, EventArgs e)
        {
            planeTableAdapter.Update(this.airportDataSet.Plane);
        }

        private void buttonDeletePlane_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewPlane.CurrentRow.Cells["planeIdDataGridViewTextBoxColumn"].Value;

                global::System.Nullable<int> au_count = qTableAdapter1.SQCountPlaneId_In_FlightPlane(id);

                if (au_count == 0)
                {
                    planeBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Plane have relationship", "Try delete Plane");
                }
            }
            catch
            {
                MessageBox.Show("Error", "Some kind of Error");
            }
        }

        private void dGVCompany_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!changedCompany)
            {
                MessageBox.Show("Must save", "Show Category");
            }
            else
            {
                try
                {
                    int id = (int)dataGridViewCompany.CurrentRow.Cells["companyIdDataGridViewTextBoxColumn"].Value;
                    string info = (string)dataGridViewCompany.CurrentRow.Cells["nameDataGridViewTextBoxColumn"].Value;

                    FrmFlight flight = new FrmFlight(id, info);

                    flight.ShowDialog(this);

                    flight.Dispose();
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                catch
                {
                    MessageBox.Show("Error go to list of flight", "Go to list flight");
                }
            }
        }

        private void buttonSaveFlight_Click(object sender, EventArgs e)
        {
            flightTableAdapter.Update(this.airportDataSet.Flight);
        }

        private void buttonDeleteFlight_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewFight.CurrentRow.Cells["flightIdDataGridViewTextBoxColumn"].Value;

                global::System.Nullable<int> relationCompany = qTableAdapter1.SQCountFlightId_in_Flight_Company(id);
                global::System.Nullable<int> relationTicket = qTableAdapter1.SQCountFlightId_in_Flight_plane(id);
                global::System.Nullable<int> relationPlane = qTableAdapter1.SQCountFlightId_in_Flight_Ticket(id);
                if (relationCompany == 0 && relationPlane == 0 && relationTicket == 0)
                {
                    flightBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Flight have relationship", "Try delete Flight");
                }
            }
            catch
            {
                MessageBox.Show("Error", "Some kind of Error");
            }
        }
    }
}
