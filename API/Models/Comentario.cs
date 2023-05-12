using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Comentario
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public int? AuditoriaId { get; set; }

    public string? Texto { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? TipoComentariosId { get; set; }

    public int ElementoId { get; set; }

    public virtual Auditoria? Auditoria { get; set; }

    public virtual TipoComentario? TipoComentarios { get; set; }

    public virtual User? User { get; set; }
}
