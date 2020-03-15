﻿using LojaVirtualSOAP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LojaVirtualSOAP.Context
{
    public class LojaVirtualDbContext : DbContext
    {
        protected LojaVirtualDbContext(): base("LojaVirtualDbContext")
        {}

        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}