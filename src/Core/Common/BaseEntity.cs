﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    public abstract class BaseEntity : IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string ImageUrl { get; set; } = "";

        public void Dispose()
        {
        }
    }
}
