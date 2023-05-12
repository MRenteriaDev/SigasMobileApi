using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Anexo
{
    public int Id { get; set; }

    public int Orden { get; set; }

    public int TipoAuditoriaId { get; set; }

    public string? Nombre { get; set; }

    public string? Instrucciones { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int TipoEnteId { get; set; }

    public int EjercicioId { get; set; }

    public string? Tabla { get; set; }

    public string? Formato { get; set; }

    public int? TipoAnexoId { get; set; }

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();

    public virtual TipoAnexo? TipoAnexo { get; set; }

    public virtual TipoAuditoria TipoAuditoria { get; set; } = null!;

    public virtual TipoEnte TipoEnte { get; set; } = null!;
}
