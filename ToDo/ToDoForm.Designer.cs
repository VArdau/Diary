namespace Coursework1Form.ToDo
{
    partial class ToDoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxToDo = new System.Windows.Forms.TextBox();
            this.bttnSubmit = new System.Windows.Forms.Button();
            this.lstTodo = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttnFinished = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbxToDo);
            this.groupBox1.Controls.Add(this.bttnSubmit);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "To Do ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter the tasks:";
            // 
            // txtbxToDo
            // 
            this.txtbxToDo.Location = new System.Drawing.Point(10, 56);
            this.txtbxToDo.Name = "txtbxToDo";
            this.txtbxToDo.Size = new System.Drawing.Size(120, 27);
            this.txtbxToDo.TabIndex = 5;
            // 
            // bttnSubmit
            // 
            this.bttnSubmit.Location = new System.Drawing.Point(10, 89);
            this.bttnSubmit.Name = "bttnSubmit";
            this.bttnSubmit.Size = new System.Drawing.Size(120, 29);
            this.bttnSubmit.TabIndex = 3;
            this.bttnSubmit.Text = "Submit";
            this.bttnSubmit.UseVisualStyleBackColor = true;
            this.bttnSubmit.Click += new System.EventHandler(this.bttnSubmit_Click);
            // 
            // lstTodo
            // 
            this.lstTodo.FormattingEnabled = true;
            this.lstTodo.ItemHeight = 20;
            this.lstTodo.Location = new System.Drawing.Point(17, 23);
            this.lstTodo.Name = "lstTodo";
            this.lstTodo.Size = new System.Drawing.Size(186, 144);
            this.lstTodo.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttnFinished);
            this.groupBox2.Controls.Add(this.lstTodo);
            this.groupBox2.Location = new System.Drawing.Point(186, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 216);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View List";
            // 
            // bttnFinished
            // 
            this.bttnFinished.Location = new System.Drawing.Point(17, 176);
            this.bttnFinished.Name = "bttnFinished";
            this.bttnFinished.Size = new System.Drawing.Size(186, 29);
            this.bttnFinished.TabIndex = 7;
            this.bttnFinished.Text = "Finished Task";
            this.bttnFinished.UseVisualStyleBackColor = true;
            this.bttnFinished.Click += new System.EventHandler(this.bttnFinished_Click);
            // 
            // ToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 237);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ToDoForm";
            this.Text = "ToDoForm";
            this.Load += new System.EventHandler(this.ToDoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private Button bttnSubmit;
        private TextBox txtbxToDo;
        private ListBox lstTodo;
        private Label label1;
        private GroupBox groupBox2;
        private Button bttnFinished;
    }
}