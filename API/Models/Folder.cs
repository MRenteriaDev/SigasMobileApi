using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Folder
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? AnexoId { get; set; }

    public int AuditoriaId { get; set; }

    public string? ContainerName { get; set; }

    public int? ParentFolderId { get; set; }

    public string? Instrucciones { get; set; }

    public int Orden { get; set; }

    public string CreatedById { get; set; } = null!;

    public DateTime Created { get; set; }

    public virtual Anexo? Anexo { get; set; }

    public virtual ICollection<Archivo> Archivos { get; set; } = new List<Archivo>();

    public virtual Auditoria Auditoria { get; set; } = null!;

    public virtual User CreatedBy { get; set; } = null!;

    public virtual ICollection<Folder> InverseParentFolder { get; set; } = new List<Folder>();

    public virtual Folder? ParentFolder { get; set; }
}
