namespace Core.Persistence.Repositories;

public interface IEntityTimeStamps
{
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
}