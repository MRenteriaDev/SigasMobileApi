using System;
using System.Collections.Generic;

namespace API.Models;

public partial class MemorandumSeccione
{
    public int Id { get; set; }

    public int SeccionMemorandumId { get; set; }

    public string? Texto { get; set; }

    public string? Archivo { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? MemoPlaneacionId { get; set; }

    public int? RevisionId { get; set; }

    public int? GrupoRubricasId { get; set; }

    public virtual GrupoRubrica? GrupoRubricas { get; set; }

    public virtual MemoPlaneacion? MemoPlaneacion { get; set; }

    public virtual Revisione? Revision { get; set; }

    public virtual SeccionMemorandum SeccionMemorandum { get; set; } = null!;
}
