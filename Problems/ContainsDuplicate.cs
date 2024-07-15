public class ContainsDuplicate
{
    private readonly int[] _arr = [1, 2, 3, 1];

    public bool Solution()
    {
        if(_arr.Length is 1 or 0)
            return false;

        var hs = new HashSet<int>();

        for (int i = 0; i < _arr.Length; i++)
        {
            if (!hs.Add(_arr[i]))
            {
                return true;
            }
        }

        return false;   
    }
}
