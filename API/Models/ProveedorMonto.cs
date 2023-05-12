using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ProveedorMonto
{
    public int Id { get; set; }

    public int ProveedoresId { get; set; }

    public int EntesId { get; set; }

    public int PeriodosId { get; set; }

    public int EjerciciosId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public double Monto { get; set; }

    public double MontoDevengado { get; set; }

    public virtual Ejercicio Ejercicios { get; set; } = null!;

    public virtual Ente Entes { get; set; } = null!;

    public virtual Periodo Periodos { get; set; } = null!;

    public virtual Proveedore Proveedores { get; set; } = null!;
}
