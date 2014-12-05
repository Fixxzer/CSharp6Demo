using System;

namespace CSharp6Demo
{
    public static class NullConditionalOperator
    {
        public static string TruncateOld(string value, int length)
        {
            string result = value;
            if (value != null) // Skip empty string check for elucidation
            {
                result = value.Substring(0, Math.Min(value.Length, length));
            }
            return result;
        }

        public static string TruncateNew(string value, int length)
        {
            return value?.Substring(0, Math.Min(value.Length, length));
        }
    }
}
