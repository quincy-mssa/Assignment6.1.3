namespace Assignment6._1._3
{
    // Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    // Note that you must do this in-place without making a copy of the array.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };

            ZerosToBack(nums);

            Console.WriteLine(string.Join(", ", nums));
        }

        static void ZerosToBack(int[] nums)
        {
            int position = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) 
                {
                    nums[position] = nums[i];
                    position++; 
                }
            }

            while (position < nums.Length)
            {
                nums[position] = 0; 
                position++;
            }
        }
    }
}
