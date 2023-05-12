using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Balanza
{
    public int Id { get; set; }

    public int PeriodoId { get; set; }

    public int EnteId { get; set; }

    public int EjercicioId { get; set; }

    public int RubroId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public double SaldoDebe { get; set; }

    public double SaldoHaber { get; set; }

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual Ente Ente { get; set; } = null!;

    public virtual Periodo Periodo { get; set; } = null!;

    public virtual RubrosInformacionFinanciera Rubro { get; set; } = null!;
}
