using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList.Model
{
    /// <summary>
    /// class for Task objects, with id, name, description, and completed status.
    /// </summary>
    public class Task
    {
        public int TaskID { get; set; }
        public int TaskListID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public bool Complete { get; set; }
    }
}
