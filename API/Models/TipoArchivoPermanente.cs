using System;
using System.Collections.Generic;

namespace API.Models;

public partial class TipoArchivoPermanente
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Interno { get; set; }

    public virtual ICollection<ArchivoPermanente> ArchivoPermanentes { get; set; } = new List<ArchivoPermanente>();
}
