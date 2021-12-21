using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDietHealth.Models;
using EDietHealth.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EDietHealth.Pages
{
    public class ElderlyProfileModel : PageModel
    {
        [BindProperty]
        public Elderly MyElderly { get; set; }
        private ElderlyService _svc;
        public ElderlyProfileModel(ElderlyService service)
        {
            _svc = service;
        }

        public void OnGet(String id)
        {
            if (id != null)
            {
                MyElderly = _svc.GetElderlyById(id);
            }
        }
    }
}
