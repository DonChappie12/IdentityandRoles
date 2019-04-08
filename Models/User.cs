using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace thedashboard.Models
{
    public class User : IdentityUser
    {
        [Key]
        // public int Id {get; set;}
        // public string FirstName {get; set;}
        // public string LastName {get; set;}

        // [DataType(DataType.EmailAddress)]
        // public string Email {get; set;}

        // [DataType(DataType.Password)]
        // public string Password {get; set;}

        // public string Role {get; set;}

        public List<Comments> Comment { get; set; }
        public List<Posts> Post { get; set; }
        public User()
        {
            Comment = new List<Comments>();
            Post = new List<Posts>();
        }
    }
}