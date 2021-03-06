﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        public string UserName { get; set; }
        public FooterViewModel FooterData { get; set; }
    }
}
