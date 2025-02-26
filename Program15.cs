//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Text.Json;

//class Program15
//{
//    static void Main(string[]args)
//    {
//        string connectionString = "Server=YOUR_SERVER;Database=YOUR_DB;User Id=YOUR_USER;Password=YOUR_PASSWORD;";
//        string query = "SELECT ID, Name, Email, Age FROM Employees";

//        List<Dictionary<string, object>> employeeList = new List<Dictionary<string, object>>();

//        using (SqlConnection conn = new SqlConnection(connectionString))
//        {
//            conn.Open();
//            using (SqlCommand cmd = new SqlCommand(query, conn))
//            {
//                using (SqlDataReader reader = cmd.ExecuteReader())
//                {
//                    while (reader.Read())
//                    {
//                        Dictionary<string, object> employee = new Dictionary<string, object>
//                        {
//                            { "ID", reader["ID"] },
//                            { "Name", reader["Name"] },
//                            { "Email", reader["Email"] },
//                            { "Age", reader["Age"] }
//                        };
//                        employeeList.Add(employee);
//                    }
//                }
//            }
//        }

//        string jsonReport = JsonSerializer.Serialize(employeeList, new JsonSerializerOptions { WriteIndented = true });
//        Console.WriteLine(jsonReport);
//    }
//}
