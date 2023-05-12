using System;
using System.Collections.Generic;

namespace API.Models;

public partial class DeudaFormato
{
    public int Id { get; set; }

    public int Plazo { get; set; }

    public int PeriodoId { get; set; }

    public int EnteId { get; set; }

    public string? Acredor { get; set; }

    public string? TasaBase { get; set; }

    public string? Sobretasa { get; set; }

    public string? MontoAfectado { get; set; }

    public string? TipoGarantia { get; set; }

    public string? Destino { get; set; }

    public DateTime FechaContratacion { get; set; }

    public double MontoContratado { get; set; }

    public double SaldoPeriodo { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int EjercicioId { get; set; }

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual Ente Ente { get; set; } = null!;

    public virtual Periodo Periodo { get; set; } = null!;
}
