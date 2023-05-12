using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Expediente
{
    public int Id { get; set; }

    public int Numero { get; set; }

    public int EjercicioId { get; set; }

    public int TiposExpedienteId { get; set; }

    public int EnteId { get; set; }

    public int StatusExpedienteId { get; set; }

    public int? ObservacionId { get; set; }

    public string? Responsable { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public DateTime FechaRecepcion { get; set; }

    public DateTime FechaActo { get; set; }

    public string? Falta { get; set; }

    public DateTime? FechaRespuesta { get; set; }

    public string? MotivoCancelacion { get; set; }

    public int? ObservacionesId { get; set; }

    public virtual ICollection<DocumentosExpediente> DocumentosExpedientes { get; set; } = new List<DocumentosExpediente>();

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual Ente Ente { get; set; } = null!;

    public virtual ICollection<ExpedienteMovimientosExpediente> ExpedienteMovimientosExpedientes { get; set; } = new List<ExpedienteMovimientosExpediente>();

    public virtual ICollection<ExpedienteObservacion> ExpedienteObservacions { get; set; } = new List<ExpedienteObservacion>();

    public virtual ICollection<ExpedienteStatusExpediente> ExpedienteStatusExpedientes { get; set; } = new List<ExpedienteStatusExpediente>();

    public virtual ICollection<Observacione> ObservacioneExpedienteId1Navigations { get; set; } = new List<Observacione>();

    public virtual ICollection<Observacione> ObservacioneExpedientes { get; set; } = new List<Observacione>();

    public virtual Observacione? Observaciones { get; set; }

    public virtual StatusExpediente StatusExpediente { get; set; } = null!;

    public virtual ICollection<Sustanciacion> Sustanciacions { get; set; } = new List<Sustanciacion>();

    public virtual TiposExpediente TiposExpediente { get; set; } = null!;

    public virtual ICollection<UsuarioExpediente> UsuarioExpedientes { get; set; } = new List<UsuarioExpediente>();
}
