using Iterator.Implementations;

namespace Iterator.Base;

public interface IStudentIterator
{
    bool HasNext();
    Student Next();
}