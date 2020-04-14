﻿namespace LJ.Ids4.Core.Domain.Clients
{
    /// <summary>
    /// 客户作用域
    /// </summary>
    public class ClientScope : BaseEntity
    {
        public string Scope { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}