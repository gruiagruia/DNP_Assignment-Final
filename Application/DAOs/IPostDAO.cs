<<<<<<< HEAD:Application/DAOs/IPostDAO.cs
using Entities;

namespace Application.DAOs;
=======
using Entities.Entities;

namespace Contracts;
>>>>>>> origin/master:Contracts/IPostService.cs

public interface IPostDAO
{
    public Task<ICollection<Post>> GetAsync();
    public Task<Post> GetById(int id);
    public Task<Post> AddAsync(Post todo);
    public Task DeleteAsync(int id);
    public Task UpdateAsync(Post todo);
}