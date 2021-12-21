using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EDietHealth.Models;
using EDietHealth.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EDietHealth.Pages
{
    public class VolunProfileModel : PageModel
    {
        [BindProperty]
        public List<Elderly> allelderlys { get; set; }

        private readonly ILogger<IndexModel> _logger;
        private ElderlyService _svc;
        public VolunProfileModel(ILogger<IndexModel> logger, ElderlyService service)
        {
            _logger = logger;
            _svc = service;
        }

        public void OnGet()
        {
            allelderlys = _svc.GetAllElderlys();
        }
    }
}
