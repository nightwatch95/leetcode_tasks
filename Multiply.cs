public class Solution {
    public string Multiply(string num1, string num2) {
        int n1 = 0;
        int n2 = 0;
        int i = 0;
        
        if (String.IsNullOrEmpty(num1) || String.IsNullOrEmpty(num2))
            throw new ArgumentException();
        
        while(i < num1.Length || i < num2.Length)
        {
            if (i < num1.Length)
            {
                int num = num1[i] - '0';
                n1 = n1 * 10 + num;
            }
            
            if (i < num2.Length)
            {
                int num = num2[i] - '0';
                n2 = n2 * 10 + num;
            }
            i++;
        }
        return ((n1 * n2).ToString());
    }
}