var groupAnagrams = new GroupAnagrams();
var res = groupAnagrams.Solution();

foreach(var arr in res)
{
    Console.WriteLine(string.Join(", ", arr));
}