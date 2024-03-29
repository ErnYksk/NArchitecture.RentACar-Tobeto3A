﻿namespace Core.Persistence.Repositories;

public class BaseEntity <TId> : IEntityTimeStamps
{
    public TId Id { get; set; }

    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
   
    public BaseEntity()
    {
         
    }

    public BaseEntity(TId id, DateTime createdDate, DateTime updatedDate, DateTime deletedDate)
    {
        Id = id;
        CreatedDate = createdDate;
        UpdatedDate = updatedDate;
        DeletedDate = deletedDate;
    }
}
