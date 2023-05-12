using System;
using System.Collections.Generic;

namespace API.Models;

public partial class InformeSeccionesInforme
{
    public int Id { get; set; }

    public int Orden { get; set; }

    public int InformeId { get; set; }

    public int SeccionesInformesId { get; set; }

    public string? Texto { get; set; }

    public string? TextoHtml { get; set; }

    public string? Createdby { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Documento { get; set; }

    public virtual Informe Informe { get; set; } = null!;

    public virtual ICollection<SeccionesInformeRubroAuditado> SeccionesInformeRubroAuditados { get; set; } = new List<SeccionesInformeRubroAuditado>();

    public virtual SeccionesInforme SeccionesInformes { get; set; } = null!;
}
