﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.Models
{
    public class EmployeeProject
    {

        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }

        public Employee Employee { get; set; } 
        public Projects Project { get; set; } 

    }
}
