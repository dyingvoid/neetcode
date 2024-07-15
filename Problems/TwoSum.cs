public class TwoSum
{
    private readonly int[] _nums = [2, 7, 11, 15];
    private readonly int _target = 9;

    public int[] Solution() => PrivateSolution(_nums, _target);

    private int[] PrivateSolution(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            var complement = target - num;

            if (dict.TryGetValue(complement, out var value))
            {
                return [i, value];
            }
            else
            {
                if(!dict.TryAdd(num, i))
                    dict[num] = i;
            }
        }

        return [0, 0];
    }
}
