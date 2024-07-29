using CSharp.GenericAdoServices.Models;
using PluralizeService.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.GenericAdoServices.Services;

public interface IService<T> where T : BaseEntity
{
    Task<bool> Add(T entity);
    Task<bool> Update(T entity);
    //Task<bool> Delete(T entity);
    //Task<bool> Delete(int id);
    //Task<T> GetById(int id);
    //Task<IEnumerable<T>> GetAll();
}


public class Service<T> : IService<T> where T : BaseEntity
{
    private string GetTableName<T>() where T : BaseEntity
    {
        return PluralizationProvider.Pluralize(typeof(T).Name);
    }
    public async Task<bool> Add(T entity)
    {

        Console.WriteLine(typeof(T).Name);
        string connection = "Server=ASUS;database=Northwind;Integrated Security=true";

        using SqlConnection sqlConnection = new(connection);
        using SqlCommand sqlCommand = new("INSERT INTO Categories(CategoryName, Description) VALUES(@CategoryName, @Description)", sqlConnection);

        sqlCommand.Parameters.AddWithValue("@CategoryName", "asd");
        sqlCommand.Parameters.AddWithValue("@Description", "dsadasd");

        if (sqlConnection.State == System.Data.ConnectionState.Closed)
        {
            await sqlConnection.OpenAsync();
        }

        bool result = await sqlCommand.ExecuteNonQueryAsync() > 0;

        sqlConnection.Close();
        return result;
    }
    public async Task<bool> Update(T entity)
    {
        throw new NotImplementedException();
    }
}
