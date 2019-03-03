public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int i = 0;
        int j = 0;
        
        while(i < nums.Length - 1)
        {
            j = i + 1;
            while (j < nums.Length)
            {
                if(nums[i] + nums[j] == target && i != j)
                    return (new int[] {i, j});
                j++;
            }
            i++;
        }
        
        return (new int[] {});
    }
}