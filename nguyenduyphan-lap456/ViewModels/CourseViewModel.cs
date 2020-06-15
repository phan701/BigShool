using nguyenduyphan_lap456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nguyenduyphan_lap456.NewFolder1
{
    public class CourseViewModel
    {
        [required]
        public string Place { get; set; }
        [required]
        [futureDate]
        public string Date { get; set; }
        [required]
        [validTime]
        public string Time { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));

        }



    }
}