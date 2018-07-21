﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace store.Models
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }
    }
}