using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace WindowsFormsTest
{
    class DataAccess
    {
        //Deze methodes zijn gevoelig voor SQL injectie. Oplossing: stored procedures.

        public List<FirstName> GetNames()
        {
            using (IDbConnection connection = new SqlConnection(connectionString: Helper.CnnVal("WindowsFormsTest.Properties.Settings.Database1ConnectionString")))
            {
                var output = connection.Query<FirstName>($"SELECT * FROM dbo.Names").ToList();
                return output;
            }
        } 

        public void AddName(string name)
        {
            using (IDbConnection connection = new SqlConnection(connectionString: Helper.CnnVal("WindowsFormsTest.Properties.Settings.Database1ConnectionString")))
            {
                List<FirstName> firstNames = new List<FirstName>();
                firstNames.Add(new FirstName { Name = name });
                connection.Execute($"INSERT INTO dbo.Names (Name) VALUES ('{name}')");
            }
        }
    }
}
