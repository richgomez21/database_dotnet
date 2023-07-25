using WebsiteBlogs.Models;
using WebsiteBlogs.Interfaces;
using WebsiteBlogs.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace WebsiteBlogs.Services;

public class DatabaseServices : IDatabaseService
{
    private ApplicationDbContext _context;

    public DatabaseServices(ApplicationDbContext context)
    {
        _context = context;
    }
		
		public async Task<List<User>> GetAllUsers(){
            return await _context.Users
                                .ToListAsync();
        }

        public async Task<List<Blog>> GetAllBlogs(){
            return await _context.Blogs
                                .ToListAsync();
        }

        public async Task<List<Post>> GetAllPosts(){
            return await _context.Posts
                                .ToListAsync();
        }

    public async Task<User?> GetUserById(int id){
        return await _context.Users
                            .SingleOrDefaultAsync(u => u.Id == id);
    }

    public async Task AddUser(User user){
        _context.Users.Add(user);

        await _context.SaveChangesAsync();
    }

    public async Task UpdateUser(int userId, string newFirstName){
        var existingUser = await _context.Users.FindAsync(userId);

        existingUser.FirstName = newFirstName;

        await _context.SaveChangesAsync();                
    }

    public async Task DeleteUser(int id){
        var newUser = await _context.Users
                                    .SingleOrDefaultAsync(user => user.Id == id);
        if(newUser != null){
            _context.Users.Remove(newUser);

            await _context.SaveChangesAsync();
        }
    } 

    public async Task AddBlog(Blog blog){
        _context.Blogs.Add(blog);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateBlog(int blogId, string blogName){
          var existingBlog = await _context.Blogs.FindAsync(blogId);

        existingBlog.Name = blogName;

        await _context.SaveChangesAsync(); 
    }

    public async Task DeleteBlog(int id){
        var newBlog = await _context.Blogs
                                .SingleOrDefaultAsync(blog => blog.Id == id);
        if(newBlog != null){
        _context.Blogs.Remove(newBlog);

        await _context.SaveChangesAsync();
       
        }
    }

    public async Task AddPost(Post post){
        _context.Posts.Add(post);
        await _context.SaveChangesAsync();
    }

    public async Task UpdatePost(int postId, string title){
        var existingPost = await _context.Posts.FindAsync(postId);

        existingPost.Title = title;

        await _context.SaveChangesAsync(); 
    }

    public async Task DeletePost(int id){
       var newPost = await _context.Posts
                                .SingleOrDefaultAsync(post => post.Id == id);
        if(newPost != null){
        _context.Posts.Remove(newPost);

        await _context.SaveChangesAsync();
       
        }
    }  


}