using RazorApp.Models;
using MySqlConnector;
using System.Collections.Generic;

namespace RazorApp.DAL
{
    public class EmpDAL
    {
        public int InsertEmp(Employee employee)
        {
            int res = 0;
            string con = "Server=localhost;userid=root;password=12345;database=empdb";
            using (MySqlConnection conConn = new MySqlConnection(con))
            {
                try
                {
                    conConn.Open();
                    string Query = "Insert into emp values(@id,@name,@sal,@add,@gender)";
                    MySqlCommand cmd = new MySqlCommand(Query, conConn);
                    cmd.Parameters.AddWithValue("@id", employee.Id);
                    cmd.Parameters.AddWithValue("@name", employee.Name);
                    cmd.Parameters.AddWithValue("@sal", employee.Salary);
                    cmd.Parameters.AddWithValue("@add", employee.Address);
                    cmd.Parameters.AddWithValue("@gender", employee.Gender);
                    res = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }

            }
            return res;


        }

        public List<Employee> GetEmpList()
        {
            List < Employee > emps = new List < Employee >();
            string con = "Server=localhost;userid=root;password=12345;database=empdb";
            using (MySqlConnection conConn = new MySqlConnection(con))
            {
                try
                {
                    conConn.Open();
                    string Query = "Select * from emp";
                    MySqlCommand cmd = new MySqlCommand(Query, conConn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee emp = new Employee() 
                        {Id= Convert.ToInt32(reader[0]),
                            Name = Convert.ToString(reader[1]),
                            Salary = (float)Convert.ToDecimal(reader[2]),
                            Address = Convert.ToString(reader[3]),
                            Gender = Convert.ToString(reader[4])
                        };
                        emps.Add( emp );

                    }
                }
                catch (Exception ex)
                {

                }

            }
            return emps;


        }

        public Employee GetEmp(int id)
        {
            Employee emp = null;
            string con = "Server=localhost;userid=root;password=12345;database=empdb";
            using (MySqlConnection conConn = new MySqlConnection(con))
            {
                try
                {
                    conConn.Open();
                    string Query = "Select * from emp where Id= @id";
                    MySqlCommand cmd = new MySqlCommand(Query, conConn);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                         emp = new Employee()
                        {
                            Id = Convert.ToInt32(reader[0]),
                            Name = Convert.ToString(reader[1]),
                            Salary = (float)Convert.ToDecimal(reader[2]),
                            Address = Convert.ToString(reader[3]),
                            Gender = Convert.ToString(reader[4])
                        };
                        

                    }
                }
                catch (Exception ex)
                {

                }

            }
            return emp;


        }

        public int UpdateEmp(Employee employee)
        {
            int res = 0;
            string con = "Server=localhost;userid=root;password=12345;database=empdb";
            using (MySqlConnection conConn = new MySqlConnection(con))
            {
                try
                {
                    conConn.Open();
                    string Query = "Update  emp  set ename = @name," +
                        "salary= @sal," +
                        "Address= @add,Gender = @gender where id=@id";
                    MySqlCommand cmd = new MySqlCommand(Query, conConn);
                    cmd.Parameters.AddWithValue("@id", employee.Id);
                    cmd.Parameters.AddWithValue("@name", employee.Name);
                    cmd.Parameters.AddWithValue("@sal", employee.Salary);
                    cmd.Parameters.AddWithValue("@add", employee.Address);
                    cmd.Parameters.AddWithValue("@gender", employee.Gender);
                    res = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }

            }
            return res;


        }

        public int DeleteEmp(int id)
        {
            int res =0;
            string con = "Server=localhost;userid=root;password=12345;database=empdb";
            using (MySqlConnection conConn = new MySqlConnection(con))
            {
                try
                {
                    conConn.Open();
                    string Query = "Delete from Emp where Id= @id";
                    MySqlCommand cmd = new MySqlCommand(Query, conConn);
                    cmd.Parameters.AddWithValue("@id", id);
                    res= cmd.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {

                }

            }
            return res;


        }

    }
}
