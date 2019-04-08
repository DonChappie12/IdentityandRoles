using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace thedashboard.Models
{
    public class Posts
    {
        [Key]
        public int PostId {get; set;}
        public string Post {get; set;}

        [ForeignKey("user")]
        public int user_id {get;set;}
        public User user { get; set; }
    }
}