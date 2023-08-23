using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList.Model
{
    /// <summary>
    /// class for TaskList objects, a list id, list of tasks, and the name of the list
    /// </summary>
    public class TaskList
    {
        public int TaskListID { get; set; }
        public String TaskListName { get; set; }
    }
}
