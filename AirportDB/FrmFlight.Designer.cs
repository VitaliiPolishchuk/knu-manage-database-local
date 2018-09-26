namespace AirportDB
{
    partial class FrmFlight
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
            this.dataGridViewFlight = new System.Windows.Forms.DataGridView();
            this.buttonAddFlight = new System.Windows.Forms.Button();
            this.buttonDeleteFlight = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxPlane = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxFlightAdd = new System.Windows.Forms.ComboBox();
            this.labFlight = new System.Windows.Forms.Label();
            this.comBoxFlightDelete = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightPlaneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlight)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFlight
            // 
            this.dataGridViewFlight.AutoGenerateColumns = false;
            this.dataGridViewFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightIdDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn,
            this.flightCompanyDataGridViewTextBoxColumn,
            this.flightPlaneDataGridViewTextBoxColumn,
            this.flightTicketDataGridViewTextBoxColumn});
            this.dataGridViewFlight.DataSource = this.flightBindingSource;
            this.dataGridViewFlight.Location = new System.Drawing.Point(12, 136);
            this.dataGridViewFlight.Name = "dataGridViewFlight";
            this.dataGridViewFlight.Size = new System.Drawing.Size(146, 274);
            this.dataGridViewFlight.TabIndex = 0;
            this.dataGridViewFlight.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCompany_CellDoubleClick);
            // 
            // buttonAddFlight
            // 
            this.buttonAddFlight.Location = new System.Drawing.Point(148, 24);
            this.buttonAddFlight.Name = "buttonAddFlight";
            this.buttonAddFlight.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFlight.TabIndex = 1;
            this.buttonAddFlight.Text = "Add";
            this.buttonAddFlight.UseVisualStyleBackColor = true;
            this.buttonAddFlight.Click += new System.EventHandler(this.button_AddFlight_Click);
            // 
            // buttonDeleteFlight
            // 
            this.buttonDeleteFlight.Location = new System.Drawing.Point(148, 64);
            this.buttonDeleteFlight.Name = "buttonDeleteFlight";
            this.buttonDeleteFlight.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteFlight.TabIndex = 2;
            this.buttonDeleteFlight.Text = "Delete";
            this.buttonDeleteFlight.UseVisualStyleBackColor = true;
            this.buttonDeleteFlight.Click += new System.EventHandler(this.button_DeleteFlight_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(119, 77);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxPlane
            // 
            this.textBoxPlane.Location = new System.Drawing.Point(94, 17);
            this.textBoxPlane.Name = "textBoxPlane";
            this.textBoxPlane.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlane.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Пошук";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Літак";
            // 
            // comBoxFlightAdd
            // 
            this.comBoxFlightAdd.FormattingEnabled = true;
            this.comBoxFlightAdd.Location = new System.Drawing.Point(4, 24);
            this.comBoxFlightAdd.Name = "comBoxFlightAdd";
            this.comBoxFlightAdd.Size = new System.Drawing.Size(121, 21);
            this.comBoxFlightAdd.TabIndex = 13;
            // 
            // labFlight
            // 
            this.labFlight.AutoSize = true;
            this.labFlight.Location = new System.Drawing.Point(3, 8);
            this.labFlight.Name = "labFlight";
            this.labFlight.Size = new System.Drawing.Size(32, 13);
            this.labFlight.TabIndex = 14;
            this.labFlight.Text = "Flight";
            // 
            // comBoxFlightDelete
            // 
            this.comBoxFlightDelete.FormattingEnabled = true;
            this.comBoxFlightDelete.Location = new System.Drawing.Point(4, 64);
            this.comBoxFlightDelete.Name = "comBoxFlightDelete";
            this.comBoxFlightDelete.Size = new System.Drawing.Size(121, 21);
            this.comBoxFlightDelete.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comBoxFlightAdd);
            this.panel2.Controls.Add(this.labFlight);
            this.panel2.Controls.Add(this.comBoxFlightDelete);
            this.panel2.Controls.Add(this.buttonAddFlight);
            this.panel2.Controls.Add(this.buttonDeleteFlight);
            this.panel2.Location = new System.Drawing.Point(10, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 94);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxPlane);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(178, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 17;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(94, 50);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 12;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(21, 57);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(29, 13);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Ціна";
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataSource = typeof(LibraryData.Flight);
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
            // flightCompanyDataGridViewTextBoxColumn
            // 
            this.flightCompanyDataGridViewTextBoxColumn.DataPropertyName = "Flight_Company";
            this.flightCompanyDataGridViewTextBoxColumn.HeaderText = "Flight_Company";
            this.flightCompanyDataGridViewTextBoxColumn.Name = "flightCompanyDataGridViewTextBoxColumn";
            this.flightCompanyDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightPlaneDataGridViewTextBoxColumn
            // 
            this.flightPlaneDataGridViewTextBoxColumn.DataPropertyName = "Flight_Plane";
            this.flightPlaneDataGridViewTextBoxColumn.HeaderText = "Flight_Plane";
            this.flightPlaneDataGridViewTextBoxColumn.Name = "flightPlaneDataGridViewTextBoxColumn";
            this.flightPlaneDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightTicketDataGridViewTextBoxColumn
            // 
            this.flightTicketDataGridViewTextBoxColumn.DataPropertyName = "Flight_Ticket";
            this.flightTicketDataGridViewTextBoxColumn.HeaderText = "Flight_Ticket";
            this.flightTicketDataGridViewTextBoxColumn.Name = "flightTicketDataGridViewTextBoxColumn";
            this.flightTicketDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewFlight);
            this.Name = "FrmFlight";
            this.Text = "Flight";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlight)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAddFlight;
        private System.Windows.Forms.Button buttonDeleteFlight;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxPlane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comBoxFlightAdd;
        private System.Windows.Forms.Label labFlight;
        private System.Windows.Forms.ComboBox comBoxFlightDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightPlaneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource flightBindingSource;
    }
}