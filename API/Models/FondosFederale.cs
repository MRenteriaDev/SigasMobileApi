using System;
using System.Collections.Generic;

namespace API.Models;

public partial class FondosFederale
{
    public int Id { get; set; }

    public string? Programa { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? NombreCorto { get; set; }

    public virtual ICollection<FondosFederalesRecibido> FondosFederalesRecibidos { get; set; } = new List<FondosFederalesRecibido>();

    public virtual ICollection<Informe> Informes { get; set; } = new List<Informe>();

    public virtual ICollection<Planeacion> Planeacions { get; set; } = new List<Planeacion>();

    public virtual ICollection<RubroAuditado> RubroAuditados { get; set; } = new List<RubroAuditado>();
}
