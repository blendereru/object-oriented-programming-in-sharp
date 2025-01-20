using Facade;

var connectionString = "Server=localhost, 1433;User Id=sa;Password=my_secrEt_password;";
var firstOperation = "INSERT INTO Users (Name, Age) VALUES ('Alice', 30)";
var secondOperation = "UPDATE Users SET Age = 31 WHERE Name = 'Alice'";
var query = new DbQuery(connectionString);
query.ExecuteQuery(firstOperation, secondOperation);