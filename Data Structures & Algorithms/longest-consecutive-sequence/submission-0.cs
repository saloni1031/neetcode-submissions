public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        foreach(int i in nums)
            set.Add(i);
        
        int longest = 0;

        foreach(int i in nums){
            if(!set.Contains(i - 1)){
                int length = 0;
                while(set.Contains(i+length)){
                    length++;
                }
                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }
}
