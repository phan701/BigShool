using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nguyenduyphan_lap456.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser lecturer { get; set; }
        [required]
        public string lecturerId { get; set; }
        [required]
        [stringlength(225)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [required]
        public byte CategoryId { get; set; }

    }
}