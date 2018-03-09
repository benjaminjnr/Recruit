using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Recruit.Models
{
    public class Job
    {

        public int id { get; set; }
        public string title { get; set; }
        [Column(TypeName = "text")]
        public string description { get; set; }
        [Column(TypeName = "text")]
        public string requirements { get; set; }
        public int organization_id { get; set; }
        public string country_code { get; set; }
        public int state_id { get; set; }
        public string category { get; set; }
        public string level { get; set; }
  //      [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		//public DateTime created_at { get; set; }
		//public DateTime updated_at { get; set; }
	}
}
