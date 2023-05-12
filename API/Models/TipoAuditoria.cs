using System;
using System.Collections.Generic;

namespace API.Models;

public partial class TipoAuditoria
{
    public int Id { get; set; }

    public string Clave { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? TipoAuditoriaGeneral { get; set; }

    public int Orden { get; set; }

    public string? NombreUa { get; set; }

    public string? NombreRegular { get; set; }

    public virtual ICollection<Anexo> Anexos { get; set; } = new List<Anexo>();

    public virtual ICollection<Auditoria> Auditoria { get; set; } = new List<Auditoria>();

    public virtual ICollection<CalificacionClase> CalificacionClases { get; set; } = new List<CalificacionClase>();

    public virtual ICollection<Cuestionario> Cuestionarios { get; set; } = new List<Cuestionario>();

    public virtual ICollection<Informe> Informes { get; set; } = new List<Informe>();

    public virtual ICollection<TipoAuditoria> InverseTipoAuditoriaGeneralNavigation { get; set; } = new List<TipoAuditoria>();

    public virtual ICollection<Memorandum> Memoranda { get; set; } = new List<Memorandum>();

    public virtual ICollection<PlaneacionTipoAuditoria> PlaneacionTipoAuditoria { get; set; } = new List<PlaneacionTipoAuditoria>();

    public virtual ICollection<Planeacion> Planeacions { get; set; } = new List<Planeacion>();

    public virtual ICollection<Plantilla> Plantillas { get; set; } = new List<Plantilla>();

    public virtual ICollection<Ponderacion> Ponderacions { get; set; } = new List<Ponderacion>();

    public virtual ICollection<Revisione> Revisiones { get; set; } = new List<Revisione>();

    public virtual ICollection<RubroProcedimiento> RubroProcedimientos { get; set; } = new List<RubroProcedimiento>();

    public virtual ICollection<RubroTipoAuditoria> RubroTipoAuditoria { get; set; } = new List<RubroTipoAuditoria>();

    public virtual ICollection<SeccionesInforme> SeccionesInformes { get; set; } = new List<SeccionesInforme>();

    public virtual TipoAuditoria? TipoAuditoriaGeneralNavigation { get; set; }

    public virtual ICollection<TipoClasificacion> TipoClasificacions { get; set; } = new List<TipoClasificacion>();
}
