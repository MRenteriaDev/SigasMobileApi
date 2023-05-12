using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Rubro
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Createdby { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Clave { get; set; }

    public string? Descripcion { get; set; }

    public string? NoCuenta { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Cedula> Cedulas { get; set; } = new List<Cedula>();

    public virtual ICollection<Cuestionario> Cuestionarios { get; set; } = new List<Cuestionario>();

    public virtual ICollection<Hallazgo> Hallazgos { get; set; } = new List<Hallazgo>();

    public virtual ICollection<Plantilla> Plantillas { get; set; } = new List<Plantilla>();

    public virtual ICollection<RubroAuditado> RubroAuditados { get; set; } = new List<RubroAuditado>();

    public virtual ICollection<RubroProcedimiento> RubroProcedimientos { get; set; } = new List<RubroProcedimiento>();

    public virtual ICollection<RubroSeccionesInforme> RubroSeccionesInformes { get; set; } = new List<RubroSeccionesInforme>();

    public virtual ICollection<RubroTipoAuditoria> RubroTipoAuditoria { get; set; } = new List<RubroTipoAuditoria>();
}
