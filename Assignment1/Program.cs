
using Assignment1.Entities;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

var dbcontect = new DataContext();


var user1 = new User
{
    Name = "JohnDoe",
    Email = "john.doe@example.com",
    PhoneNumber = "123-456-7890"
};

var user2 = new User
{
    Name = "JaneSmith",
    Email = "jane.smith@example.com",
    PhoneNumber = "987-654-3210"
};
dbcontect.Users.Add(user1);
dbcontect.Users.Add(user2);
dbcontect.SaveChanges();


var blogType = new BlogType
{

    Name = "Technology",
    Description = "A blog about technology topics"
};

var postType = new PostType
{
    Name = "Tutorial",
    Description = "A tutorial post"
};

dbcontect.BlogTypes.Add(blogType);
dbcontect.PostTypes.Add(postType);
dbcontect.SaveChanges();

var blog = new Blog
{
    Url = "http://example.com",
    IsPublic = true,
    Name = "vrunda",
    BlogTypeId = blogType.Id // Assuming BlogType has a property Id
};
dbcontect.Blogs.Add(blog);
dbcontect.SaveChanges();



List<User> users;
List<Blog> blogs;
List<PostType> postTypes;


users = dbcontect.Users.ToList();
var UserId = users.First().Id;

blogs = dbcontect.Blogs.ToList();
var BlogId = blogs.First().Id;

postTypes = dbcontect.PostTypes.ToList();
var postTypeId = postTypes.First().Id;


var newPost = new Post
{
    Title = "New Post Title",
    content = "This is the content of the new post",
    UserId = UserId,
    BlogId = BlogId,
    PostTypeId = postTypeId

};

dbcontect.Posts.Add(newPost);
dbcontect.SaveChanges();


var foundblogtype = dbcontect.BlogTypes.FirstOrDefault();
Console.WriteLine($"{foundblogtype.Name},{foundblogtype.Description}");
