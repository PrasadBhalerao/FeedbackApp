using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackApp.Persistence.Models
{
    public class User
    {
        [Key]
        public int KeyID { get; set; }
        public string UserName { get; set; }
    }
}
