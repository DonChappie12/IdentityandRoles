using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace thedashboard.Models
{
    public class Comments
    {
        [Key]
        public int CommentId {get; set;}
        public string Comment {get; set;}

        [ForeignKey("User")]
        public string user_id {get;set;}
        public User User { get; set; }
        
        [ForeignKey("Post")]
        public int post_id {get;set;}
        public Posts Post { get; set; }
    }
}