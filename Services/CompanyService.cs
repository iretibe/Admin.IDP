using Admin.IDP.Entity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.IDP.Services
{
    public class CompanyService : ICompanyService
    {
        private PersoltaxadmindbContext _context;
        private IConfiguration _configuration;

        public CompanyService(PersoltaxadmindbContext context, IConfiguration configuration)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<IEnumerable<AspNetUsers>> GetAssemblyByAssemblyIdAsync(string strCode)
        {
            return await _context.AspNetUsers.Where(a => a.AssemblyCode == strCode).ToListAsync();
        }

        public async Task<IEnumerable<psAssembly>> GetAssemblyCredentials(string strAssemblyCode)
        {
            return await _context.psAssembly.Where(a => a.szCode == strAssemblyCode).ToListAsync();
        }

        public async Task<IEnumerable<spADGetUserCredentials>> GetGetUserCredentialsByUsernameAsync(string strUsername)
        {
            List<spADGetUserCredentials> lst;
            _context.Database.OpenConnection();
            using (DbCommand cmdObj = _context.Database.GetDbConnection().CreateCommand())
            {
                cmdObj.CommandText = "spGetUserClaimsByUsername";
                cmdObj.CommandType = CommandType.StoredProcedure;
                cmdObj.Parameters.Add(new SqlParameter("@szUserName", strUsername));

                using (var drObj = await cmdObj.ExecuteReaderAsync())
                {
                    lst = drObj.MapToList<spADGetUserCredentials>();
                }
            }
            return lst;
        }

        public async Task<IEnumerable<spGetUserRecords>> GetUserRecordsAsync(string strAssemblyCode, string strAssemblyUserId)
        {
            List<spGetUserRecords> lst;
            _context.Database.OpenConnection();
            using (DbCommand cmdObj = _context.Database.GetDbConnection().CreateCommand())
            {
                cmdObj.CommandText = "spGetUserRecords";
                cmdObj.CommandType = CommandType.StoredProcedure;
                cmdObj.Parameters.Add(new SqlParameter("@AssemblyCode", strAssemblyCode));
                cmdObj.Parameters.Add(new SqlParameter("@AssemblyUserId", strAssemblyUserId));

                using (var drObj = await cmdObj.ExecuteReaderAsync())
                {
                    lst = drObj.MapToList<spGetUserRecords>();
                }
            }
            return lst;
        }
    }
}
