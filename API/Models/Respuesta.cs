using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Respuesta
{
    public int Id { get; set; }

    public int AuditoriaId { get; set; }

    public int PreguntaId { get; set; }

    public string? Texto { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public double Valor { get; set; }

    public int CuestionarioAuditoriaId { get; set; }

    public double? Porcentaje { get; set; }

    public string? TextoExtra { get; set; }

    public string? Tabla { get; set; }

    public string? Inciso { get; set; }

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual CuestionarioAuditoria CuestionarioAuditoria { get; set; } = null!;

    public virtual ICollection<Hallazgo> Hallazgos { get; set; } = new List<Hallazgo>();

    public virtual Pregunta Pregunta { get; set; } = null!;
}
