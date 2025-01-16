 using Memento;

 var transaction = new Transaction();
 var manager = new TransactionManager();
 transaction.DoOperation("INSERT INTO Users (Name, Age) VALUES ('Alice', 30)");
 manager.SaveTransactionOperation(transaction);
 transaction.DoOperation("UPDATE Users SET Age = 31 WHERE Name = 'Alice'"); 
 manager.UndoTransaction(transaction);