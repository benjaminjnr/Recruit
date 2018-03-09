using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
namespace Recruit.Models
{
    public class User
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string password_hash { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime created_at { get; set; }
        //public DateTime updated_at { get; set; }
    }
}
