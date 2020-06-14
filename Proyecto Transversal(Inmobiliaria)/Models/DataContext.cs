using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto_Transversal_Inmobiliaria_.Models;

namespace Proyecto_Transversal_Inmobiliaria_.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Propietario> propietarios { get; set; }
        public DbSet<Inquilino> inquilino { get; set; }
        public DbSet<Inmueble> inmuebles { get; set; }
        public DbSet<Pago> pago { get; set; }
        public DbSet<Alquiler> alquiler { get; set; }


    }
}
