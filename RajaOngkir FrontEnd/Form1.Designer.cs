namespace RajaOngkir_FrontEnd
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCourier = new System.Windows.Forms.ComboBox();
            this.grpCities = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSourceProvince = new System.Windows.Forms.Label();
            this.lblSourceCity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.dgvCities = new System.Windows.Forms.DataGridView();
            this.txtSourceFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDestinationProvince = new System.Windows.Forms.Label();
            this.lblDestinationCity = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAPIType = new System.Windows.Forms.ComboBox();
            this.grpCities.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "API Key :";
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(73, 10);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(283, 20);
            this.txtAPIKey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Courier :";
            // 
            // cboCourier
            // 
            this.cboCourier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourier.FormattingEnabled = true;
            this.cboCourier.Location = new System.Drawing.Point(73, 43);
            this.cboCourier.Name = "cboCourier";
            this.cboCourier.Size = new System.Drawing.Size(283, 21);
            this.cboCourier.TabIndex = 3;
            // 
            // grpCities
            // 
            this.grpCities.Controls.Add(this.dataGridView1);
            this.grpCities.Controls.Add(this.groupBox2);
            this.grpCities.Controls.Add(this.groupBox1);
            this.grpCities.Controls.Add(this.label4);
            this.grpCities.Controls.Add(this.btnApplyFilter);
            this.grpCities.Controls.Add(this.dgvCities);
            this.grpCities.Controls.Add(this.txtSourceFilter);
            this.grpCities.Controls.Add(this.label3);
            this.grpCities.Location = new System.Drawing.Point(13, 83);
            this.grpCities.Name = "grpCities";
            this.grpCities.Size = new System.Drawing.Size(617, 424);
            this.grpCities.TabIndex = 4;
            this.grpCities.TabStop = false;
            this.grpCities.Text = "Source and destination";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSourceProvince);
            this.groupBox1.Controls.Add(this.lblSourceCity);
            this.groupBox1.Location = new System.Drawing.Point(10, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 96);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Source :";
            // 
            // lblSourceProvince
            // 
            this.lblSourceProvince.AutoSize = true;
            this.lblSourceProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceProvince.Location = new System.Drawing.Point(7, 40);
            this.lblSourceProvince.Name = "lblSourceProvince";
            this.lblSourceProvince.Size = new System.Drawing.Size(96, 15);
            this.lblSourceProvince.TabIndex = 1;
            this.lblSourceProvince.Text = "Source Province";
            // 
            // lblSourceCity
            // 
            this.lblSourceCity.AutoSize = true;
            this.lblSourceCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceCity.Location = new System.Drawing.Point(6, 16);
            this.lblSourceCity.Name = "lblSourceCity";
            this.lblSourceCity.Size = new System.Drawing.Size(184, 20);
            this.lblSourceCity.TabIndex = 0;
            this.lblSourceCity.Text = "Source City or District";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Right click an item to select";
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(409, 16);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(87, 22);
            this.btnApplyFilter.TabIndex = 3;
            this.btnApplyFilter.Text = "Apply Filter";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            // 
            // dgvCities
            // 
            this.dgvCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCities.Location = new System.Drawing.Point(10, 47);
            this.dgvCities.Name = "dgvCities";
            this.dgvCities.Size = new System.Drawing.Size(590, 150);
            this.dgvCities.TabIndex = 2;
            // 
            // txtSourceFilter
            // 
            this.txtSourceFilter.Location = new System.Drawing.Point(50, 18);
            this.txtSourceFilter.Name = "txtSourceFilter";
            this.txtSourceFilter.Size = new System.Drawing.Size(353, 20);
            this.txtSourceFilter.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Filter :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDestinationProvince);
            this.groupBox2.Controls.Add(this.lblDestinationCity);
            this.groupBox2.Location = new System.Drawing.Point(10, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 96);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Destination :";
            // 
            // lblDestinationProvince
            // 
            this.lblDestinationProvince.AutoSize = true;
            this.lblDestinationProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationProvince.Location = new System.Drawing.Point(7, 40);
            this.lblDestinationProvince.Name = "lblDestinationProvince";
            this.lblDestinationProvince.Size = new System.Drawing.Size(119, 15);
            this.lblDestinationProvince.TabIndex = 1;
            this.lblDestinationProvince.Text = "Destination Province";
            // 
            // lblDestinationCity
            // 
            this.lblDestinationCity.AutoSize = true;
            this.lblDestinationCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationCity.Location = new System.Drawing.Point(6, 16);
            this.lblDestinationCity.Name = "lblDestinationCity";
            this.lblDestinationCity.Size = new System.Drawing.Size(219, 20);
            this.lblDestinationCity.TabIndex = 0;
            this.lblDestinationCity.Text = "Destination City or District";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(249, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 188);
            this.dataGridView1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "API Type :";
            // 
            // cboAPIType
            // 
            this.cboAPIType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAPIType.Enabled = false;
            this.cboAPIType.FormattingEnabled = true;
            this.cboAPIType.Items.AddRange(new object[] {
            "Starter",
            "Basic",
            "Pro"});
            this.cboAPIType.Location = new System.Drawing.Point(433, 10);
            this.cboAPIType.Name = "cboAPIType";
            this.cboAPIType.Size = new System.Drawing.Size(160, 21);
            this.cboAPIType.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 516);
            this.Controls.Add(this.cboAPIType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpCities);
            this.Controls.Add(this.cboCourier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAPIKey);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RajaOngkir FrontEnd";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCities.ResumeLayout(false);
            this.grpCities.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCourier;
        private System.Windows.Forms.GroupBox grpCities;
        private System.Windows.Forms.TextBox txtSourceFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCities;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSourceProvince;
        private System.Windows.Forms.Label lblSourceCity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDestinationProvince;
        private System.Windows.Forms.Label lblDestinationCity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAPIType;
    }
}

