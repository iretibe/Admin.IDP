namespace Admin.IDP.Models
{
    public class GetCredentials
    {
        public string szUserName { get; set; }
        public string szClearText { get; set; }
        public long AppId { get; set; }
    }
}
