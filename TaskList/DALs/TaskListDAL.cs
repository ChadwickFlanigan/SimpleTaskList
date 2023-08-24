using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskList.Model;

namespace TaskList.DALs
{
    internal class TaskListDAL
    {
        /// <summary>
        /// method returning a list of objects of all TaskList in the database
        /// </summary>
        /// <returns></returns>
        public List<Model.TaskList> GetTaskLists()
        {
            List<Model.TaskList> taskLists = new List<Model.TaskList>();

            using (SqlConnection connection = TaskListConnectionString.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM TaskList", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Model.TaskList taskList = new Model.TaskList
                    {
                       TaskListID = Convert.ToInt32(reader["ListID"]),
                       TaskListName = Convert.ToString(reader["ListName"])
                    };
                    taskLists.Add(taskList);
                }
            }
            return taskLists;
        }

        /// <summary>
        /// method creating a new TaskList in the database, returns true or false depending on success
        /// </summary>
        /// <param name="taskListName"></param>
        /// <returns></returns>
        public bool CreateTaskList(string taskListName)
        {
            using (SqlConnection connection = TaskListConnectionString.GetConnection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO TaskList(ListName) VALUES(@listName);", connection);
                command.Parameters.AddWithValue("@listName", taskListName);
                connection.Open();

                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
