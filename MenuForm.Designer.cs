namespace Coursework1Form
{
    partial class MenuForm
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
            this.bttnAppointment = new System.Windows.Forms.Button();
            this.bttnDiary = new System.Windows.Forms.Button();
            this.bttnToDo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnAppointment
            // 
            this.bttnAppointment.Location = new System.Drawing.Point(16, 26);
            this.bttnAppointment.Name = "bttnAppointment";
            this.bttnAppointment.Size = new System.Drawing.Size(111, 29);
            this.bttnAppointment.TabIndex = 0;
            this.bttnAppointment.Text = "Appointment";
            this.bttnAppointment.UseVisualStyleBackColor = true;
            this.bttnAppointment.Click += new System.EventHandler(this.bttnAppointment_Click);
            // 
            // bttnDiary
            // 
            this.bttnDiary.Location = new System.Drawing.Point(133, 26);
            this.bttnDiary.Name = "bttnDiary";
            this.bttnDiary.Size = new System.Drawing.Size(102, 29);
            this.bttnDiary.TabIndex = 1;
            this.bttnDiary.Text = "Checkup";
            this.bttnDiary.UseVisualStyleBackColor = true;
            this.bttnDiary.Click += new System.EventHandler(this.bttnDiary_Click);
            // 
            // bttnToDo
            // 
            this.bttnToDo.Location = new System.Drawing.Point(240, 26);
            this.bttnToDo.Name = "bttnToDo";
            this.bttnToDo.Size = new System.Drawing.Size(72, 29);
            this.bttnToDo.TabIndex = 2;
            this.bttnToDo.Text = "To Do";
            this.bttnToDo.UseVisualStyleBackColor = true;
            this.bttnToDo.Click += new System.EventHandler(this.bttnToDo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttnToDo);
            this.groupBox1.Controls.Add(this.bttnDiary);
            this.groupBox1.Controls.Add(this.bttnAppointment);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 97);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bttnAppointment;
        private Button bttnDiary;
        private Button bttnToDo;
        private GroupBox groupBox1;
    }
}