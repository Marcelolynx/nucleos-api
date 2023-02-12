namespace Nucleos.Domain.ValueObjects;

public class SocialName
{
    public SocialName(string tradingName, string companyName)
    {
        TradingName = tradingName;
        CompanyName = companyName;
    }
    public string TradingName { get;  set; }
    public string CompanyName { get;  set; }
}