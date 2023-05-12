using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Archivo
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Blob { get; set; }

    public string? Size { get; set; }

    public int FolderId { get; set; }

    public string? CreatedById { get; set; }

    public DateTime Created { get; set; }

    public virtual ICollection<ArchivoDocumento> ArchivoDocumentos { get; set; } = new List<ArchivoDocumento>();

    public virtual User? CreatedBy { get; set; }

    public virtual Folder Folder { get; set; } = null!;
}
