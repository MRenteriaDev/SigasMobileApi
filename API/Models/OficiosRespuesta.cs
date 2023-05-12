using System;
using System.Collections.Generic;

namespace API.Models;

public partial class OficiosRespuesta
{
    public int Id { get; set; }

    public int DocumentosId { get; set; }

    public string? NumOficio { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime FechaEntregaIsaf { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Documento Documentos { get; set; } = null!;
}
