public class ValidAnagram
{
    private readonly string _s = "anagram";
    private readonly string _t = "nagaram";

    public bool Solution()
    {
        if (_s.Length != _t.Length)
            return false;

        var sDict = new Dictionary<char, int>();
        var tDict = new Dictionary<char, int>();

        for (int i = 0; i < _t.Length; i++)
        {
            if (!sDict.TryAdd(_s[i], 1))
                sDict[_s[i]] += 1;
            if (!tDict.TryAdd(_t[i], 1))
                tDict[_t[i]] += 1;
        }

        foreach (var (k, v) in sDict)
        {
            if (!tDict.TryGetValue(k, out var tValue))
                return false;
            if (v != tValue)
                return false;
        }

        return true;
    }
}
