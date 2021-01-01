
using Catstagram.Server.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Catstagram.Server.Models
{
    public class User : IdentityUser
    {
        public IEnumerable<Cat> Cats { get; set; } = new HashSet<Cat>();
    }
}
