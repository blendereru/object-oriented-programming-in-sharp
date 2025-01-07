## Singleton
Singleton pattern guarantees that for specific class, only the single instance is created. So, you should use this
pattern when you need the single instance of the object during the entire lifetime of the program.
Singletons allow `lazy` object initialization, and this is its main difference between global fields.
## Singleton pattern != DI singleton
Even though Singleton pattern by definition is similar to Singleton lifetime-d services in DI, they differ.
Singleton services in Dependency Injection(DI) live during the lifetime of the DI containers.

```csharp
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<MySingletonService>();

using (var serviceProvider = services.BuildServiceProvider())
{
    var singleton = serviceProvider.GetRequiredService<MySingletonService>();
    Console.WriteLine("Singleton service is in use.");
}

// When serviceProvider is disposed, MySingletonService is disposed
Console.WriteLine("Root DI container disposed.");
```
Here, the singleton service lives until the end of the `using` block and gets disposed when it exits the block.

The singleton `pattern`, on the other hand, guarantees that a class has exactly one instance throughout the lifetime of the application.

## Lazy loading of Singletion instance
It's better to use `Lazy<Singleton>` to initialize the object creation when it is actually necessary, because there might
be a case when we need to use only the static fields(properties) of the singleton class. In this case, the instance
creation would be unnecessary.

Also, `Lazy<T>` objects are thread-safe. In a multi-threaded environment, the Lazy object will ensure thread safety when multiple
threads try to access the same `GetInstance` method simultaneously.
Example:
```csharp
public class Singleton
{
    private static readonly Lazy<Singleton> lazy = 
        new Lazy<Singleton>(() => new Singleton());
 
    public string Name { get; private set; }
         
    private Singleton()
    {
        Name = System.Guid.NewGuid().ToString();
    }
     
    public static Singleton GetInstance()
    {
        return lazy.Value;
    }
}
```

