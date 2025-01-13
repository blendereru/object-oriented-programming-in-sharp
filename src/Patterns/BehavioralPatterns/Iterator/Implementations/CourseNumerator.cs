using Iterator.Base;

namespace Iterator.Implementations;

public class CourseNumerator : IStudentIterator
{
    private IStudentEnumerable _aggregate;
    private int index = 0;
    public CourseNumerator(IStudentEnumerable aggregate)
    {
        _aggregate = aggregate;
    }
    public Student Next()
    {
        return _aggregate[index++];
    }
    public bool HasNext()
    {
        return index < _aggregate.Count;
    }
}