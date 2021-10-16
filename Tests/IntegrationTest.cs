using System;
using Microsoft.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConnectToSqlServer()
        {
            var connStr = "Server=localhost;Database=master;User Id=sa;Password=Pa55word!;";
            var conn = new SqlConnection(connStr);
            conn.Open();

            Console.WriteLine("OK connected!");
        }
    }
}