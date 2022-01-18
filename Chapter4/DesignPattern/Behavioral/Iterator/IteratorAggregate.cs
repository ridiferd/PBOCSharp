using System.Collections;
abstract class IteratorAggregate : IEnumerable
{
    public abstract IEnumerator GetEnumerator();
}