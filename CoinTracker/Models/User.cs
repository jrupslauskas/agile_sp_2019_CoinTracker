using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CoinTracker.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int userID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        private string email { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private List<int> collection
        {
            get { return collection; }
            set { collection = value; }
        }

    // Log in Constructor
    public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }


    public User()
    {
     
    }

    }

    public class UserDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }


}
