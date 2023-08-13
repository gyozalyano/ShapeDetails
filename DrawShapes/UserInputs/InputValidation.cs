namespace DrawShapes.UserInputs
{
    internal static class InputValidation
    {
        internal static bool IsPositiveNumber(string? input)
        {
            if (input != string.Empty)
            {
                return Convert.ToDouble(input) > 0;
            }
           
            return false;
        }

        internal static bool IsNonNegativeNumber(string? input)
        {
            if (input != string.Empty)
            {
                return Convert.ToDouble(input) >= 0;
            }

            return false;
        }

        internal static bool IsZeroOrOne(string? input)
        {
            if (input != string.Empty)
            {
                var convertedInput = Convert.ToDouble(input);
                return convertedInput is 0 or 1;
            }

            return false;
        }
    }
}
