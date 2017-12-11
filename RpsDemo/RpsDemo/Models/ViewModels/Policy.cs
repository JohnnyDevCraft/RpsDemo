using System;
using System.ComponentModel.DataAnnotations;
using RpsDemo.Models.Enumerations;

namespace RpsDemo.Models.ViewModels
{
    public class Policy
    {
        public int PolicyNumber { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime PolicyEffectiveDate { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime PolicyExpirationDate { get; set; }
        
        public string PrimaryInsuredName { get; set; }
        public string PrimaryInsuredMailingAddress { get; set; }
        public string PrimaryInsuredCity { get; set; }
        [MaxLength(2), MinLength(2)]
        public string PrimaryInsuredState { get; set; }
        public string PrimaryInsuredZipCode { get; set; }

        public ConstructionType RiskConstruction { get; set; }
        
        [Range(1000, 2999)]
        public int RiskYearBuilt { get; set; }
        public string RiskAddress { get; set; }
        public string RiskCity { get; set; }
        [MaxLength(2), MinLength(2)]
        public string RiskState { get; set; }
        public string RiskZipCode { get; set; }
    }
}