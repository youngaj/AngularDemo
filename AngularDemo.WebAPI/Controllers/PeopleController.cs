using AngularDemo.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularDemo.WebAPI.Controllers
{
    public class PeopleController : ApiController
    {
        [HttpGet]
        public List<Person> Get()
        {
            var people = new List<Person>()
            {
                new Person() { Id =1, Name="Alyssa Young", Age=3, Photo = "lissy", Account=new Account() {Balance = 100.56M } },
                new Person() { Id =2, Name="Annuetta Young", Age=32, Photo = "annie", Account=new Account() {Balance = 200.56M }},
                new Person() { Id =3, Name="India Young", Age=15, Photo = "turkey", Account=new Account() {Balance = 650.99M } },
                new Person() { Id =4, Name="Andre Young", Age=37, Photo = "andre", Account=new Account() {Balance = 500 } },
            };
            return people;
        }
    }
}
