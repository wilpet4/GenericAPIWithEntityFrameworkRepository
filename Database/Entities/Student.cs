﻿using Database.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class Student : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public Classroom Classroom { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}