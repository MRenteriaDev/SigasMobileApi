using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Concepto
{
    public int Id { get; set; }

    public int ObjetoId { get; set; }

    public int Numero { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<Cedula> Cedulas { get; set; } = new List<Cedula>();

    public virtual Objeto Objeto { get; set; } = null!;

    public virtual ICollection<Partida> Partida { get; set; } = new List<Partida>();
}
