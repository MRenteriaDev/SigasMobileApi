using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Anuncio
{
    public int Id { get; set; }

    public string? Titulo { get; set; }

    public string? Contenido { get; set; }

    public string? Tipo { get; set; }

    public string? Adjunto { get; set; }

    public DateTime FechaProgramacion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int TipoAnuncioId { get; set; }

    public bool Activo { get; set; }

    public bool IsPopup { get; set; }

    public bool VerEnPagina { get; set; }

    public virtual TipoAnuncio TipoAnuncio { get; set; } = null!;
}
