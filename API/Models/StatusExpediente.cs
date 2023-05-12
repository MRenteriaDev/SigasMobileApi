using System;
using System.Collections.Generic;

namespace API.Models;

public partial class StatusExpediente
{
    public int Id { get; set; }

    public int Dias { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<ExpedienteStatusExpediente> ExpedienteStatusExpedientes { get; set; } = new List<ExpedienteStatusExpediente>();

    public virtual ICollection<Expediente> Expedientes { get; set; } = new List<Expediente>();
}
