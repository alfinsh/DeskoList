//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PollAnswers
    {
        public PollAnswers()
        {
            this.PollVotes = new HashSet<PollVotes>();
        }
    
        public int Id { get; set; }
        public string Answer { get; set; }
        public int PollId { get; set; }
    
        public virtual Poll Poll { get; set; }
        public virtual ICollection<PollVotes> PollVotes { get; set; }
    }
}
