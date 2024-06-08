
using System;
using MySqlConnector;
namespace dbConnectivity
{
    class ConnectArchitecture
    {
        static void Main1(String[] args)
        {
            // STEP 1
            Console.WriteLine("Define Connection");

            String str = "Server=localhost; userid=root ; password=root; database=car_pooling";

            // STEP 2
            Console.WriteLine("Create Connection");

            using (MySqlConnection conn = new MySqlConnection(str))
            {
                conn.Open();
                Console.WriteLine("Connection done....");

                //STEP 3
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM passenger";


                    //STEP 4 Read Data

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        { 
                            Console.WriteLine(reader.GetInt32(0)+" "+ reader.GetString(1)+ " " + reader.GetString(2) + " " + reader.GetString(3) + " " + reader.GetString(4) + " " + reader.GetDateTime(5) + " " + reader.GetString(6) + " " + reader.GetString(7));
                            
                        }

                        //STEP 5
                        conn.Close();
                    }

                }
            }
        }
    }
}
