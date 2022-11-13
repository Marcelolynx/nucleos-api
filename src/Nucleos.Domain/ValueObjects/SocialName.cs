namespace Nucleos.Domain.ValueObjects;

public struct SocialName
{
    public SocialName(string tradingName, string companyName)
    {
        TradingName = tradingName;
        CompanyName = companyName;
    }
    public string TradingName { get; private set; }
    public string CompanyName { get; private set; }
}