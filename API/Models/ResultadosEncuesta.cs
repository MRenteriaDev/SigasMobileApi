using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ResultadosEncuesta
{
    public int Id { get; set; }

    public int? EntesId { get; set; }

    public int? TipoResultadoEncuestaId { get; set; }

    public string? Nombre { get; set; }

    public string? Documento { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int EjercicioId { get; set; }

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual Ente? Entes { get; set; }

    public virtual TipoResultadoEncuesta? TipoResultadoEncuesta { get; set; }
}
