using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Objeto
{
    public int Id { get; set; }

    public int Numero { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? TipoObjeto { get; set; }

    public virtual ICollection<Concepto> Conceptos { get; set; } = new List<Concepto>();

    public virtual ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();

    public virtual ICollection<IngresoAuditoria> IngresoAuditoria { get; set; } = new List<IngresoAuditoria>();
}
