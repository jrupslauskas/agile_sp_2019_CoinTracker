using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CoinTracker.Models
{
    public class User
    {
        private string userID { get; set; }
        public string userName { get; set; }
        private string password { get; set; }
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

    }

    public class UserDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }


}
