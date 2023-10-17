namespace Coursework1Form
{
    partial class AppointmentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbxTime = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtbxAppointmentFor = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAppointmentFor = new System.Windows.Forms.Label();
            this.bttnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.txtbxDate = new System.Windows.Forms.TextBox();
            this.dataGridViewAppointment = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxTime
            // 
            this.txtbxTime.Location = new System.Drawing.Point(176, 46);
            this.txtbxTime.Name = "txtbxTime";
            this.txtbxTime.PlaceholderText = "00:00";
            this.txtbxTime.Size = new System.Drawing.Size(106, 27);
            this.txtbxTime.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // txtbxAppointmentFor
            // 
            this.txtbxAppointmentFor.Location = new System.Drawing.Point(14, 111);
            this.txtbxAppointmentFor.Name = "txtbxAppointmentFor";
            this.txtbxAppointmentFor.Size = new System.Drawing.Size(268, 27);
            this.txtbxAppointmentFor.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(197, 23);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 20);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time";
            // 
            // lblAppointmentFor
            // 
            this.lblAppointmentFor.AutoSize = true;
            this.lblAppointmentFor.Location = new System.Drawing.Point(14, 88);
            this.lblAppointmentFor.Name = "lblAppointmentFor";
            this.lblAppointmentFor.Size = new System.Drawing.Size(203, 20);
            this.lblAppointmentFor.TabIndex = 5;
            this.lblAppointmentFor.Text = "What the appointment is for?";
            // 
            // bttnSubmit
            // 
            this.bttnSubmit.Location = new System.Drawing.Point(20, 144);
            this.bttnSubmit.Name = "bttnSubmit";
            this.bttnSubmit.Size = new System.Drawing.Size(85, 29);
            this.bttnSubmit.TabIndex = 6;
            this.bttnSubmit.Text = "Submit";
            this.bttnSubmit.UseVisualStyleBackColor = true;
            this.bttnSubmit.Click += new System.EventHandler(this.bttnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttnDelete);
            this.groupBox1.Controls.Add(this.txtbxDate);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.bttnSubmit);
            this.groupBox1.Controls.Add(this.txtbxTime);
            this.groupBox1.Controls.Add(this.lblAppointmentFor);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.txtbxAppointmentFor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 193);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make Appointment";
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(188, 144);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(85, 29);
            this.bttnDelete.TabIndex = 8;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // txtbxDate
            // 
            this.txtbxDate.Location = new System.Drawing.Point(20, 46);
            this.txtbxDate.Name = "txtbxDate";
            this.txtbxDate.PlaceholderText = "DD/MM/YYYY";
            this.txtbxDate.Size = new System.Drawing.Size(150, 27);
            this.txtbxDate.TabIndex = 7;
            // 
            // dataGridViewAppointment
            // 
            this.dataGridViewAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointment.Location = new System.Drawing.Point(15, 34);
            this.dataGridViewAppointment.Name = "dataGridViewAppointment";
            this.dataGridViewAppointment.RowHeadersWidth = 51;
            this.dataGridViewAppointment.RowTemplate.Height = 29;
            this.dataGridViewAppointment.Size = new System.Drawing.Size(430, 175);
            this.dataGridViewAppointment.TabIndex = 8;
            this.dataGridViewAppointment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppointment_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewAppointment);
            this.groupBox2.Location = new System.Drawing.Point(332, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 244);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Appointments";
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 274);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AppointmentForm";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtbxTime;
        private Label lblDate;
        private TextBox txtbxAppointmentFor;
        private Label lblTime;
        private Label lblAppointmentFor;
        private Button bttnSubmit;
        private GroupBox groupBox1;
        private DataGridView dataGridViewAppointment;
        private GroupBox groupBox2;
        private TextBox txtbxDate;
        private Button bttnDelete;
    }
}