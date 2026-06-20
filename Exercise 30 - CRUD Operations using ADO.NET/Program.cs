using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Server=.;Database=EmployeeDB;Trusted_Connection=True;";

        using SqlConnection con =
            new SqlConnection(connectionString);

        con.Open();

        SqlCommand insertCmd =
            new SqlCommand(
            "INSERT INTO Employees(Name) VALUES('Hari')",
            con);

        insertCmd.ExecuteNonQuery();

        SqlCommand selectCmd =
            new SqlCommand(
            "SELECT * FROM Employees",
            con);

        SqlDataReader reader =
            selectCmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine(reader["Name"]);
        }

        reader.Close();
    }
}