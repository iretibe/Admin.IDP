using System;

namespace Admin.IDP
{
    public class spADGetUserCredentials
    {
        public long pkId { get; set; }
        public byte[] szPassword { get; set; }
        public string szHashKey { get; set; }
        public Nullable<int> iFirstTimeLogin { get; set; }
        public long iPersonelId { get; set; }
        public string szFirstName { get; set; }
        public string szLastName { get; set; }
        public string szEmailAddress { get; set; }
        public string szImage { get; set; }
        public Nullable<int> iSegmentId { get; set; }
        public string szGroupName { get; set; }
        public Nullable<long> iGroupId { get; set; }
    }
}
