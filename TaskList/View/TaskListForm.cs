using TaskList.Controller;
using TaskList.Model;

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
    }
}