using MediatR;

namespace KTMS.Application.Common.Paging;

/// <summary>
/// Base class for list queries with pagination, search, and sorting.
/// </summary>
public abstract class BasePagedQuery<TItem> : IRequest<PageResult<TItem>>
{
    /// <summary>Pagination parameters (page number and page size).</summary>
    public PageRequest Paging { get; init; } = new();
}