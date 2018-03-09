using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Recruit.Models
{
    public class CareerLevel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
  //      [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		//public DateTime created_at { get; set; }
		//public DateTime updated_at { get; set; }
	}
}
