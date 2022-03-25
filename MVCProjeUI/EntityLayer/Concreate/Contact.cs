﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(50)]
        public string Usermail { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        [StringLength(200)]
        public string Message { get; set; }
      
    }
}
