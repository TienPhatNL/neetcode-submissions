public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0, mArea = 0;
        int right = heights.Length - 1;
        
        while(right > left){
            int len = Math.Min(heights[left], heights[right]);

            mArea = Math.Max(mArea, (len * (right - left)));

            if(heights[left] < heights[right]) left++;
            else right--;
        }
        return mArea;
    }
}
