using System;
using System.Collections.Generic;

namespace API.Models;

public partial class CumplimientoEtca
{
    public int Id { get; set; }

    public int EntesId { get; set; }

    public int PeriodosId { get; set; }

    public int EtcasId { get; set; }

    public DateTime FechaAnalisis { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int EjercicioId { get; set; }

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual Ente Entes { get; set; } = null!;

    public virtual Etca Etcas { get; set; } = null!;

    public virtual Periodo Periodos { get; set; } = null!;
}
