using System;
using System.Collections.Generic;

namespace API.Models;

public partial class InformacionFinanciera
{
    public int Id { get; set; }

    public int EjercicioId { get; set; }

    public int FormatoId { get; set; }

    public int PeriodoId { get; set; }

    public int EnteId { get; set; }

    public string? Archivo { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? EntregadoFisicamente { get; set; }

    public int? InformacionTrimestralId { get; set; }

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual Ente Ente { get; set; } = null!;

    public virtual Formato Formato { get; set; } = null!;

    public virtual InformacionTrimestralEntregada? InformacionTrimestral { get; set; }

    public virtual Periodo Periodo { get; set; } = null!;
}
