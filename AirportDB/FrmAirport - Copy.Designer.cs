namespace AirportDB
{
    partial class formAirport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabPagePlane = new System.Windows.Forms.TabPage();
            this.buttonAddPlane = new System.Windows.Forms.Button();
            this.buttonDeletePlane = new System.Windows.Forms.Button();
            this.buttonSavePlane = new System.Windows.Forms.Button();
            this.dataGridViewPlane = new System.Windows.Forms.DataGridView();
            this.planeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightPlaneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageCompany = new System.Windows.Forms.TabPage();
            this.buttonAddCompany = new System.Windows.Forms.Button();
            this.buttonDeleteCompany = new System.Windows.Forms.Button();
            this.buttonSaveCompany = new System.Windows.Forms.Button();
            this.dataGridViewCompany = new System.Windows.Forms.DataGridView();
            this.companyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageTicket = new System.Windows.Forms.TabPage();
            this.buttonAddTicket = new System.Windows.Forms.Button();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.buttonSaveCustomer = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.ticketIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFlight = new System.Windows.Forms.TabPage();
            this.buttonAddFlight = new System.Windows.Forms.Button();
            this.buttonDeleteFlight = new System.Windows.Forms.Button();
            this.buttonSaveFlight = new System.Windows.Forms.Button();
            this.dataGridViewFight = new System.Windows.Forms.DataGridView();
            this.flightIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightCompanyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightPlaneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightTicketDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPagePlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource)).BeginInit();
            this.tabPageCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.tabPageTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageFlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPagePlane
            // 
            this.tabPagePlane.Controls.Add(this.buttonAddPlane);
            this.tabPagePlane.Controls.Add(this.buttonDeletePlane);
            this.tabPagePlane.Controls.Add(this.buttonSavePlane);
            this.tabPagePlane.Controls.Add(this.dataGridViewPlane);
            this.tabPagePlane.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlane.Name = "tabPagePlane";
            this.tabPagePlane.Size = new System.Drawing.Size(686, 299);
            this.tabPagePlane.TabIndex = 4;
            this.tabPagePlane.Text = "Plane";
            this.tabPagePlane.UseVisualStyleBackColor = true;
            // 
            // buttonAddPlane
            // 
            this.buttonAddPlane.Location = new System.Drawing.Point(401, 3);
            this.buttonAddPlane.Name = "buttonAddPlane";
            this.buttonAddPlane.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPlane.TabIndex = 7;
            this.buttonAddPlane.Text = "Add";
            this.buttonAddPlane.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePlane
            // 
            this.buttonDeletePlane.Location = new System.Drawing.Point(131, 1);
            this.buttonDeletePlane.Name = "buttonDeletePlane";
            this.buttonDeletePlane.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletePlane.TabIndex = 5;
            this.buttonDeletePlane.Text = "Delete";
            this.buttonDeletePlane.UseVisualStyleBackColor = true;
            this.buttonDeletePlane.Click += new System.EventHandler(this.buttonDeletePlane_Click);
            // 
            // buttonSavePlane
            // 
            this.buttonSavePlane.Location = new System.Drawing.Point(4, 2);
            this.buttonSavePlane.Name = "buttonSavePlane";
            this.buttonSavePlane.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePlane.TabIndex = 4;
            this.buttonSavePlane.Text = "Save";
            this.buttonSavePlane.UseVisualStyleBackColor = true;
            this.buttonSavePlane.Click += new System.EventHandler(this.buttonSavePlane_Click);
            // 
            // dataGridViewPlane
            // 
            this.dataGridViewPlane.AutoGenerateColumns = false;
            this.dataGridViewPlane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlane.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planeIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.flightPlaneDataGridViewTextBoxColumn});
            this.dataGridViewPlane.DataSource = this.planeBindingSource;
            this.dataGridViewPlane.Location = new System.Drawing.Point(0, 40);
            this.dataGridViewPlane.Name = "dataGridViewPlane";
            this.dataGridViewPlane.Size = new System.Drawing.Size(687, 258);
            this.dataGridViewPlane.TabIndex = 3;
            // 
            // planeIdDataGridViewTextBoxColumn
            // 
            this.planeIdDataGridViewTextBoxColumn.DataPropertyName = "PlaneId";
            this.planeIdDataGridViewTextBoxColumn.HeaderText = "PlaneId";
            this.planeIdDataGridViewTextBoxColumn.Name = "planeIdDataGridViewTextBoxColumn";
            this.planeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // flightPlaneDataGridViewTextBoxColumn
            // 
            this.flightPlaneDataGridViewTextBoxColumn.DataPropertyName = "Flight_Plane";
            this.flightPlaneDataGridViewTextBoxColumn.HeaderText = "Flight_Plane";
            this.flightPlaneDataGridViewTextBoxColumn.Name = "flightPlaneDataGridViewTextBoxColumn";
            this.flightPlaneDataGridViewTextBoxColumn.Visible = false;
            // 
            // planeBindingSource
            // 
            this.planeBindingSource.DataSource = typeof(LibraryData.Plane);
            // 
            // tabPageCompany
            // 
            this.tabPageCompany.Controls.Add(this.buttonAddCompany);
            this.tabPageCompany.Controls.Add(this.buttonDeleteCompany);
            this.tabPageCompany.Controls.Add(this.buttonSaveCompany);
            this.tabPageCompany.Controls.Add(this.dataGridViewCompany);
            this.tabPageCompany.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompany.Name = "tabPageCompany";
            this.tabPageCompany.Size = new System.Drawing.Size(686, 299);
            this.tabPageCompany.TabIndex = 3;
            this.tabPageCompany.Text = "Company";
            this.tabPageCompany.UseVisualStyleBackColor = true;
            // 
            // buttonAddCompany
            // 
            this.buttonAddCompany.Location = new System.Drawing.Point(377, 3);
            this.buttonAddCompany.Name = "buttonAddCompany";
            this.buttonAddCompany.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCompany.TabIndex = 6;
            this.buttonAddCompany.Text = "Add";
            this.buttonAddCompany.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCompany
            // 
            this.buttonDeleteCompany.Location = new System.Drawing.Point(93, 3);
            this.buttonDeleteCompany.Name = "buttonDeleteCompany";
            this.buttonDeleteCompany.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCompany.TabIndex = 5;
            this.buttonDeleteCompany.Text = "Delete";
            this.buttonDeleteCompany.UseVisualStyleBackColor = true;
            this.buttonDeleteCompany.Click += new System.EventHandler(this.buttonDeleteCompany_Click);
            // 
            // buttonSaveCompany
            // 
            this.buttonSaveCompany.Location = new System.Drawing.Point(3, 3);
            this.buttonSaveCompany.Name = "buttonSaveCompany";
            this.buttonSaveCompany.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveCompany.TabIndex = 4;
            this.buttonSaveCompany.Text = "Save";
            this.buttonSaveCompany.UseVisualStyleBackColor = true;
            this.buttonSaveCompany.Click += new System.EventHandler(this.buttonSaveCompany_Click);
            // 
            // dataGridViewCompany
            // 
            this.dataGridViewCompany.AutoGenerateColumns = false;
            this.dataGridViewCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn,
            this.flightCompanyDataGridViewTextBoxColumn});
            this.dataGridViewCompany.DataSource = this.companyBindingSource;
            this.dataGridViewCompany.Location = new System.Drawing.Point(0, 40);
            this.dataGridViewCompany.Name = "dataGridViewCompany";
            this.dataGridViewCompany.Size = new System.Drawing.Size(687, 258);
            this.dataGridViewCompany.TabIndex = 3;
            this.dataGridViewCompany.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCompany_CellDoubleClick);
            this.dataGridViewCompany.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCompany_CellDoubleClick);
            // 
            // companyIdDataGridViewTextBoxColumn
            // 
            this.companyIdDataGridViewTextBoxColumn.DataPropertyName = "CompanyId";
            this.companyIdDataGridViewTextBoxColumn.HeaderText = "CompanyId";
            this.companyIdDataGridViewTextBoxColumn.Name = "companyIdDataGridViewTextBoxColumn";
            this.companyIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // flightCompanyDataGridViewTextBoxColumn
            // 
            this.flightCompanyDataGridViewTextBoxColumn.DataPropertyName = "Flight_Company";
            this.flightCompanyDataGridViewTextBoxColumn.HeaderText = "Flight_Company";
            this.flightCompanyDataGridViewTextBoxColumn.Name = "flightCompanyDataGridViewTextBoxColumn";
            this.flightCompanyDataGridViewTextBoxColumn.Visible = false;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(LibraryData.Company);
            // 
            // tabPageTicket
            // 
            this.tabPageTicket.Controls.Add(this.buttonAddTicket);
            this.tabPageTicket.Controls.Add(this.buttonDeleteCustomer);
            this.tabPageTicket.Controls.Add(this.buttonSaveCustomer);
            this.tabPageTicket.Controls.Add(this.dataGridViewCustomer);
            this.tabPageTicket.Location = new System.Drawing.Point(4, 22);
            this.tabPageTicket.Name = "tabPageTicket";
            this.tabPageTicket.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTicket.Size = new System.Drawing.Size(686, 299);
            this.tabPageTicket.TabIndex = 0;
            this.tabPageTicket.Text = "Ticket";
            this.tabPageTicket.UseVisualStyleBackColor = true;
            // 
            // buttonAddTicket
            // 
            this.buttonAddTicket.Location = new System.Drawing.Point(413, 3);
            this.buttonAddTicket.Name = "buttonAddTicket";
            this.buttonAddTicket.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTicket.TabIndex = 7;
            this.buttonAddTicket.Text = "Add";
            this.buttonAddTicket.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(134, 6);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCustomer.TabIndex = 2;
            this.buttonDeleteCustomer.Text = "Delete";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // buttonSaveCustomer
            // 
            this.buttonSaveCustomer.Location = new System.Drawing.Point(7, 7);
            this.buttonSaveCustomer.Name = "buttonSaveCustomer";
            this.buttonSaveCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveCustomer.TabIndex = 1;
            this.buttonSaveCustomer.Text = "Save";
            this.buttonSaveCustomer.UseVisualStyleBackColor = true;
            this.buttonSaveCustomer.Click += new System.EventHandler(this.buttonSaveCustomer_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AutoGenerateColumns = false;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIdDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.flightTicketDataGridViewTextBoxColumn});
            this.dataGridViewCustomer.DataSource = this.ticketBindingSource;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(3, 45);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(687, 117);
            this.dataGridViewCustomer.TabIndex = 0;
            // 
            // ticketIdDataGridViewTextBoxColumn
            // 
            this.ticketIdDataGridViewTextBoxColumn.DataPropertyName = "TicketId";
            this.ticketIdDataGridViewTextBoxColumn.HeaderText = "TicketId";
            this.ticketIdDataGridViewTextBoxColumn.Name = "ticketIdDataGridViewTextBoxColumn";
            this.ticketIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // flightTicketDataGridViewTextBoxColumn
            // 
            this.flightTicketDataGridViewTextBoxColumn.DataPropertyName = "Flight_Ticket";
            this.flightTicketDataGridViewTextBoxColumn.HeaderText = "Flight_Ticket";
            this.flightTicketDataGridViewTextBoxColumn.Name = "flightTicketDataGridViewTextBoxColumn";
            this.flightTicketDataGridViewTextBoxColumn.Visible = false;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataSource = typeof(LibraryData.Ticket);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCompany);
            this.tabControl1.Controls.Add(this.tabPagePlane);
            this.tabControl1.Controls.Add(this.tabPageTicket);
            this.tabControl1.Controls.Add(this.tabPageFlight);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 325);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFlight
            // 
            this.tabPageFlight.Controls.Add(this.buttonAddFlight);
            this.tabPageFlight.Controls.Add(this.buttonDeleteFlight);
            this.tabPageFlight.Controls.Add(this.buttonSaveFlight);
            this.tabPageFlight.Controls.Add(this.dataGridViewFight);
            this.tabPageFlight.Location = new System.Drawing.Point(4, 22);
            this.tabPageFlight.Name = "tabPageFlight";
            this.tabPageFlight.Size = new System.Drawing.Size(686, 299);
            this.tabPageFlight.TabIndex = 5;
            this.tabPageFlight.Text = "Flight";
            this.tabPageFlight.UseVisualStyleBackColor = true;
            // 
            // buttonAddFlight
            // 
            this.buttonAddFlight.Location = new System.Drawing.Point(423, 3);
            this.buttonAddFlight.Name = "buttonAddFlight";
            this.buttonAddFlight.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFlight.TabIndex = 9;
            this.buttonAddFlight.Text = "Add";
            this.buttonAddFlight.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFlight
            // 
            this.buttonDeleteFlight.Location = new System.Drawing.Point(131, 1);
            this.buttonDeleteFlight.Name = "buttonDeleteFlight";
            this.buttonDeleteFlight.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteFlight.TabIndex = 8;
            this.buttonDeleteFlight.Text = "Delete";
            this.buttonDeleteFlight.UseVisualStyleBackColor = true;
            this.buttonDeleteFlight.Click += new System.EventHandler(this.buttonDeleteFlight_Click);
            // 
            // buttonSaveFlight
            // 
            this.buttonSaveFlight.Location = new System.Drawing.Point(4, 2);
            this.buttonSaveFlight.Name = "buttonSaveFlight";
            this.buttonSaveFlight.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveFlight.TabIndex = 7;
            this.buttonSaveFlight.Text = "Save";
            this.buttonSaveFlight.UseVisualStyleBackColor = true;
            this.buttonSaveFlight.Click += new System.EventHandler(this.buttonSaveFlight_Click);
            // 
            // dataGridViewFight
            // 
            this.dataGridViewFight.AutoGenerateColumns = false;
            this.dataGridViewFight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightIdDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn,
            this.flightCompanyDataGridViewTextBoxColumn1,
            this.flightPlaneDataGridViewTextBoxColumn1,
            this.flightTicketDataGridViewTextBoxColumn1});
            this.dataGridViewFight.DataSource = this.flightBindingSource;
            this.dataGridViewFight.Location = new System.Drawing.Point(0, 40);
            this.dataGridViewFight.Name = "dataGridViewFight";
            this.dataGridViewFight.Size = new System.Drawing.Size(687, 258);
            this.dataGridViewFight.TabIndex = 6;
            // 
            // flightIdDataGridViewTextBoxColumn
            // 
            this.flightIdDataGridViewTextBoxColumn.DataPropertyName = "FlightId";
            this.flightIdDataGridViewTextBoxColumn.HeaderText = "FlightId";
            this.flightIdDataGridViewTextBoxColumn.Name = "flightIdDataGridViewTextBoxColumn";
            this.flightIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // infoDataGridViewTextBoxColumn
            // 
            this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
            this.infoDataGridViewTextBoxColumn.HeaderText = "Info";
            this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
            // 
            // flightCompanyDataGridViewTextBoxColumn1
            // 
            this.flightCompanyDataGridViewTextBoxColumn1.DataPropertyName = "Flight_Company";
            this.flightCompanyDataGridViewTextBoxColumn1.HeaderText = "Flight_Company";
            this.flightCompanyDataGridViewTextBoxColumn1.Name = "flightCompanyDataGridViewTextBoxColumn1";
            this.flightCompanyDataGridViewTextBoxColumn1.Visible = false;
            // 
            // flightPlaneDataGridViewTextBoxColumn1
            // 
            this.flightPlaneDataGridViewTextBoxColumn1.DataPropertyName = "Flight_Plane";
            this.flightPlaneDataGridViewTextBoxColumn1.HeaderText = "Flight_Plane";
            this.flightPlaneDataGridViewTextBoxColumn1.Name = "flightPlaneDataGridViewTextBoxColumn1";
            this.flightPlaneDataGridViewTextBoxColumn1.Visible = false;
            // 
            // flightTicketDataGridViewTextBoxColumn1
            // 
            this.flightTicketDataGridViewTextBoxColumn1.DataPropertyName = "Flight_Ticket";
            this.flightTicketDataGridViewTextBoxColumn1.HeaderText = "Flight_Ticket";
            this.flightTicketDataGridViewTextBoxColumn1.Name = "flightTicketDataGridViewTextBoxColumn1";
            this.flightTicketDataGridViewTextBoxColumn1.Visible = false;
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataSource = typeof(LibraryData.Flight);
            // 
            // formAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 350);
            this.Controls.Add(this.tabControl1);
            this.Name = "formAirport";
            this.Text = "Airport";
            this.Load += new System.EventHandler(this.formAirport_Load);
            this.tabPagePlane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource)).EndInit();
            this.tabPageCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.tabPageTicket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageFlight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPagePlane;
        private System.Windows.Forms.Button buttonDeletePlane;
        private System.Windows.Forms.Button buttonSavePlane;
        private System.Windows.Forms.DataGridView dataGridViewPlane;
        private System.Windows.Forms.TabPage tabPageCompany;
        private System.Windows.Forms.Button buttonDeleteCompany;
        private System.Windows.Forms.Button buttonSaveCompany;
        private System.Windows.Forms.DataGridView dataGridViewCompany;
        private System.Windows.Forms.TabPage tabPageTicket;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.Button buttonSaveCustomer;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFlight;
        private System.Windows.Forms.Button buttonDeleteFlight;
        private System.Windows.Forms.Button buttonSaveFlight;
        private System.Windows.Forms.DataGridView dataGridViewFight;
        private System.Windows.Forms.BindingSource planeBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightPlaneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightCompanyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightPlaneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightTicketDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button buttonAddCompany;
        private System.Windows.Forms.Button buttonAddPlane;
        private System.Windows.Forms.Button buttonAddTicket;
        private System.Windows.Forms.Button buttonAddFlight;
    }
}

