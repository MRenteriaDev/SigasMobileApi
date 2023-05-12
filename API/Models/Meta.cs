using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Meta
{
    public int Id { get; set; }

    public int Programadas { get; set; }

    public int Realizadas { get; set; }

    public int EnteId { get; set; }

    public int DependenciaId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int PeriodoId { get; set; }

    public int EjercicioId { get; set; }

    public virtual Dependencia Dependencia { get; set; } = null!;

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual Ente Ente { get; set; } = null!;

    public virtual Periodo Periodo { get; set; } = null!;
}
