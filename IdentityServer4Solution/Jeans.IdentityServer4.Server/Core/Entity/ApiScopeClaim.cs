﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jeans.IdentityServer4.Server.Core.Entity
{
    /// <summary>
    /// Api作用域，声明
    /// </summary>
    public class ApiScopeClaim
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public int ApiScopeId { get; set; }
        public ApiScope ApiScope { get; set; }
    }
}
