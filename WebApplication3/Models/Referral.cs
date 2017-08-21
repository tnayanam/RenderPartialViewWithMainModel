
using System.ComponentModel.DataAnnotations;
namespace WebApplication3.Models
{

    // one candidate can create many referrals, also one referrer can refer from many referral list.
    // in this case we are keeping the FK as NOT NULL. 
    public class Referral
    {
        [Key]
        public int ReferralId { get; set; }
        public string CandidateId { get; set; } // not null
        public string ReferrerId { get; set; }  // not null
        public ApplicationUser Candidate { get; set; }
        public ApplicationUser Referrer { get; set; }
    }
}