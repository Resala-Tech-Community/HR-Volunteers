using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Diagnostics.Contracts;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using HR;
namespace HR_Volunteers.Data_Validation
{
    public class ViewModelBase : INotifyPropertyChanged, IDataErrorInfo
    {
        protected static readonly App CurrentApp = Application.Current as App;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(propertyName));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual string this[string columnName]
        {
            get
            {
                var validationResults = new List<System.ComponentModel.DataAnnotations.ValidationResult>();

                var property = GetType().GetProperty(columnName);
                Contract.Assert(null != property);

                var validationContext = new ValidationContext(this)
                {
                    MemberName = columnName
                };

                var isValid = Validator.TryValidateProperty(property.GetValue(this), validationContext, validationResults);
                if (isValid)
                {
                    return null;
                }

                return validationResults.First().ErrorMessage;
            }
        }

        public virtual string Error
        {
            get
            {
                var propertyInfos = GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);

                foreach (var propertyInfo in propertyInfos)
                {
                    var errorMsg = this[propertyInfo.Name];
                    if (null != errorMsg)
                    {
                        return errorMsg;
                    }
                }

                return null;
            }
        }
    }
}
