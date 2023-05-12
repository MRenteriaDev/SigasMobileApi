using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Papele
{
    public int Id { get; set; }

    public int? EjerciciosId { get; set; }

    public int? EntesId { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Documento { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int AuditoriaId { get; set; }

    public int? AuditoriasId { get; set; }

    public int? FormatosDocumentosdeTrabajoId { get; set; }

    public int Orden { get; set; }

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual Auditoria? Auditorias { get; set; }

    public virtual Ejercicio? Ejercicios { get; set; }

    public virtual Ente? Entes { get; set; }

    public virtual FormatosDocumentosdeTrabajo? FormatosDocumentosdeTrabajo { get; set; }
}
