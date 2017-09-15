﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppParqueoAzul.Classes
{
   public class Response
    {
        public bool IsSuccess { get; set; }

        public string Message{ get; set; }

        public object Result { get; set; }

        public List<object> Results { get; set; }
    }
}
