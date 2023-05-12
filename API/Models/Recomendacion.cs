using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Recomendacion
{
    public int Id { get; set; }

    public int PreguntaId { get; set; }

    public string? Hallazgo { get; set; }

    public string? Descripcion { get; set; }

    public string? Normatividad { get; set; }

    public string? Texto { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public double Valor { get; set; }

    public string? Inciso { get; set; }

    public virtual Pregunta Pregunta { get; set; } = null!;
}
