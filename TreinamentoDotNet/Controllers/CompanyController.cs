using TreinamentoDotNet.Database;
using TreinamentoDotNet.Models.Company;
using TreinamentoDotNet.ViewModel.Company;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.ComponentModel.Design;


namespace TreinamentoDotNet.Controllers
{
    public class CompanyController : Controller
    {
        private readonly CompanyDbContext _context;

        public CompanyController()
        {
            _context = new CompanyDbContext();
        }

        public async Task<ActionResult> Index()
        {
            return View(
                await _context.Company
                    .Select(i => new CompanyIndexViewModel
                    {
                        Id = i.Id,
                        Name = i.Name,
                        Cnpj = i.Cnpj,
                        Country = i.Country,
                        State = i.State,
                        City = i.City,
                        Phone = i.Phone,
                        Email = i.Email
                    })
                    .ToListAsync()
            );
        }

        public async Task<ActionResult> Details(int id)
        {
            var import = await _context.Company.FirstOrDefaultAsync(i => i.Id == id);
            if (import == null) return HttpNotFound();

            var viewModel = new CompanyDetailsViewModel
            {
                Id = import.Id,
                Name = import.Name,
                Cnpj = import.Cnpj,
                Country = import.Country,
                State = import.State,
                City = import.City,
                Phone = import.Phone,
                Email = import.Email
            };

            return View(viewModel);
        }
        public ActionResult Create()
        {
            return View(new CompanyFormViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CompanyFormViewModel viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);

            var company = new Company
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Cnpj = viewModel.Cnpj,
                Country = viewModel.Country,
                State = viewModel.State,
                City = viewModel.City,
                Phone = viewModel.Phone,
                Email = viewModel.Email
            };

            _context.Company.Add(company);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Edit(int id)
        {
            var import = await _context.Company.FirstOrDefaultAsync(i => i.Id == id);
            if (import == null) return HttpNotFound();

            var viewModel = new CompanyFormViewModel
            {
                Id = import.Id,
                Name = import.Name,
                Cnpj = import.Cnpj,
                Country = import.Country,
                State = import.State,
                City = import.City,
                Phone = import.Phone,
                Email = import.Email
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(CompanyFormViewModel viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);

            var import = await _context.Company.SingleOrDefaultAsync(i => i.Id == viewModel.Id);
            if (import == null) return HttpNotFound();

            import.Id = viewModel.Id;
            import.Name = viewModel.Name;
            import.Cnpj = viewModel.Cnpj;
            import.Country = viewModel.Country;
            import.State = viewModel.State;
            import.City = viewModel.City;
            import.Phone = viewModel.Phone;
            import.Email = viewModel.Email;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Delete(int id)
        {
            var Company = await _context.Company.FirstOrDefaultAsync(i => i.Id == id);
            if (Company == null) return HttpNotFound();

            var viewModel = new CompanyDeleteViewModel
            {
                Id = Company.Id,
                Name = Company.Name,
                Cnpj = Company.Cnpj
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var import = await _context.Company.FirstOrDefaultAsync(i => i.Id == id);
            if (import == null) return HttpNotFound();

            _context.Company.Remove(import);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}