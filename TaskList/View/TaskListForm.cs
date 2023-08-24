using TaskList.Controller;
using TaskList.Model;
using TaskList.View;

namespace TaskList
{
    public partial class TaskListForm : Form
    {
        private List<Model.TaskList> _taskList;
        private TaskListController taskListController;

        /// <summary>
        /// constructor
        /// </summary>
        public TaskListForm()
        {
            InitializeComponent();
            this.taskListController = new TaskListController();
            this._taskList = this.taskListController.GetTaskLists();
            this.listDataGridView.DataSource = this._taskList;
        }

        private void TaskListForm_Load(object sender, EventArgs e)
        {

        }

        private void createListButton_Click(object sender, EventArgs e)
        {
            using (CreateTaskListForm createTaskListForm = new CreateTaskListForm())
            {
                createTaskListForm.ShowDialog();
            }
            this.refreshDataGrid();
        }

        private void refreshDataGrid()
        {
            this._taskList = this.taskListController.GetTaskLists();
            this.listDataGridView.DataSource = this._taskList;
        }
    }
}