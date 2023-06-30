﻿namespace CleanArchitecture.Application.Common.Interfaces;

public interface IRepositoryBase<T> where T : class
{
    Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
    Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
    Task DeleteAsync(T entity, CancellationToken cancellationToken = default);
}