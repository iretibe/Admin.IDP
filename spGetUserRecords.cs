using System;

namespace Admin.IDP
{
    public class spGetUserRecords
    {
        public Guid uniAssemblyId { get; set; }
        public string szAssemblyName { get; set; }
        public string szLogo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal nCashLimit { get; set; }
        public long AgentId { get; set; }
        public long iGroupId { get; set; }
        public string szGroupName { get; set; }
        public string pkId { get; set; }
        public long iSegmentId { get; set; }
    }
}
