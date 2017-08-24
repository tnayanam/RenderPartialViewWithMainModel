
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using System.Web;
namespace WebApplication3.CustomValidation
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class FileConstraint : ValidationAttribute
    {
        private List<string> ValidExtensions { get; set; }

        public FileConstraint(string fileExtensions)
        {
            ValidExtensions = fileExtensions.Split('|').ToList();
        }

        public override bool IsValid(object value)
        {
            HttpPostedFileBase file = value as HttpPostedFileBase;
            if (file != null)
            {
                var fileName = file.FileName;
                var isValidExtension = ValidExtensions.Any(y => fileName.EndsWith(y));
                return isValidExtension;
            }
            return true;
        }
    }
}