using System;
using System.Collections.Generic;

namespace API.Models;

public partial class EnteCalificacion
{
    public int Id { get; set; }

    public int EnteId { get; set; }

    public int EjercicioId { get; set; }

    public double AuditoriaDesempeno { get; set; }

    public double AuditoriaOp { get; set; }

    public double AuditoriaFinanciera { get; set; }

    public double ControlInterno { get; set; }

    public double CalificacionReal { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public double? ServiciosPublicos { get; set; }

    public double? AuditoriaFinancieraImportePorSolventar { get; set; }

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual Ente Ente { get; set; } = null!;
}
