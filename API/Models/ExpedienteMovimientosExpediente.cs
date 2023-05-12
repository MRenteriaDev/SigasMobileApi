using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ExpedienteMovimientosExpediente
{
    public int Id { get; set; }

    public int ExpedienteId { get; set; }

    public int MovimientosExpedienteId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime? FechaInicio { get; set; }

    public string? IniciadoBy { get; set; }

    public string? DetalleMovimiento { get; set; }

    public virtual Expediente Expediente { get; set; } = null!;
}
