using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1Form.ToDo
{
    public partial class ToDoForm : Form
    {
        public ToDoForm()
        {
            InitializeComponent();
        }

        // adding a task
        string path = "todo.txt";
        private void bttnSubmit_Click(object sender, EventArgs e)
        {
            string newTask = txtbxToDo.Text;
            if (newTask.Length > 0)
            {
                lstTodo.Items.Add(newTask);
            }

            File.AppendAllText(path, newTask + "\n");
            txtbxToDo.Text = "";
        }

        private void ToDoForm_Load(object sender, EventArgs e)
        {
            foreach (string task in File.ReadAllLines(path))
            {
                lstTodo.Items.Add(task);
            }
        }
        // ---

        // finished task
        private void bttnFinished_Click(object sender, EventArgs e)
        {
            string currentlyselected = lstTodo.SelectedItem.ToString();
            lstTodo.Items.Remove(currentlyselected);

            // so you can write the whole list box items instead of doing it one by one, makes it into a list of strings. Converts a listbox into a text file,
            // see https://stackoverflow.com/a/53454503.
            File.WriteAllLines(path, lstTodo.Items.Cast<string>()); 
            // makes sure it saves when its deleted
        }
        // ---
    }
}
