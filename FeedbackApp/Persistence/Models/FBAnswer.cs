using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackApp.Persistence.Models
{
    public class FBAnswer
    {
        [Key]
        public int KeyID { get; set; }
        public string Answer { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }
        [ForeignKey("Question")]
        public int FBQuestionID { get; set; }
        public FBQuestion FBQuestion { get; set; }
    }
}
