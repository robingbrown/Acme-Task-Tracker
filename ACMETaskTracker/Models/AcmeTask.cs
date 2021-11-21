using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ACMETaskTracker.Models
{
    public class AcmeTask
    {
        [Key]
        public int TaskID { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{ddd, MMM d, 'yy hh:mm tt}")]
        public DateTime DateandTime { get; set; } = DateTime.Now;
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [MaxLength(2000)]
        public string Content { get; set; }
        public string Status { get; set; } = "Open";
    }
}
