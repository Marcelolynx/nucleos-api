using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Validations;

public partial class ContractValidations<T>
{
    public ContractValidations<T> CompanyNameIsOk(SocialName socialName, short minLength, short maxLength, string propertyName, string message)
    {
        /*if(string.IsNullOrEmpty(socialName.CompanyName) || socialName.CompanyName.Length < minLength || socialName.CompanyName.Length > maxLength)
            AddNotification(new Notification(propertyName, message));*/
       
        return this;
    }
    
    public ContractValidations<T> TradingNameIsOk(SocialName socialName, short minLength, short maxLength, string propertyName, string message)
    {
        /*if (string.IsNullOrEmpty(socialName.TradingName) || socialName.TradingName.Length < minLength || socialName.TradingName.Length > maxLength)
            AddNotification(new Notification(message, propertyName));*/

        return this;
    }
    
}