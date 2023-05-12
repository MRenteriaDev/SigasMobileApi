using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Oficio
{
    public int Id { get; set; }

    public int AuditoriaId { get; set; }

    public int? AuditorId { get; set; }

    public int? OficioNotificacionId { get; set; }

    public int TipoOficioId { get; set; }

    public string? Ciudad { get; set; }

    public string? NumeroOficio { get; set; }

    public string? Documento { get; set; }

    public string? DocumentoScaneado { get; set; }

    public string? NumeroObra { get; set; }

    public string? NombreObra { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Fecha { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public DateTime? FechaFin { get; set; }

    public bool? PlazoAdicional { get; set; }

    public bool PresentaTestigos { get; set; }

    public bool RespuestaPrevia { get; set; }

    public bool RespuestaRevisada { get; set; }

    public int? RevisionId { get; set; }

    public DateTime? FechaRecibidoNotificacion { get; set; }

    public bool RespuestaEnVisita { get; set; }

    public string? FirmadoPor { get; set; }

    public string? FirmadoPorPuesto { get; set; }

    public int? ProveedorId { get; set; }

    public bool? Local { get; set; }

    public int? GrupoRubricasId { get; set; }

    public int? FuncionarioId { get; set; }

    public string? TipoActaHechos { get; set; }

    public int? ObservacionId { get; set; }

    public virtual Auditor? Auditor { get; set; }

    public virtual ICollection<AuditorAuditoria> AuditorAuditoriaOficioComisions { get; set; } = new List<AuditorAuditoria>();

    public virtual ICollection<AuditorAuditoria> AuditorAuditoriaOficioNotificacions { get; set; } = new List<AuditorAuditoria>();

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual Funcionario? Funcionario { get; set; }

    public virtual GrupoRubrica? GrupoRubricas { get; set; }

    public virtual ICollection<Oficio> InverseOficioNotificacion { get; set; } = new List<Oficio>();

    public virtual Observacione? Observacion { get; set; }

    public virtual Oficio? OficioNotificacion { get; set; }

    public virtual Proveedore? Proveedor { get; set; }

    public virtual Revisione? Revision { get; set; }

    public virtual TipoOficio TipoOficio { get; set; } = null!;
}
