using System;
using System.Collections.Generic;

namespace API.Models;

public partial class UnidadAdministrativa
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string ClaveUa { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int AreaId { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual ICollection<Auditoria> AuditoriaUnidadAdministrativaId1Navigations { get; set; } = new List<Auditoria>();

    public virtual ICollection<Auditoria> AuditoriaUnidadAdministrativas { get; set; } = new List<Auditoria>();

    public virtual ICollection<Auditor> Auditors { get; set; } = new List<Auditor>();

    public virtual ICollection<CopiasOficio> CopiasOficios { get; set; } = new List<CopiasOficio>();

    public virtual ICollection<Memorandum> Memoranda { get; set; } = new List<Memorandum>();

    public virtual ICollection<Normatividad> Normatividads { get; set; } = new List<Normatividad>();

    public virtual ICollection<Observacione> Observaciones { get; set; } = new List<Observacione>();

    public virtual ICollection<Planeacion> Planeacions { get; set; } = new List<Planeacion>();

    public virtual ICollection<Plantilla> Plantillas { get; set; } = new List<Plantilla>();

    public virtual ICollection<SeccionesInforme> SeccionesInformes { get; set; } = new List<SeccionesInforme>();
}
