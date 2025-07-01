namespace MyLearningAppLibrary.Utilities
{
    public static class StringUtilities
    {
        public static string ToTitleCase(string input)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }
    }
}
