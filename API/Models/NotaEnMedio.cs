using System;
using System.Collections.Generic;

namespace API.Models;

public partial class NotaEnMedio
{
    public int Id { get; set; }

    public int MedioId { get; set; }

    public int EnteId { get; set; }

    public string? Resumen { get; set; }

    public string? EnlaceInternet { get; set; }

    public bool IsRelevante { get; set; }

    public DateTime FechaNota { get; set; }

    public string? EvidenciaFisica { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Titulo { get; set; }

    public virtual Ente Ente { get; set; } = null!;

    public virtual Medio Medio { get; set; } = null!;
}
