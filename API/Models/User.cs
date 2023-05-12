using System;
using System.Collections.Generic;

namespace API.Models;

public partial class User
{
    public string Id { get; set; } = null!;

    public int? EnteId { get; set; }

    public string? Email { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string UserName { get; set; } = null!;

    public string? Responsable { get; set; }

    public int? AuditorId { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<ArchivoDocumento> ArchivoDocumentos { get; set; } = new List<ArchivoDocumento>();

    public virtual ICollection<Archivo> Archivos { get; set; } = new List<Archivo>();

    public virtual Auditor? Auditor { get; set; }

    public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

    public virtual ICollection<CuestionarioAuditoria> CuestionarioAuditoria { get; set; } = new List<CuestionarioAuditoria>();

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual ICollection<DocumentosExpediente> DocumentosExpedientes { get; set; } = new List<DocumentosExpediente>();

    public virtual Ente? Ente { get; set; }

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();

    public virtual ICollection<LogStorageFile> LogStorageFiles { get; set; } = new List<LogStorageFile>();

    public virtual ICollection<NotsModel> NotsModels { get; set; } = new List<NotsModel>();

    public virtual ICollection<UserClaim> UserClaims { get; set; } = new List<UserClaim>();

    public virtual ICollection<UserLogin> UserLogins { get; set; } = new List<UserLogin>();

    public virtual ICollection<UsuarioEnte> UsuarioEntes { get; set; } = new List<UsuarioEnte>();

    public virtual ICollection<UsuarioExpediente> UsuarioExpedientes { get; set; } = new List<UsuarioExpediente>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
