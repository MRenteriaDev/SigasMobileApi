using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Auditor
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public string? Prefijo { get; set; }

    public string? Sufijo { get; set; }

    public string? Puesto { get; set; }

    public bool Activo { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? CedulaProfesional { get; set; }

    public string? IdIsaf { get; set; }

    public int UnidadAdministrativaId { get; set; }

    public string? Genero { get; set; }

    public int TipoAuditorId { get; set; }

    public int? JefeDirectoId { get; set; }

    public string? Credencial { get; set; }

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual ICollection<AuditorAuditoria> AuditorAuditoria { get; set; } = new List<AuditorAuditoria>();

    public virtual ICollection<Auditoria> Auditoria { get; set; } = new List<Auditoria>();

    public virtual ICollection<Cedula> Cedulas { get; set; } = new List<Cedula>();

    public virtual ICollection<EquipoAuditor> EquipoAuditors { get; set; } = new List<EquipoAuditor>();

    public virtual ICollection<GrupoRubricasAuditor> GrupoRubricasAuditors { get; set; } = new List<GrupoRubricasAuditor>();

    public virtual ICollection<Hallazgo> Hallazgos { get; set; } = new List<Hallazgo>();

    public virtual ICollection<Auditor> InverseJefeDirecto { get; set; } = new List<Auditor>();

    public virtual Auditor? JefeDirecto { get; set; }

    public virtual ICollection<NotsModel> NotsModels { get; set; } = new List<NotsModel>();

    public virtual ICollection<Oficio> Oficios { get; set; } = new List<Oficio>();

    public virtual ICollection<RecepcionDocumentacion> RecepcionDocumentacions { get; set; } = new List<RecepcionDocumentacion>();

    public virtual TipoAuditor TipoAuditor { get; set; } = null!;

    public virtual UnidadAdministrativa UnidadAdministrativa { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
