

namespace largest_elem
{
    public class Solution
    {
        public int Largest(List<int> arr)
        {
            int max = arr.First();
            for(int i = 1; i < arr.LongCount(); i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
    }

}
