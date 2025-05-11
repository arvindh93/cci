namespace PracticePrgs{
    public class StringCompress()
    {
        public string Compress(string str)
        {
            string result = "";
            if (str == string.Empty) {
                return "";
            }
            if (str.Length == 1) {
                return str + "1";
            }
            int prev = 0;
            int curr = prev + 1;
            while (curr < str.Length)
            {
                if (str[prev] != str[curr])  {
                    result += str[prev] + (curr - prev).ToString();
                    prev = curr;
                }
                curr++;
            }
            result += str[prev] + (curr - prev).ToString();
            return result;
        }
    }
}