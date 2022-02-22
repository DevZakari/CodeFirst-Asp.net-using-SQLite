using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Data;
using test.Model;

namespace test.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly DataContext _dataContext;

        public PrivacyModel(ILogger<PrivacyModel> logger,DataContext dataContext)
        {
            _logger = logger;
            _dataContext = dataContext;
        }

        public void OnGet()
        {
            var Etudiant = new Etudiant() { Name = "Zakaria", Last_name = "Machtor", Email = "MachMach", Tel = 0612345890 };
            _dataContext.Etudiant.Add(Etudiant);
            _dataContext.SaveChanges();
        }
    }
}
