﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1
{
    public class Student
    {   // Scalar Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        // Navigation Property
        public Department Department { get; set; }
    }
}