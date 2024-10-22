using Microsoft.EntityFrameworkCore;
using ApiEmpresa.Models;

namespace ApiEmpresa.Models;

public class Conexiones : DbContext
{
    public Conexiones(DbContextOptions<Conexiones> options)
        : base(options)
    {
    }

    public DbSet<Clientes> Clientes { get; set; } = null!;
    public DbSet<Proveedores> Proveedores { get; set; } = null!;
}