using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Pregunta
{
    public int Id { get; set; }

    public int CuestionarioId { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? Orden { get; set; }

    public int TipoPreguntaId { get; set; }

    public int TipoIndicadoresId { get; set; }

    public virtual Cuestionario Cuestionario { get; set; } = null!;

    public virtual ICollection<Recomendacion> Recomendacions { get; set; } = new List<Recomendacion>();

    public virtual ICollection<Respuesta> Respuesta { get; set; } = new List<Respuesta>();

    public virtual TipoIndicadore TipoIndicadores { get; set; } = null!;

    public virtual TipoPregunta TipoPregunta { get; set; } = null!;
}
