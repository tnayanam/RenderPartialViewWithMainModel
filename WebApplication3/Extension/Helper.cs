using System;

namespace WebApplication3.Extension
{
    public static class Helper
    {
        public static string ConvertToDollar(this decimal amount)
        {
            return String.Format("{0:C}", amount);
        }
    }
}