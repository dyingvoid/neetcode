using System.Text;

public class GroupAnagrams
{
    private string[] _strs = ["eat", "tea", "tan", "ate", "nat", "bat"];

    public IList<IList<string>> Solution() => PrivateSolution(_strs);

    private IList<IList<string>> PrivateSolution(string[] strs)
    {
        var dict = new Dictionary<string, IList<string>>();

        foreach (var str in strs)
        {
            var hash = Hash(str);
            if (!dict.TryAdd(hash, new List<string>() { str }))
            {
                dict[hash].Add(str);
            }
        }

        return dict.Select(pair => pair.Value).ToList();
    }

    private string Hash(string str)
    {
        var arr = new int[26];
        var sb = new StringBuilder();

        foreach (var c in str)
        {
            arr[c - 'a'] += 1;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            sb.Append('a' + i + arr[i]);
        }

        return sb.ToString();
    }
}
