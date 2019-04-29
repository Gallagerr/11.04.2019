using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._04
{
  public class DataBase : IDisposable
  {
    protected SqlConnection _connection;

    public DataBase()
    {
      _connection = new SqlConnection(ConfigurationManager.AppSettings["DbConnectionString"]);
      _connection.Open();
    }

    public void Dispose()
    {
      _connection.Close();
    }
  }
}
