﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskList.Controller;

namespace TaskList.View
{
    public partial class CreateTaskListForm : Form
    {
        private TaskListController _taskListController;

        public CreateTaskListForm()
        {
            InitializeComponent();
            this._taskListController = new TaskListController();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (this.listNameTextBox.Text == String.Empty)
            {
                MessageBox.Show("A Task List must have a name!");
                return;
            }
            if (this._taskListController.CreateTaskList(this.listNameTextBox.Text) == false)
            {
                MessageBox.Show("There was a problem creating this list :(");
            } else
            {
                this.Close();
            }
        }
    }
}
