using System;

// this is a c sharp extention method , this is different from HTML Helper.

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

/*
 * If you want to know a dll version then just open Process Explorer and you can check the dll that are being used. process explorer in microsoft provided product.
 */