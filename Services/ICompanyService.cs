using Admin.IDP.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Admin.IDP.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<AspNetUsers>> GetAssemblyByAssemblyIdAsync(string strCode);
        Task<IEnumerable<psAssembly>> GetAssemblyCredentials(string strAssemblyCode);
        Task<IEnumerable<spGetUserRecords>> GetUserRecordsAsync(string strAssemblyCode, string strAssemblyUserId);
        Task<IEnumerable<spADGetUserCredentials>> GetGetUserCredentialsByUsernameAsync(string strUsername);
    }
}
