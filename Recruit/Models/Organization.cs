using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Recruit.Models
{
    public class Organization
    {
        public int id { get; set; }
        public string name { get; set; }
        [Column(TypeName = "text")]
        public string description { get; set; }
        [Column(TypeName = "text")]
        public string address { get; set; }
        public string country_code { get; set; }
        public int state_id { get; set; }
  //      [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		//public DateTime created_at { get; set; }
		//public DateTime updated_at { get; set; }
	}
}
