using System.Web.Mvc;

namespace TreinamentoDotNet.Controllers
{
    internal class CompanyDetailsViewModel : IView
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