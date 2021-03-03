using System;

namespace Interview.CartCase.Domain.Interfaces
{
    public interface IEntity<TId> where TId: IEquatable<TId>
    {
        TId Id { get; }
        DateTime Created { get; set; }
        TId Creator { get; set; }
        DateTime Modified { get; set; }
        TId Modifier { get; set; }
        bool IsActive { get; set; }
    }
}