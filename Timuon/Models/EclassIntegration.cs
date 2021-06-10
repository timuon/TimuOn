using System;

namespace Timuon.Models
{
    public class EclassIntegration
    {
        public string DomainName { get; set; }
        public string UserName { get; set; }

        public EclassIntegration(string domainName, string userName)
        {
            DomainName = domainName;
            UserName = userName;
        }
    }
}
