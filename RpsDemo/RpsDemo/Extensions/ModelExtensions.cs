using RpsDemo.Models;

namespace RpsDemo.Extensions
{
    public static class ModelExtensions
    {
        public static Models.DataModels.Policy ToDataModel(this Models.ViewModels.Policy from)
        {
            return new Models.DataModels.Policy()
            {
                PolicyNumber = from.PolicyNumber,
                PolicyEffectiveDate = from.PolicyEffectiveDate,
                PolicyExpirationDate = from.PolicyExpirationDate,
                PrimaryInsuredName = from.PrimaryInsuredName,
                PrimaryInsuredMailingAddress = from.PrimaryInsuredMailingAddress,
                PrimaryInsuredCity = from.PrimaryInsuredCity,
                PrimaryInsuredState = from.PrimaryInsuredState,
                PrimaryInsuredZipCode = from.PrimaryInsuredZipCode,
                RiskConstruction = from.RiskConstruction,
                RiskAddress = from.RiskAddress,
                RiskCity = from.RiskCity,
                RiskState = from.RiskState,
                RiskYearBuilt = from.RiskYearBuilt,
                RiskZipCode = from.RiskZipCode
            };
        }
        
        public static Models.ViewModels.Policy ToViewModel(this Models.DataModels.Policy from)
        {
            return new Models.ViewModels.Policy()
            {
                PolicyNumber = from.PolicyNumber,
                PolicyEffectiveDate = from.PolicyEffectiveDate,
                PolicyExpirationDate = from.PolicyExpirationDate,
                PrimaryInsuredName = from.PrimaryInsuredName,
                PrimaryInsuredMailingAddress = from.PrimaryInsuredMailingAddress,
                PrimaryInsuredCity = from.PrimaryInsuredCity,
                PrimaryInsuredState = from.PrimaryInsuredState,
                PrimaryInsuredZipCode = from.PrimaryInsuredZipCode,
                RiskConstruction = from.RiskConstruction,
                RiskAddress = from.RiskAddress,
                RiskCity = from.RiskCity,
                RiskState = from.RiskState,
                RiskYearBuilt = from.RiskYearBuilt,
                RiskZipCode = from.RiskZipCode
            };
        }
    }
}