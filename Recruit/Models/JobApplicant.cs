using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Recruit.Models
{
    public class JobApplicant
    {
        public int id { get; set; }
        public int job_id { get; set; }
        public int applicant_id { get; set; }
  //      [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		//public DateTime created_at { get; set; }
		//public DateTime updated_at { get; set; }
	}
}
