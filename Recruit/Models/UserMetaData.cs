using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Recruit.Models
{
    public class UserMetaData
    {
        public enum UserMetaNames {
            DOB,
            Level,
            Resume,
            StateId,
            CountryCode,
			Specification
		}
        
        public int id { get; set; }
        public UserMetaNames meta_name { get; set; }
        public string meta_value { get; set; }
  //      [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		//public DateTime created_at { get; set; }
		//public DateTime updated_at { get; set; }
    }
}
