﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Customer
    {
        public string CustomerId 
        { 
            get; 
            set; 
        }
        public string CustomerName 
        { 
            get; 
            set; 
        }
        public string CustomerContact
        { 
            get; 
            set; 
        }
        public string CustomerAddress
        { 
            get; 
            set; 
        }
    }
}
