using Microsoft.AspNetCore.Identity;

namespace AmtOrk.Server.Models
{
    // Identity user is here, but im not sure if I have time for Identity

    // Basis for User Data
    // https://ork.amtgard.com/orkui/index.php?Route=Player/index/37280
    public class AmtUser : IdentityUser
    {
        public string HeraldryPath { get; set; } = default!;
        public string PersonaName { get; set; } = default!;

        public bool IsRestricted { get; set; }
        public bool IsWaivered { get; set; }
        public bool IsSuspended { get; set; }
        public bool IsEnabled { get; set; }

        public DateTime PasswordExpires { get; set; } // This feels like a security issue, but its how the ORK does it
        public DateTime ReeveQualified { get; set; }
        public DateTime CorporaQualified { get; set; }
        public DateTime ParkMemberSince { get; set; }

        public virtual List<Credit> Credits { get; set; } = default!;
    }
}