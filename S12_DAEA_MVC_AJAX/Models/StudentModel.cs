﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace S12_DAEA_MVC_AJAX.Models
{
    public class StudentModel
    {
         public int studentID { get; set; }
        public string studentName { get; set; }
        public string studentAddress { get; set; }

        public string studentLastName { get; set; }
        public string studentCode { get; set; }
    }
}