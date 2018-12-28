using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class ZhiWeiViewModel
    {

        public Guid ID { get; set; }

        public string Zname { get; set; }

        public Guid? LID { get; set; }

        public string Lname { get; set; }

        public Guid? BID { get; set; }

        public string Bname { get; set; }

        public string edithtml { get; set; }

        public string viewhtml { get; set; }
    }
}