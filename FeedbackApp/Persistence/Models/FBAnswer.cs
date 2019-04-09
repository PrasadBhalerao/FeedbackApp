using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackApp.Persistence.Models
{
    public class FBAnswer
    {
        [Key]
        public int KeyID { get; set; }
        public string Answer { get; set; }
    }
}
