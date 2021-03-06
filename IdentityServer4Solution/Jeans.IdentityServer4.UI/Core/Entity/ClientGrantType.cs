﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jeans.IdentityServer4.UI.Core.Entity
{
    /// <summary>
    /// 客户授权类型
    /// </summary>
    public class ClientGrantType: BaseEntity
    {
        public string GrantType { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
