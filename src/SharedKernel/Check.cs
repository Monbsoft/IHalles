using System;

namespace Monbsoft.IHalles.SharedKernel
{
    public static class Check
    {
        public static T NotNull<T>(T value, string parameterName)
            where T : class
        {
            if (value == null)
                throw new ArgumentNullException(parameterName);
            return value;
        }

        public static T? NotNull<T>(T? value, string parameterName)
            where T : struct
        {
            if (value == null)
                throw new ArgumentNullException(parameterName);
            return value;
        }

        public static string NotNullOrEmpty(string value, string parameterName)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException($"The argument {parameterName} cannot be null or empty");
            return value;
        }
    }
}