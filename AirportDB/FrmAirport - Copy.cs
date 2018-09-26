using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace AirportDB
{
    public partial class formAirport : Form
    {
        private LibraryData.AirportEntities aieEF;

        bool changedCompany = false;
        public formAirport()
        {
            InitializeComponent();
            aieEF = new LibraryData.AirportEntities();

            aieEF.Company.Load();
            this.companyBindingSource.DataSource = aieEF.Company.Local.ToBindingList();

            aieEF.Plane.Load();
            this.planeBindingSource.DataSource = aieEF.Plane.Local.ToBindingList();

            aieEF.Flight.Load();
            this.flightBindingSource.DataSource = aieEF.Flight.Local.ToBindingList();

            aieEF.Ticket.Load();
            this.ticketBindingSource.DataSource = aieEF.Ticket.Local.ToBindingList();
        }

        private void formAirport_Load(object sender, EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            aieEF = new LibraryData.AirportEntities();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            aieEF.Dispose();
        }


        private void buttonSaveCustomer_Click(object sender, EventArgs e)
        {
            aieEF.SaveChanges();
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                LibraryData.Ticket ticket = (LibraryData.Ticket)dataGridViewCustomer.CurrentRow.DataBoundItem;

                var b = (from c in aieEF.Flight_Ticket
                         where (c.TicketId == ticket.TicketId)
                         select c).Any();

                if(b)
                {
                    MessageBox.Show("Ticket have relationship", "Try delete ticket");
                }
                else
                {
                    ticketBindingSource.RemoveCurrent();
                }
            }
            catch
            {
                MessageBox.Show("Error", "Some kind of Error");
            }
        }

        private void buttonSaveCompany_Click(object sender, EventArgs e)
        {
            aieEF.SaveChanges();
        }

        private void buttonDeleteCompany_Click(object sender, EventArgs e)
        {
            try
            {
                LibraryData.Company company = (LibraryData.Company)dataGridViewCompany.CurrentRow.DataBoundItem;

                var b = (from c in aieEF.Flight_Company
                         where (c.CompanyId == company.CompanyId)
                         select c).Any();

                if (b)
                {
                    MessageBox.Show("Company have relationship", "Try delete Company");
                }
                else
                {
                    companyBindingSource.RemoveCurrent();
                }
            }
            catch
            {
                MessageBox.Show("Error", "Some kind of Error");
            }
        }

        private void buttonSavePlane_Click(object sender, EventArgs e)
        {
            aieEF.SaveChanges();
        }

        private void buttonDeletePlane_Click(object sender, EventArgs e)
        {
            try
            {
                LibraryData.Plane Plane = (LibraryData.Plane)dataGridViewPlane.CurrentRow.DataBoundItem;

                var b = (from c in aieEF.Flight_Plane
                         where (c.PlaneId == Plane.PlaneId)
                         select c).Any();

                if (b)
                {
                    MessageBox.Show("Plane have relationship", "Try delete Plane");
                }
                else
                {
                    planeBindingSource.RemoveCurrent();
                }
            }
            catch
            {
                MessageBox.Show("Error", "Some kind of Error");
            }
        }

        private void dGVCompany_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var chE = aieEF.ChangeTracker.Entries<LibraryData.Company>().Where(a => a.State != EntityState.Unchanged).ToList();

            if (chE.Count != 0)
            {
                MessageBox.Show("Must save", "Show Category");
            }
            
            {
                try
                {
                    LibraryData.Company dcom = (LibraryData.Company)dataGridViewCompany.CurrentRow.DataBoundItem;

                    FrmFlight flight = new FrmFlight(dcom.CompanyId, dcom.Name);

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
            aieEF.SaveChanges();
        }

        private void buttonDeleteFlight_Click(object sender, EventArgs e)
        {
            try
            {
                LibraryData.Flight flight = (LibraryData.Flight)dataGridViewFight.CurrentRow.DataBoundItem;

                var plane = (from c in aieEF.Flight_Plane
                             where (c.FlightId == flight.FlightId)
                             select c).Any();

                var ticket = (from c in aieEF.Flight_Ticket
                              where (c.FlightId == flight.FlightId)
                              select c).Any();

                var company = (from c in aieEF.Flight_Company
                               where (c.FlightId == flight.FlightId)
                               select c).Any();

                if (plane || ticket || company)
                {
                    MessageBox.Show("Flight have relationship", "Try delete Flight");
                }
                else
                {
                    flightBindingSource.RemoveCurrent();
                }
            }
            catch
            {
                MessageBox.Show("Error", "Some kind of Error");
            }
        }
        
    }
}
