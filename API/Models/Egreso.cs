using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Egreso
{
    public int Id { get; set; }

    public int PeriodoId { get; set; }

    public int EnteId { get; set; }

    public int? DependenciaId { get; set; }

    public int PartidaId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public double Inicial { get; set; }

    public double Ampliacion { get; set; }

    public double Reduccion { get; set; }

    public double Modificado { get; set; }

    public double Comprometido { get; set; }

    public double Devengado { get; set; }

    public double Ejercido { get; set; }

    public double Pagado { get; set; }

    public int EjercicioId { get; set; }

    public int TipoEgreso { get; set; }

    public virtual Dependencia? Dependencia { get; set; }

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual Ente Ente { get; set; } = null!;

    public virtual Partida Partida { get; set; } = null!;

    public virtual Periodo Periodo { get; set; } = null!;
}
