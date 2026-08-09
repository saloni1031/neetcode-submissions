public class Solution {
    public bool IsPalindrome(string c) {
      //char[] c = s.ToCharArray();
      int left = 0;
      int right = c.Length - 1;
      while(left < right){
while (left < right && !char.IsLetterOrDigit(c[left]))
    left++;

while (left < right && !char.IsLetterOrDigit(c[right]))
    right--;
        
        if(char.ToLower(c[left]) != char.ToLower(c[right])){
            return false;
        }

        left++;
        right--;
      }

      return true;  
    }
}
