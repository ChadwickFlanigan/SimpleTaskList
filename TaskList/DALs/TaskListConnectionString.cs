

using Microsoft.Data.SqlClient;

namespace TaskList.DALs
{
    /// <summary>
    /// class creating the connection string to the database
    /// </summary>
    public static class TaskListConnectionString
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=localhost;Initial Catalog=SimpleTaskList;Integrated Security=True;");
        }
    }
}
