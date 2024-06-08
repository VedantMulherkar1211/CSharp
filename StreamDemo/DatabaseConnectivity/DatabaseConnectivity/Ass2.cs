using MySqlConnector;
using System;
using System.Data;

namespace dbConnectivity
{
    class Ass2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Define Connection");

            String str = "Server=localhost; userid=root; password=root; database=knowitdb";

            
            Console.WriteLine("Create Connection");

            do
            {
                Ass2 obj = new Ass2();

                Console.WriteLine("Enter the choice")
                var ch=Console.ReadLine();

            } while (ch != 0);
        }

        public void Display(String str)
        {
            // STEP 1
            using (MySqlConnection conn = new MySqlConnection(str))
            {
                conn.Open();
                Console.WriteLine("Connection done....");

                // STEP 3
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM emp";

                    // STEP 4 Read Data
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader[0].ToString() + " " +
                                              reader[1].ToString() + " " +
                                              reader[2].ToString() + " " +
                                              reader[3].ToString() + " " +
                                              reader[4].ToString() + " " +
                                              reader[5].ToString() + " " +
                                              reader[6].ToString() + " " +
                                              reader[7].ToString());
                        }

                        // STEP 5
                        conn.Close();
                    }
                }
            }
        }

        public void Insert(String str)
        {
            using (MySqlConnection conn = new MySqlConnection(str))
            {
                conn.Open();
                Console.WriteLine("Connection done...");


                String query = "INSERT INTO emp VALUES (@EMPNO, @ENAME, @JOB, @MGR, @HIREDATE, @SAL, @COMM, @DEPTNO)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@EMPNO", 10);
                cmd.Parameters.AddWithValue("@ENAME", "vedant1211");
                cmd.Parameters.AddWithValue("@JOB", "singer");
                cmd.Parameters.AddWithValue("@MGR", 2565);
                cmd.Parameters.AddWithValue("@HIREDATE", DateTime.Now);
                cmd.Parameters.AddWithValue("@SAL", 700.00);
                cmd.Parameters.AddWithValue("@COMM", 4520.00);
                cmd.Parameters.AddWithValue("@DEPTNO", 30);

                int res = cmd.ExecuteNonQuery();
                Console.WriteLine(res + " Record(s) get inserted");
                conn.Close();
            }
        }

        public void Update(String str)
        {
            using (MySqlConnection conn = new MySqlConnection(str))
            {
                conn.Open();
                Console.WriteLine("Connection done...");

               
                String query = "UPDATE emp SET Ename = @name, sal = @sal WHERE EMPNO = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                
                cmd.Parameters.AddWithValue("@name", "joe");
                cmd.Parameters.AddWithValue("@sal", 7000.67f);
                cmd.Parameters.AddWithValue("@id", 123); 

                int res = cmd.ExecuteNonQuery();
                Console.WriteLine(res + " Record(s) Updated");
                conn.Close();
            }
        }

        public void Delete(String str)
        {
            using (MySqlConnection conn = new MySqlConnection(str))
            {
                conn.Open();
                Console.WriteLine("Connection done...");


                String query = "Delete from emp where empno=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", 123);
                int res = cmd.ExecuteNonQuery();
                Console.WriteLine(res + "Record Deleted");
                conn.Close();
            }
        }

    }
}
