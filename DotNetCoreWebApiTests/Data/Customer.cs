﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreWebApiTests.Data
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int CustomerTypeId { get; set; }
    }
}
