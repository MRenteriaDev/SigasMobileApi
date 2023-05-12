using System;
using System.Collections.Generic;

namespace API.Models;

public partial class NoConformidad
{
    public int Id { get; set; }

    public int? ApartadoId { get; set; }

    public int? RubroAuditadoId { get; set; }

    public int StatusNoConformidadId { get; set; }

    public int ClasificacionNoConformidadId { get; set; }

    public string? Descripcion { get; set; }

    public string? Accion { get; set; }

    public string? Comentarios { get; set; }

    public string? EvidenciaRespuesta { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int AuditoriaId { get; set; }

    public string? Tabla { get; set; }

    public string? Evidencia { get; set; }

    public virtual Apartado? Apartado { get; set; }

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual ClasificacionNoConformidad ClasificacionNoConformidad { get; set; } = null!;

    public virtual RubroAuditado? RubroAuditado { get; set; }

    public virtual StatusNoConformidad StatusNoConformidad { get; set; } = null!;
}
