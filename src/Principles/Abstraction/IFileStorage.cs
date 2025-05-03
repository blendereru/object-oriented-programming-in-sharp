namespace Abstraction;

public interface IFileStorage
{
    Task Save(params FileInfo[] files);
}