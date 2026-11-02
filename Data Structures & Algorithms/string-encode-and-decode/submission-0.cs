public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder result = new StringBuilder();
        foreach(string str in strs){
            result.Append(str.Length);
            result.Append('#');
            result.Append(str);
        }
        return result.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();

        int i = 0;

        while (i < s.Length)
        {
            int j = i;

            // Find the separator '#'
            while (s[j] != '#')
            {
                j++;
            }

            // Read the length
            int length = int.Parse(s.Substring(i, j - i));

            // Read exactly 'length' characters
            j++;

            string str = s.Substring(j, length);
            result.Add(str);

            // Move to the next encoded string
            i = j + length;
        }

        return result;
   }
}
