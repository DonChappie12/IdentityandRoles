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

        [ForeignKey("user")]
        public int user_Id {get;set;}
        public User user { get; set; }
        
        [ForeignKey("post")]
        public int post_id {get;set;}
        public Posts post { get; set; }
    }
}