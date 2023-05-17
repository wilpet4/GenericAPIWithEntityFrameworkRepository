﻿using Database.Entities.Base;

namespace Database.Entities
{
    public class Classroom : Entity
    {
        public int Id { get; set; }
        public string Number { get; set; }

        public ICollection<Student> Students { get; set; }

        public Teacher Teacher { get; set; }
    }
}
