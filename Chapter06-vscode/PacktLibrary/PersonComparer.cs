namespace Packt.Shared;
public class PersonComparer : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        if (x is null || y is null)
        {
            return 0;
        }

        int result = 0;

        if ((x.Name is not null) && (y.Name is not null))
        {
            // Compare the Name lengths...
            result = x.Name.Length.CompareTo(y.Name.Length);
            // ...if they are equal...
            if (result == 0)
            {
                // ...then compare by the Names...
                return x.Name.CompareTo(y.Name);
            }
            else // result will be -1 or 1
            {
                // ...otherwise compare by the lengths.
                return result;
            }
        }
        else
        {
            return result;
        }
    }
}
