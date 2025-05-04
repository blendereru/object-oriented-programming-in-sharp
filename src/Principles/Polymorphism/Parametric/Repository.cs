namespace Polymorphism.Parametric;

public class Repository<T> where T : class, IEntity, new()
{
    private readonly string _connectionString;
    private readonly string _tableName;

    public Repository(string connectionString, string tableName)
    {
        _connectionString = connectionString;
        _tableName = tableName;
    }

    public void Add(T entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                if (entity is Customer customer)
                {
                    command.CommandText = $"INSERT INTO {_tableName} (Name, Email) VALUES (@Name, @Email)";
                    command.Parameters.AddWithValue("@Name", customer.Name);
                    command.Parameters.AddWithValue("@Email", customer.Email);
                }
                else if (entity is Product product)
                {
                    command.CommandText = $"INSERT INTO {_tableName} (Name, Price) VALUES (@Name, @Price)";
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Price", product.Price);
                }
                // Add additional entity type checks as needed

                command.ExecuteNonQuery();
            }
        }
    }
}