using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskList.DALs;

namespace TaskList.Controller
{
    internal class TaskListController
    {
        private TaskListDAL _taskListDAL;

        public TaskListController()
        {
            this._taskListDAL = new TaskListDAL();
        }

        public List<Model.TaskList> GetTaskLists()
        {
            return this._taskListDAL.GetTaskLists();
        }
    }
}
