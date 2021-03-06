﻿using Jeans.IdentityServer4.Server.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jeans.IdentityServer4.Server.Service
{
    public interface IClientService
    {
        Task<Client> FindClientByIdAsync(string clientId);
    }
}
