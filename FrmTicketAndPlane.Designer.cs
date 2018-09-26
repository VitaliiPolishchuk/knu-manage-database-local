namespace AirportDB
{
    partial class FrmTicketAndPlane
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.comBoxPlaneAdd = new System.Windows.Forms.ComboBox();
            this.labPlane = new System.Windows.Forms.Label();
            this.comBoxPlaneDelete = new System.Windows.Forms.ComboBox();
            this.buttonAddPlane = new System.Windows.Forms.Button();
            this.buttonDeletePlane = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comBoxTicketAdd = new System.Windows.Forms.ComboBox();
            this.labTicket = new System.Windows.Forms.Label();
            this.comBoxTicketDelete = new System.Windows.Forms.ComboBox();
            this.buttonAddTicket = new System.Windows.Forms.Button();
            this.buttonDeleteTicket = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.planeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightPlaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSet = new AirportDB.Properties.AirportDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ticketIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightTicketTableAdapter = new AirportDB.Properties.AirportDataSetTableAdapters.FlightTicketTableAdapter();
            this.flightPlaneTableAdapter = new AirportDB.Properties.AirportDataSetTableAdapters.FlightPlaneTableAdapter();
            this.airportDataSet1 = new AirportDB.Properties.AirportDataSet();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightPlaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightTicketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comBoxPlaneAdd);
            this.panel2.Controls.Add(this.labPlane);
            this.panel2.Controls.Add(this.comBoxPlaneDelete);
            this.panel2.Controls.Add(this.buttonAddPlane);
            this.panel2.Controls.Add(this.buttonDeletePlane);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 115);
            this.panel2.TabIndex = 17;
            // 
            // comBoxPlaneAdd
            // 
            this.comBoxPlaneAdd.FormattingEnabled = true;
            this.comBoxPlaneAdd.Location = new System.Drawing.Point(4, 24);
            this.comBoxPlaneAdd.Name = "comBoxPlaneAdd";
            this.comBoxPlaneAdd.Size = new System.Drawing.Size(121, 21);
            this.comBoxPlaneAdd.TabIndex = 13;
            this.comBoxPlaneAdd.SelectedIndexChanged += new System.EventHandler(this.cb_eventPlaneAdd_SelectedIndexChanged);
            // 
            // labPlane
            // 
            this.labPlane.AutoSize = true;
            this.labPlane.Location = new System.Drawing.Point(3, 8);
            this.labPlane.Name = "labPlane";
            this.labPlane.Size = new System.Drawing.Size(34, 13);
            this.labPlane.TabIndex = 14;
            this.labPlane.Text = "Plane";
            // 
            // comBoxPlaneDelete
            // 
            this.comBoxPlaneDelete.FormattingEnabled = true;
            this.comBoxPlaneDelete.Location = new System.Drawing.Point(4, 64);
            this.comBoxPlaneDelete.Name = "comBoxPlaneDelete";
            this.comBoxPlaneDelete.Size = new System.Drawing.Size(121, 21);
            this.comBoxPlaneDelete.TabIndex = 15;
            this.comBoxPlaneDelete.SelectedIndexChanged += new System.EventHandler(this.cb_eventPlaneDelete_SelectedIndexChanged);
            // 
            // buttonAddPlane
            // 
            this.buttonAddPlane.Location = new System.Drawing.Point(148, 24);
            this.buttonAddPlane.Name = "buttonAddPlane";
            this.buttonAddPlane.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPlane.TabIndex = 1;
            this.buttonAddPlane.Text = "Add";
            this.buttonAddPlane.UseVisualStyleBackColor = true;
            this.buttonAddPlane.Click += new System.EventHandler(this.button_AddPlane_Click);
            // 
            // buttonDeletePlane
            // 
            this.buttonDeletePlane.Location = new System.Drawing.Point(148, 64);
            this.buttonDeletePlane.Name = "buttonDeletePlane";
            this.buttonDeletePlane.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletePlane.TabIndex = 2;
            this.buttonDeletePlane.Text = "Delete";
            this.buttonDeletePlane.UseVisualStyleBackColor = true;
            this.buttonDeletePlane.Click += new System.EventHandler(this.button_DeletePlane_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comBoxTicketAdd);
            this.panel1.Controls.Add(this.labTicket);
            this.panel1.Controls.Add(this.comBoxTicketDelete);
            this.panel1.Controls.Add(this.buttonAddTicket);
            this.panel1.Controls.Add(this.buttonDeleteTicket);
            this.panel1.Location = new System.Drawing.Point(378, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 115);
            this.panel1.TabIndex = 17;
            // 
            // comBoxTicketAdd
            // 
            this.comBoxTicketAdd.FormattingEnabled = true;
            this.comBoxTicketAdd.Location = new System.Drawing.Point(4, 24);
            this.comBoxTicketAdd.Name = "comBoxTicketAdd";
            this.comBoxTicketAdd.Size = new System.Drawing.Size(121, 21);
            this.comBoxTicketAdd.TabIndex = 13;
            this.comBoxTicketAdd.SelectedIndexChanged += new System.EventHandler(this.cb_eventTicketAdd_SelectedIndexChanged);
            // 
            // labTicket
            // 
            this.labTicket.AutoSize = true;
            this.labTicket.Location = new System.Drawing.Point(3, 8);
            this.labTicket.Name = "labTicket";
            this.labTicket.Size = new System.Drawing.Size(37, 13);
            this.labTicket.TabIndex = 14;
            this.labTicket.Text = "Ticket";
            // 
            // comBoxTicketDelete
            // 
            this.comBoxTicketDelete.FormattingEnabled = true;
            this.comBoxTicketDelete.Location = new System.Drawing.Point(4, 64);
            this.comBoxTicketDelete.Name = "comBoxTicketDelete";
            this.comBoxTicketDelete.Size = new System.Drawing.Size(121, 21);
            this.comBoxTicketDelete.TabIndex = 15;
            this.comBoxTicketDelete.SelectedIndexChanged += new System.EventHandler(this.cb_eventTicketDelete_SelectedIndexChanged);
            // 
            // buttonAddTicket
            // 
            this.buttonAddTicket.Location = new System.Drawing.Point(148, 24);
            this.buttonAddTicket.Name = "buttonAddTicket";
            this.buttonAddTicket.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTicket.TabIndex = 1;
            this.buttonAddTicket.Text = "Add";
            this.buttonAddTicket.UseVisualStyleBackColor = true;
            this.buttonAddTicket.Click += new System.EventHandler(this.button_AddTicket_Click);
            // 
            // buttonDeleteTicket
            // 
            this.buttonDeleteTicket.Location = new System.Drawing.Point(148, 64);
            this.buttonDeleteTicket.Name = "buttonDeleteTicket";
            this.buttonDeleteTicket.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteTicket.TabIndex = 2;
            this.buttonDeleteTicket.Text = "Delete";
            this.buttonDeleteTicket.UseVisualStyleBackColor = true;
            this.buttonDeleteTicket.Click += new System.EventHandler(this.button_DeleteTicket_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planeIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flightPlaneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(309, 237);
            this.dataGridView1.TabIndex = 18;
            // 
            // planeIdDataGridViewTextBoxColumn
            // 
            this.planeIdDataGridViewTextBoxColumn.DataPropertyName = "PlaneId";
            this.planeIdDataGridViewTextBoxColumn.HeaderText = "PlaneId";
            this.planeIdDataGridViewTextBoxColumn.Name = "planeIdDataGridViewTextBoxColumn";
            this.planeIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // flightPlaneBindingSource
            // 
            this.flightPlaneBindingSource.DataMember = "FlightPlane";
            this.flightPlaneBindingSource.DataSource = this.airportDataSet;
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIdDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.flightTicketBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(378, 143);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(319, 237);
            this.dataGridView2.TabIndex = 19;
            // 
            // ticketIdDataGridViewTextBoxColumn
            // 
            this.ticketIdDataGridViewTextBoxColumn.DataPropertyName = "TicketId";
            this.ticketIdDataGridViewTextBoxColumn.HeaderText = "TicketId";
            this.ticketIdDataGridViewTextBoxColumn.Name = "ticketIdDataGridViewTextBoxColumn";
            this.ticketIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // flightTicketBindingSource
            // 
            this.flightTicketBindingSource.DataMember = "FlightTicket";
            this.flightTicketBindingSource.DataSource = this.airportDataSet;
            // 
            // flightTicketTableAdapter
            // 
            this.flightTicketTableAdapter.ClearBeforeFill = true;
            // 
            // flightPlaneTableAdapter
            // 
            this.flightPlaneTableAdapter.ClearBeforeFill = true;
            // 
            // airportDataSet1
            // 
            this.airportDataSet1.DataSetName = "AirportDataSet";
            this.airportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmTicketAndPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 392);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmTicketAndPlane";
            this.Text = "FrmTicketAndPlane";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightPlaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightTicketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comBoxPlaneAdd;
        private System.Windows.Forms.Label labPlane;
        private System.Windows.Forms.ComboBox comBoxPlaneDelete;
        private System.Windows.Forms.Button buttonAddPlane;
        private System.Windows.Forms.Button buttonDeletePlane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comBoxTicketAdd;
        private System.Windows.Forms.Label labTicket;
        private System.Windows.Forms.ComboBox comBoxTicketDelete;
        private System.Windows.Forms.Button buttonAddTicket;
        private System.Windows.Forms.Button buttonDeleteTicket;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource flightPlaneBindingSource;
        private Properties.AirportDataSet airportDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource flightTicketBindingSource;
        private Properties.AirportDataSetTableAdapters.FlightTicketTableAdapter flightTicketTableAdapter;
        private Properties.AirportDataSetTableAdapters.FlightPlaneTableAdapter flightPlaneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private Properties.AirportDataSet airportDataSet1;
    }
}