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

    public async void AddUser(User user){
        _context.Add(user);

        await _context.SaveChangesAsync();
    }
}