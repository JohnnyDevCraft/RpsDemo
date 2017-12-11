using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RpsDemo.Models.Enumerations;

namespace RpsDemo.Models.DataModels
{
    [Table("TblPolicies")]
    public class Policy
    {
        [Key]
        public int PolicyNumber { get; set; }

        public DateTime PolicyEffectiveDate { get; set; }
        public DateTime PolicyExpirationDate { get; set; }
        
        public string PrimaryInsuredName { get; set; }
        public string PrimaryInsuredMailingAddress { get; set; }
        public string PrimaryInsuredCity { get; set; }
        public string PrimaryInsuredState { get; set; }
        public string PrimaryInsuredZipCode { get; set; }

        public ConstructionType RiskConstruction { get; set; }
        public int RiskYearBuilt { get; set; }
        public string RiskAddress { get; set; }
        public string RiskCity { get; set; }
        public string RiskState { get; set; }
        public string RiskZipCode { get; set; }
    }
}