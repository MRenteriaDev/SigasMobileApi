using System;
using System.Collections.Generic;

namespace API.Models;

public partial class FormatosDocumentosdeTrabajo
{
    public int Id { get; set; }

    public int EtapasAuditoriaId { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Archivo { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual EtapasAuditoria EtapasAuditoria { get; set; } = null!;

    public virtual ICollection<Papele> Papeles { get; set; } = new List<Papele>();
}
