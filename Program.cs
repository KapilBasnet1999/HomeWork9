// Written by Kapil Basnet
// April 23, 2025


namespace HomeWork9
{
    public class Program
    {
        static void Main(string[] args)
        {
            HomeWork9 hw = new HomeWork9();

            // Test MoveZeroes
            int[] nums1 = { 0, 1, 0, 3, 12 };
            hw.MoveZeroes(nums1);
            Console.WriteLine("MoveZeroes: " + string.Join(", ", nums1));

            // Test LengthOfLastWord
            string s = "   fly me   to   the moon  ";
            Console.WriteLine("LengthOfLastWord: " + hw.LengthOfLastWord(s));

            // Test ReverseString
            char[] chars = { 'h', 'e', 'l', 'l', 'o' };
            hw.ReverseString(chars);
            Console.WriteLine("ReverseString: " + new string(chars));

            // Test MajorityElement
            int[] nums2 = { 2, 2, 1, 1, 1, 2, 2 };
            Console.WriteLine("MajorityElement: " + hw.MajorityElement(nums2));

            // Test IsHappy
            Console.WriteLine("IsHappy(19): " + hw.IsHappy(19));
            Console.WriteLine("IsHappy(2): " + hw.IsHappy(2));
        }

    }
}
