﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FytSoa.Web.Pages.FytAdmin.Sys
{
    public class RoleMenuModel : PageModel
    {
        [BindProperty]
        public string roleGuids { get; set; }
        public void OnGet(string roid)
        {
            roleGuids = roid;
        }
    }
}