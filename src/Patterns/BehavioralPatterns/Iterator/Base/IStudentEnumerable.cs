using Iterator.Implementations;

namespace Iterator.Base;

public interface IStudentEnumerable
{
    IStudentIterator CreateEnumerator();
    int Count { get; set; }
    Student this[int index] { get; }
}