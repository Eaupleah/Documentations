using System;
using System.Data;
using System.Data.SqlClient;


namespace CSharp.AcademyManagement.Models;

public class StudentManager
{
    private static readonly string
        ConnectionString = "server=ASUS;database=AcademyManagement;Integrated Security=True;";

    public static void CreateStudent(string firstName, string lastName, string username, string password)
    {
        using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
        using SqlCommand cmd = new SqlCommand
        {
            Connection = sqlConnection,
            CommandType = CommandType.Text,
            CommandText =
                @"INSERT INTO Students (FirstName, LastName, Username, Password) VALUES (@FirstName, @LastName, @Username, @Password)"
        };

        cmd.Parameters.AddWithValue("@FirstName", firstName);
        cmd.Parameters.AddWithValue("@LastName", lastName);
        cmd.Parameters.AddWithValue("@Username", username);
        cmd.Parameters.AddWithValue("@Password", password);

        try
        {
            sqlConnection.Open();

            int rowsAffected = cmd.ExecuteNonQuery();
            string resultMessage = rowsAffected > 0 ? "Student added successfully." : "Failed to add student.";

            Console.WriteLine(resultMessage);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            sqlConnection.Close();
        }
    }

    public static void DeleteStudent(int id)
    {
        using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
        using SqlCommand cmd = new SqlCommand
        {
            Connection = sqlConnection,
            CommandText = "DELETE FROM Students WHERE Id = @Id",
            CommandType = CommandType.Text
        };

        cmd.Parameters.AddWithValue("@Id", id);

        try
        {
            sqlConnection.Open();

            int rowsAffected = cmd.ExecuteNonQuery();
            string resultMessage =
                rowsAffected > 0 ? "Student deleted successfully." : $"No student found with Id {id}.";

            Console.WriteLine(resultMessage);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            sqlConnection.Close();
        }
    }

    public static void UpdateStudent(int id, string? firstName, string? lastName, string? username, string? password)
    {
        using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
        using SqlCommand cmd = new SqlCommand
        {
            Connection = sqlConnection,
            CommandText = @"
             UPDATE Students
             SET FirstName = @FirstName,
                 LastName = @LastName,
                 Username = @Username,
                 Password = @Password
             WHERE Id = @Id",
            CommandType = CommandType.Text
        };

        cmd.Parameters.AddWithValue("@FirstName", firstName ?? (object)DBNull.Value);
        cmd.Parameters.AddWithValue("@LastName", lastName ?? (object)DBNull.Value);
        cmd.Parameters.AddWithValue("@Username", username ?? (object)DBNull.Value);
        cmd.Parameters.AddWithValue("@Password", password ?? (object)DBNull.Value);
        cmd.Parameters.AddWithValue("@Id", id);

        try
        {
            sqlConnection.Open();

            int rowsAffected = cmd.ExecuteNonQuery();
            string resultMessage =
                rowsAffected > 0 ? "Student updated successfully." : $"No student found with Id {id}.";

            Console.WriteLine(resultMessage);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            sqlConnection.Close();
        }
    }
}