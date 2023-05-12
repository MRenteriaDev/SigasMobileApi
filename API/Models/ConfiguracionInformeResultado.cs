using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ConfiguracionInformeResultado
{
    public int Id { get; set; }

    public int EjercicioId { get; set; }

    public int EnteId { get; set; }

    public double BalancePresupuestario { get; set; }

    public double BprecursosDisponibles { get; set; }

    public string? InterpretacionBpr { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? InterpretacionBp { get; set; }

    public double IndiceCumplimiento { get; set; }

    public bool TieneObservacionesFondoFederal { get; set; }

    public double TotalRecaudacion { get; set; }

    public double PresupuestoOriginal { get; set; }

    public bool PublicacionRf { get; set; }

    public bool ResultadoGf { get; set; }

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual Ente Ente { get; set; } = null!;
}
