using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace WebAppForSignIn.Attributes
{
    public class ValidationCheckBox:ValidationAttribute,IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-chkbox", value: ErrorMessage);
        }

        public override bool IsValid(object? value)
        {
            if((bool)value==true)
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
