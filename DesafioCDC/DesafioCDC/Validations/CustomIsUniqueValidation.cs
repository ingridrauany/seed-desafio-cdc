using DesafioCDC.DataAccess;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace DesafioCDC.Validations
{
    public class CustomIsUniqueValidation : ValidationAttribute
    {
        private readonly string _propertyName;
        private readonly Type _entityType;

        public CustomIsUniqueValidation(string propertyName, Type entityType)
        {
            _propertyName = propertyName;
            _entityType = entityType;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

           /* error on set method
            * var dbContext = (DataContext)validationContext.GetService(typeof(DataContext));
            var name = value as string;
            var entityTypeName = _entityType.Name;
            Type entity = Type.GetType(entityTypeName);

            var result = dbContext.Set(entityTypeName).Any(e => e.GetFieldValue(_propertyName) == name);

            if (result)
            {
                return new ValidationResult("Name already exists");
            }*/

            return ValidationResult.Success;
        }
    }
}
