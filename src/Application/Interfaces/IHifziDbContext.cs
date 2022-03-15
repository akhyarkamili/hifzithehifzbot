namespace Application.Interfaces;

public interface IHifziDbContext
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
}