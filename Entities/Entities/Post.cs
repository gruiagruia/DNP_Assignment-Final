using System.ComponentModel.DataAnnotations;

<<<<<<< HEAD:Entities/Post.cs
namespace Entities;
=======
namespace Entities.Entities;
>>>>>>> origin/master:Entities/Entities/Post.cs

public class Post
{
    public int Id { get; set; }
    public string Owner { get; set; }
    [Required,MaxLength(128)]
    public string Title { get; set; }
    [Required,MaxLength(5000)]
    public string Body { get; set; }

    public Post(string owner, string title, string body)
    {
        Owner = owner;
        Title = title;
        Body = body;
    }

    public Post()
    {
        
    }
}