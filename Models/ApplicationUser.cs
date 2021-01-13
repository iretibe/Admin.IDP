using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.IDP.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(10)")]
        public string AssemblyCode { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Discriminator { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        public int? GroupId { get; set; }

        public int? StatusId { get; set; }

        public Guid? UserId { get; set; }

        public Guid? AssemblyId { get; set; }

        public bool IsEnabled { get; set; }
    }
}
