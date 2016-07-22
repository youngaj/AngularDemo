using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDemo.WebAPI.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }
        public Account Account { get; set; }
    }
}