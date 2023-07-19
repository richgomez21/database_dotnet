using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using WebsiteBlogs.Models;
using WebsiteBlogs.Data;
using WebsiteBlogs.Services;

DatabaseServices _dbservice;

var services = new ServiceCollection();

services.AddDbContext<ApplicationDbContext>();
services.AddScoped<DatabaseServices>();

var serviceProvider = services.BuildServiceProvider();
_dbservice = serviceProvider.GetRequiredService<DatabaseServices>();

SeedData.Initialize(serviceProvider);

/*
    TODO: Create an instance of the DatabaseService in order to test
            your methods in that class.

            Note that you DO NOT need to comment out the SeedData.Initialize()
            method after seeding the database. The initialization method checks
            to see if the database is empty before executing. So if you have already
            populated the database, the initialization will not run again.
            If you would like to comment out the SeedData.Initialize() line, that
            is fine - it won't hurt anything - but no worries if you leave it in.
*/

Console.WriteLine("====================== NUMBER 1 BEGIN ======================");
// 1. Test GetAllUsers
//    Call GetAllUsers method on dbService and print the count of users. It should be 5.

    var allUsers = await _dbservice.GetAllUsers();
    var count = 0;
    foreach(User? user in allUsers){
        count++;
        Console.WriteLine(@$"{count} User: {user.FirstName}");
    }
Console.WriteLine("====================== NUMBER 1 END ======================");

Console.WriteLine("====================== NUMBER 2 BEGIN ======================");

// 2. Test GetUserById
//    Call GetUserById method on dbService with parameter id=1, print the user's name. It should be John Doe.
    var getUser = await _dbservice.GetUserById(1);
    
    Console.WriteLine(@$"{getUser.FirstName} {getUser.LastName}");

Console.WriteLine("====================== NUMBER 2 END ======================");

Console.WriteLine("====================== NUMBER 3 BEGIN ======================");
// 3. Test AddUser
//    Create a new User object with FirstName = "New", LastName = "User", Email = "new@example.com".
//    Call AddUser method on dbService with the new User object.
//    Again, call GetAllUsers and print the count of users. It should be 6.
    User DBlock = new User{
        FirstName = "New",
        LastName = "User",
        Email = "new@example.com"
    };
         await _dbservice.AddUser(DBlock);
         Console.WriteLine(DBlock.FirstName);
        
    
Console.WriteLine("====================== NUMBER 3 END ======================");

Console.WriteLine("====================== NUMBER 4 BEGIN ======================");
// 4. Test UpdateUser
//    Update the FirstName of the new User object to "Updated".
//    Call UpdateUser method on dbService with the updated User object.
//    Call GetUserById method with id of the new User, print the user's name. It should be "Updated User".
   
    await _dbservice.UpdateUser(6,"Updated");
    var update = await _dbservice.GetUserById(6);
    Console.WriteLine(update.FirstName);

Console.WriteLine("====================== NUMBER 4 END ======================");

Console.WriteLine("====================== NUMBER 5 BEGIN ======================");

// 5. Test DeleteUser
//    Call DeleteUser method on dbService with the id of the new User.
//    Again, call GetAllUsers and print the count of users. It should be 5.
 await _dbservice.DeleteUser(10);
var result = await _dbservice.GetAllUsers();
int count5 = 0;
foreach(User user in result){
    count5++;
}
Console.WriteLine(count5);

Console.WriteLine("====================== NUMBER 5 END ======================");

Console.WriteLine("====================== NUMBER 6 BEGIN ======================");

// 6. Test GetAllBlogs
//    Call GetAllBlogs method on dbService and print the count of blogs. It should be 5.
    var allBlogs = await _dbservice.GetAllBlogs();
    var count6 = 0;
    foreach(Blog? blog in allBlogs){
        count6++;
        Console.WriteLine(@$"{count6} Blog: {blog.Name}");
    }
Console.WriteLine("====================== NUMBER 6 END ======================");

Console.WriteLine("====================== NUMBER 7 BEGIN ======================");

// 7. Test AddBlog
//    Create a new Blog object with Name = "New Blog" and UserId = 1.
//    Call AddBlog method on dbService with the new Blog object.
//    Again, call GetAllBlogs and print the count of blogs. It should be 6.

    Blog newBlog = new Blog {
        Name = "New Blog",
        UserId = 1
    };
    await _dbservice.AddBlog(newBlog);
    Console.WriteLine(newBlog.Name);
    var getBlogs = await _dbservice.GetAllBlogs();
    var count7 = 0;
    foreach(Blog? blog in getBlogs){
        count7++;
        Console.WriteLine(count7);
    }


Console.WriteLine("====================== NUMBER 7 END ======================");

Console.WriteLine("====================== NUMBER 8 BEGIN ======================");

// 8. Test UpdateBlog
//    Update the Name of the new Blog object to "Updated Blog".
//    Call UpdateBlog method on dbService with the updated Blog object.
//    Query the updated Blog from the database and print its name. It should be "Updated Blog".
    await _dbservice.UpdateBlog(6, "Updated Blog");
    await _dbservice.GetAllBlogs();

Console.WriteLine("====================== NUMBER 8 END ======================");

Console.WriteLine("====================== NUMBER 9 BEGIN ======================");

// 9. Test DeleteBlog
//    Call DeleteBlog method on dbService with the id of the new Blog.
//    Again, call GetAllBlogs and print the count of blogs. It should be 5.

    await _dbservice.DeleteBlog(7);
    var allTheBlogs = await _dbservice.GetAllBlogs();
    var count9 = 0;
    foreach(Blog? blog in allTheBlogs){
        count9++;
        Console.WriteLine(count9);
    }
    
Console.WriteLine("====================== NUMBER 9 END ======================");

Console.WriteLine("====================== NUMBER 10 BEGIN ======================");

// 10. Test GetAllPosts
//    Call GetAllPosts method on dbService and print the count of posts. It should be 5.
    var allPosts = await _dbservice.GetAllPosts();
    var count10 = 0;
    foreach(Post? post in allPosts){
        count10++;
        Console.WriteLine(@$"{count10} Post: {post.Id}");
    }
Console.WriteLine("====================== NUMBER 10 END ======================");

Console.WriteLine("====================== NUMBER 11 BEGIN ======================");

// 11. Test AddPost
//    Create a new Post object with Title = "New Post", Content = "This is a new post", BlogId = 1.
//    Call AddPost method on dbService with the new Post object.
//    Again, call GetAllPosts and print the count of posts. It should be 6.

    Post newPost = new Post{
        Title = "New Post",
        Content = "This is a new post",
        BlogId = 1
    };
    await _dbservice.AddPost(newPost);
    var getAllPosts = await _dbservice.GetAllPosts();
    var count11 = 0;
    foreach(Post? post in getAllPosts){
        count11++;
        System.Console.WriteLine(count11);
    }
Console.WriteLine("====================== NUMBER 11 END ======================");

Console.WriteLine("====================== NUMBER 12 BEGIN ======================");

// 12. Test UpdatePost
//    Update the Title of the new Post object to "Updated Post".
//    Call UpdatePost method on dbService with the updated Post object.
//    Query the updated Post from the database and print its title. It should be "Updated Post".

    await _dbservice.UpdatePost(6, "Updated Post");
    Console.WriteLine(newPost.Title);
Console.WriteLine("====================== NUMBER 12 END ======================");

Console.WriteLine("====================== NUMBER 13 BEGIN ======================");

// 13. Test DeletePost
//    Call DeletePost method on dbService with the id of the new Post.
//    Again, call GetAllPosts and print the count of posts. It should be 5.
    
    await _dbservice.DeletePost(9);
    var allThePosts = await _dbservice.GetAllPosts();
    var count13 = 0;
    foreach(Post? posts in allThePosts){
        count13++;
        Console.WriteLine(count13);
    }
Console.WriteLine("====================== NUMBER 13 END ======================");