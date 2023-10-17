namespace Coursework1Form
{
    partial class DailyCheckupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyCheckupForm));
            this.lblTodayFeeling = new System.Windows.Forms.Label();
            this.bttnSave = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtbxDate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSaved = new System.Windows.Forms.Label();
            this.bttnViewDiary = new System.Windows.Forms.Button();
            this.txtbxDiary = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbxRate = new System.Windows.Forms.TextBox();
            this.lblForRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuote = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTodayFeeling
            // 
            this.lblTodayFeeling.AutoSize = true;
            this.lblTodayFeeling.Location = new System.Drawing.Point(15, 56);
            this.lblTodayFeeling.Name = "lblTodayFeeling";
            this.lblTodayFeeling.Size = new System.Drawing.Size(118, 20);
            this.lblTodayFeeling.TabIndex = 1;
            this.lblTodayFeeling.Text = "How was today?";
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(15, 205);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(99, 29);
            this.bttnSave.TabIndex = 2;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // txtbxDate
            // 
            this.txtbxDate.Location = new System.Drawing.Point(65, 26);
            this.txtbxDate.Name = "txtbxDate";
            this.txtbxDate.PlaceholderText = "DD/MM/YYYY";
            this.txtbxDate.Size = new System.Drawing.Size(137, 27);
            this.txtbxDate.TabIndex = 4;
            this.txtbxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSaved);
            this.groupBox1.Controls.Add(this.bttnViewDiary);
            this.groupBox1.Controls.Add(this.txtbxDiary);
            this.groupBox1.Controls.Add(this.bttnSave);
            this.groupBox1.Controls.Add(this.txtbxDate);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblTodayFeeling);
            this.groupBox1.Location = new System.Drawing.Point(21, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 247);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write in the Diary";
            // 
            // lblSaved
            // 
            this.lblSaved.AutoSize = true;
            this.lblSaved.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaved.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSaved.Location = new System.Drawing.Point(169, 56);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(0, 20);
            this.lblSaved.TabIndex = 7;
            // 
            // bttnViewDiary
            // 
            this.bttnViewDiary.Location = new System.Drawing.Point(129, 205);
            this.bttnViewDiary.Name = "bttnViewDiary";
            this.bttnViewDiary.Size = new System.Drawing.Size(99, 29);
            this.bttnViewDiary.TabIndex = 6;
            this.bttnViewDiary.Text = "View Diary";
            this.bttnViewDiary.UseVisualStyleBackColor = true;
            this.bttnViewDiary.Click += new System.EventHandler(this.bttnViewDiary_Click);
            // 
            // txtbxDiary
            // 
            this.txtbxDiary.Location = new System.Drawing.Point(15, 79);
            this.txtbxDiary.Name = "txtbxDiary";
            this.txtbxDiary.Size = new System.Drawing.Size(213, 120);
            this.txtbxDiary.TabIndex = 5;
            this.txtbxDiary.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbxRate);
            this.groupBox2.Controls.Add(this.lblForRate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(291, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 76);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Day Rating";
            // 
            // txtbxRate
            // 
            this.txtbxRate.Location = new System.Drawing.Point(55, 25);
            this.txtbxRate.Name = "txtbxRate";
            this.txtbxRate.PlaceholderText = "1-10";
            this.txtbxRate.Size = new System.Drawing.Size(40, 27);
            this.txtbxRate.TabIndex = 10;
            this.txtbxRate.TextChanged += new System.EventHandler(this.txtbxRate_TextChanged_1);
            // 
            // lblForRate
            // 
            this.lblForRate.AutoSize = true;
            this.lblForRate.Location = new System.Drawing.Point(10, 53);
            this.lblForRate.Name = "lblForRate";
            this.lblForRate.Size = new System.Drawing.Size(0, 20);
            this.lblForRate.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rate:";
            // 
            // lblQuote
            // 
            this.lblQuote.Location = new System.Drawing.Point(21, 289);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(533, 25);
            this.lblQuote.TabIndex = 8;
            this.lblQuote.Text = "...";
            this.lblQuote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Have a great day!";
            // 
            // DailyCheckupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 328);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DailyCheckupForm";
            this.Text = "Daily Checkup";
            this.Load += new System.EventHandler(this.DailyCheckupForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTodayFeeling;
        private Button bttnSave;
        private Label lblDate;
        private TextBox txtbxDate;
        private GroupBox groupBox1;
        private RichTextBox txtbxDiary;
        private GroupBox groupBox2;
        private Label label1;
        private Label lblForRate;
        private Label lblQuote;
        private Button bttnViewDiary;
        private TextBox txtbxRate;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblSaved;
    }
}