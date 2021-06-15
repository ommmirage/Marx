using System;
using Microsoft.AspNetCore.Identity;

namespace LoginServer.Models.Entities
{
    public class User : IdentityUser
    {
        public string AuthToken { get; set; }
    }
}
