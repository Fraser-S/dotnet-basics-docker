namespace basic_ms
{     
    public static class Extensions
    {
        
        public static double? TryParse(this string input)
        {
            if (double.TryParse(input, out var result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
