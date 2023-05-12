using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ExpedienteStatusExpediente
{
    public int Id { get; set; }

    public int ExpedienteId { get; set; }

    public int StatusExpedienteId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime? FechaNotificado { get; set; }

    public string? NotificadoBy { get; set; }

    public string? Detalle { get; set; }

    public virtual Expediente Expediente { get; set; } = null!;

    public virtual StatusExpediente StatusExpediente { get; set; } = null!;
}
