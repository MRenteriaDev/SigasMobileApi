using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Gasto
{
    public int Id { get; set; }

    public long Devengado { get; set; }

    public int EjercicioId { get; set; }

    public int EnteId { get; set; }

    public int ObjetoId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int PeriodoId { get; set; }

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual Ente Ente { get; set; } = null!;

    public virtual ICollection<GastoAuditoria> GastoAuditoria { get; set; } = new List<GastoAuditoria>();

    public virtual Objeto Objeto { get; set; } = null!;

    public virtual Periodo Periodo { get; set; } = null!;
}
