namespace Coursework1Form.Diary
{
    partial class ViewingDiaryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbxDiary = new System.Windows.Forms.RichTextBox();
            this.lstDate = new System.Windows.Forms.ListBox();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttnSearch);
            this.groupBox1.Controls.Add(this.txtbxSearch);
            this.groupBox1.Controls.Add(this.txtbxDiary);
            this.groupBox1.Controls.Add(this.lstDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diary History";
            // 
            // txtbxDiary
            // 
            this.txtbxDiary.Location = new System.Drawing.Point(160, 60);
            this.txtbxDiary.Name = "txtbxDiary";
            this.txtbxDiary.ReadOnly = true;
            this.txtbxDiary.Size = new System.Drawing.Size(297, 210);
            this.txtbxDiary.TabIndex = 1;
            this.txtbxDiary.Text = "";
            // 
            // lstDate
            // 
            this.lstDate.FormattingEnabled = true;
            this.lstDate.ItemHeight = 20;
            this.lstDate.Location = new System.Drawing.Point(6, 26);
            this.lstDate.Name = "lstDate";
            this.lstDate.Size = new System.Drawing.Size(122, 244);
            this.lstDate.TabIndex = 0;
            this.lstDate.SelectedIndexChanged += new System.EventHandler(this.lstDate_SelectedIndexChanged);
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxSearch.Location = new System.Drawing.Point(160, 22);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(223, 27);
            this.txtbxSearch.TabIndex = 2;
            // 
            // bttnSearch
            // 
            this.bttnSearch.Location = new System.Drawing.Point(389, 22);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(68, 29);
            this.bttnSearch.TabIndex = 3;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // ViewingDiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 327);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewingDiaryForm";
            this.Text = "ViewingDiaryForm";
            this.Load += new System.EventHandler(this.ViewingDiaryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private RichTextBox txtbxDiary;
        private ListBox lstDate;
        private Button bttnSearch;
        private TextBox txtbxSearch;
    }
}