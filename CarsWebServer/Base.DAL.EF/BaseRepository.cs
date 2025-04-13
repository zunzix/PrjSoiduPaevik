﻿using Base.Contracts;
using Base.DAL.Contracts;
using Base.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Base.DAL.EF;

public class BaseRepository<TEntity> : BaseRepository<TEntity, Guid>, IRepository<TEntity>
    where TEntity : class, IDomainId
{
    public BaseRepository(DbContext repositoryDbContext) : base(repositoryDbContext)
    {
    }
}

public class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey>
    where TEntity : class, IDomainId<TKey>
    where TKey : IEquatable<TKey>
{
    protected DbContext RepositoryDbContext;
    protected DbSet<TEntity> RepositoryDbSet;


    public BaseRepository(DbContext repositoryDbContext)
    {
        RepositoryDbContext = repositoryDbContext;
        RepositoryDbSet = RepositoryDbContext.Set<TEntity>();
    }


    protected virtual IQueryable<TEntity> GetQuery(TKey? userId = default!)
    {
        var query = RepositoryDbSet.AsQueryable();

        // todo : check userId for null/default
        if (typeof(IDomainUserId<TKey>).IsAssignableFrom(typeof(TEntity)) &&
            userId != null &&
            !EqualityComparer<TKey>.Default.Equals(userId, default))
        {
            query = query.Where(e => ((IDomainUserId<TKey>)e).UserId.Equals(userId));
        }

        return query;
    }

    // TODO: Implement UOW, remove SaveChangesAsync from repository
    public async Task<int> SaveChangesAsync()
    {
        return await RepositoryDbContext.SaveChangesAsync();
    }

    public virtual IEnumerable<TEntity> All(TKey? userId = default!)
    {
        return GetQuery(userId)
            .ToList();
    }

    public virtual async Task<IEnumerable<TEntity>> AllAsync(TKey? userId = default!)
    {
        return await GetQuery(userId)
            .ToListAsync();
    }

    public virtual TEntity? Find(TKey id, TKey? userId = default!)
    {
        var query = GetQuery(userId);
        return query.FirstOrDefault(e => e.Id.Equals(id));
    }

    public virtual async Task<TEntity?> FindAsync(TKey id, TKey? userId = default!)
    {
        var query = GetQuery(userId);
        return await query.FirstOrDefaultAsync(e => e.Id.Equals(id));
    }

    public virtual void Add(TEntity entity)
    {
        RepositoryDbSet.Add(entity);
    }

    public virtual TEntity Update(TEntity entity)
    {
        return RepositoryDbSet.Update(entity).Entity;
    }

    public virtual void Remove(TEntity entity, TKey? userId = default!)
    {
        Remove(entity.Id, userId);
    }

    public virtual void Remove(TKey id, TKey? userId)
    {
        var query = GetQuery(userId);
        query = query.Where(e => e.Id.Equals(id));
        var dbEntity = query.FirstOrDefault();
        if (dbEntity != null)
        {
            RepositoryDbSet.Remove(dbEntity);
        }
    }

    public virtual async Task RemoveAsync(TKey id, TKey? userId = default!)
    {
        var query = GetQuery(userId);
        query = query.Where(e => e.Id.Equals(id));
        var dbEntity = await query.FirstOrDefaultAsync();
        if (dbEntity != null)
        {
            RepositoryDbSet.Remove(dbEntity);
        }
    }

    public virtual bool Exists(Guid id, TKey? userId = default)
    {
        var query = GetQuery(userId);
        return query.Any(e => e.Id.Equals(id));
    }

    public virtual async Task<bool> ExistsAsync(Guid id, TKey? userId = default)
    {
        var query = GetQuery(userId);
        return await query.AnyAsync(e => e.Id.Equals(id));
    }
}