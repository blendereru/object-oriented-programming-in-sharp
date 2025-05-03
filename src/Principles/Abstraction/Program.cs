using Abstraction;

var cloudStorage = new CloudStorage();
await cloudStorage.Save(new FileInfo("path/to/file1.txt"), new FileInfo("path/to/file2.jpg"));
//or
var fileStorage = new LocalDisk("C:/Users/User/");
await fileStorage.Save(new FileInfo("path/to/file1.txt"), new FileInfo("path/to/file2.jpg"));