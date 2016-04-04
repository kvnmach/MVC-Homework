using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Homework.Models
{
    public class ClassMate
    {
        public class ClassMate
        {
            public ClassMate(int id, string name, string hair, double tall)
            {
                Id = id;
                Name = name;
                HairColor = hair;
                Height = tall;
            }
            public int Id { get; set; }
            public string Name { get; set; }
            public string HairColor { get; set; }
            public double Height { get; set; }
        }
    }
}