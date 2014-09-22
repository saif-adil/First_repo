using System;


namespace PingYourPackage.API.Model.Dtos {
    
    public class AffiliateDto : IDto {

        public Guid Key { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public AffiliateMemberInfoDto MemberInfo { get; set; }
    }
}
