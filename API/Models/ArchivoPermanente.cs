using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ArchivoPermanente
{
    public int Id { get; set; }

    public int EnteId { get; set; }

    public int TipoArchivoPermanenteId { get; set; }

    public string? Titulo { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaBoletin { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Extracto { get; set; }

    public virtual Ente Ente { get; set; } = null!;

    public virtual TipoArchivoPermanente TipoArchivoPermanente { get; set; } = null!;
}
