using System;
using System.Collections.Generic;

namespace API.Models;

public partial class SeccionesInformeRubroAuditado
{
    public int Id { get; set; }

    public int InformeSeccionesInformesId { get; set; }

    public int RubroAuditadoId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime Created { get; set; }

    public int Orden { get; set; }

    public virtual InformeSeccionesInforme InformeSeccionesInformes { get; set; } = null!;

    public virtual RubroAuditado RubroAuditado { get; set; } = null!;
}
