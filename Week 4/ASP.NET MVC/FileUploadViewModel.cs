﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ASP.NET_MVC
{
    public class FileUploadViewModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
