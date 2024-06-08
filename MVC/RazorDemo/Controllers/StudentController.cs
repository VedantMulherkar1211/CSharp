using Microsoft.AspNetCore.Mvc;
using MySqlConnector;

namespace RazorDemo.Controllers
{
    public class StudentController : Controller
    {
        static string connect = "server=localhost;Uid=root;Pwd=root;database=dotnet";
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(string name)
        {
            string msg = $"Welcome{name} in .net World";
            return View((object)msg);
        }

        public static void crud()
        {
            InsertRecord();
            DisplayRecord();
            UpdateRecord();
            DeleteRecord();
            GetTotalCountOfRecords();
        }

        private static void GetTotalCountOfRecords()
        {
            using (MySqlConnection con = new MySqlConnection())
            {
                con.Open();
                using (MySqlCommand cmd = con.CreateCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "Insert into emp(Id,Ename,Salary,Address)" + "values(@id,@ename,@sal,@add)";
                    cmd.Parameters.AddWithValue("@id", 1);
                    cmd.Parameters.AddWithValue("@ename", "vedant");
                    cmd.Parameters.AddWithValue("@sal", 80000);
                    cmd.Parameters.AddWithValue("@add", "Pune");

                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.Write("Record Inserted Successfully!");
                    }
                    else
                    {
                        Console.Write("Inserted to failed");
                    }

                }
            }
        }

        private static void InsertRecord()
        {
            throw new NotImplementedException();
        }

        private static void DisplayRecord()
        {
            throw new NotImplementedException();
        }

        private static void UpdateRecord()
        {
            throw new NotImplementedException();
        }
        private static void DeleteRecord() 
        {
            throw new NotImplementedException();
        }
    }
}
