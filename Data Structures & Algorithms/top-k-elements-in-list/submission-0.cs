public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach(int num in nums){
            if(frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach(var pair in frequency){
            int num = pair.Key;
            int freq = pair.Value;

            if(buckets[freq] == null)
                buckets[freq] = new List<int>();

            buckets[freq].Add(num);
        }

        List<int> result = new List<int>();

        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] == null)
                continue;

            foreach (int num in buckets[i])
            {
                result.Add(num);

                if (result.Count == k)
                    break;
            }
        }

        return result.ToArray();
    }
}
