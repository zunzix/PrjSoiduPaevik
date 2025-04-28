using Base.Contracts;
using Microsoft.AspNetCore.Identity;

namespace Base.Domain.Identity;

public abstract class BaseUserRole<TUser, TRole> : BaseUserRole<Guid, TUser, TRole>, IDomainId
    where TUser : class //BaseUser<TRole>
    where TRole : class //BaseRole<TUser>
{
}

public abstract class BaseUserRole<TKey, TUser, TRole> : IdentityUserRole<TKey>, IDomainId<TKey>
    where TKey : IEquatable<TKey>
    where TUser : class //BaseUser<TKey, BaseUserRole<TKey, TUser, TRole>>
    where TRole : class //BaseRole<TKey, BaseUserRole<TKey, TUser, TRole>>
{
    public TKey Id { get; set; } = default!;

    public TUser? User { get; set; }
    public TRole? Role { get; set; }
}