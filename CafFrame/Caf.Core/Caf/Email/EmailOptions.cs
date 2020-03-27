﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Core.Email
{
    public class EmailOptions
    {
        private string _password;

        public string Host { get; set; }
        public int Port { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool EnableSsl { get; set; }
        public int Timeout { get; set; }
    }
}
