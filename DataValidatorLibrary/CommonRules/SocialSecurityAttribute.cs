﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataValidatorLibrary.CommonRules
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class SocialSecurityAttribute : ValidationAttribute
    {
        public string SocialValue { get; set; }

        public override bool IsValid(object value)
        {
            if (value is null)
            {
                return false;
            }
            if (value.ToString().Length == 9 && Regex.IsMatch(value.ToString(), @"^\d{9}$"))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
