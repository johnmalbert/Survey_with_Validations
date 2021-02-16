using System.ComponentModel.DataAnnotations;
using System;
namespace Dojo_Survey_Validations.Models
{
    public class Survey
    {
        //survey fields
        [Required]
        [MinLength(2)]
        public string Name{get;set;}
        
        [Required]
        public string Location{get;set;}
        
        [Required(ErrorMessage="Language Field is required")]
        public string Lang{get;set;}
        
        [CommentLength]
        public string Comment{get;set;}
    }
    public class CommentLength : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string val = "";
            if(value != null)
                val = value.ToString();
            if(val.Length != 0 && val.Length < 20)
            {
                return new ValidationResult("Comment is optional, but must be 20 characters or more if supplied.");
            }
            return ValidationResult.Success;
        }
    }
}