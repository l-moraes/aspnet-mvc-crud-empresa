using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreinamentoDotNet.Models.Company
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}