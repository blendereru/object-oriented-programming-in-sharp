## Abstraction
Abstraction focuses on modeling the relevant attributes and interactions of entities to define an abstract
representation of a system. Abstraction involves creating simplified models of complex real-world entities,
focusing only on the essential characteristics that are relevant to the context of the application.

From that point, it might seem that there is no difference between `abstraction` and `encapsulation`.
Let's clarify the difference:
* Abstraction means generalizing, which focuses on what the object does instead of how it does it. Consider
the following example:
```csharp
public interface IFileStorage
{
    Task Save(params FileInfo[] files);
}
```
We define contract that any file storage class must fulfill, specifying what operation (Save) should be 
performed, `without` detailing how it should be implemented. This allows different classes to implement the 
`Save` method in various ways—such as saving to a local disk, cloud storage, without the calling code 
needing to know the specifics.
* Encapsulation hides internal details of how object works. The `Save` method in child classes now perform
different tasks based on the purpose of the class. The internal logic of how files are saved to the local
disk—such as creating directories and copying files—is encapsulated within the `LocalDisk` class.
This encapsulation ensures that the internal state and implementation details of `LocalDisk` are hidden from
the outside, promoting modularity and reducing the risk of unintended interference.

So, abstraction provides a contract. This is achieved through `interfaces` or `abstract classes`. We
know that the `Save` method performs saving the files, but the details on how it is saved is encapsulated
in each definition of the child classes. If we added an extra storage provider, like a `database`, we agree
on the contract to use the `Save` method, but encapsulate the specific implementation details of how the
files are stored within the db.