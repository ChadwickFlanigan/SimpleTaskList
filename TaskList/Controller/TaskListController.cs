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

        /// <summary>
        /// method creating a new TaskList in the database, returns true or false depending on success
        /// </summary>
        /// <param name="taskListName"></param>
        /// <returns></returns>
        public bool CreateTaskList(string taskListName)
        {
            return this._taskListDAL.CreateTaskList(taskListName);
        }
    }
}
