using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Recruit.Models
{
    public class State
    {
        public int id { get; set; }
        public string name { get; set; }
        public string country_code { get; set; }
  //      [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		//public DateTime created_at { get; set; }
		//public DateTime updated_at { get; set; }
	}
}
