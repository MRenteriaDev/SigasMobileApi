using System;
using System.Collections.Generic;

namespace API.Models;

public partial class CursoDocumento
{
    public int Id { get; set; }

    public int CursoId { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Archivo { get; set; }

    public virtual Curso Curso { get; set; } = null!;
}
