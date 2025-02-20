using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories;

public class CategoryRepository : Repository<Category>
{

    public readonly SqlConnection _connection;

    public CategoryRepository(SqlConnection connection) : base(connection)
    {
        _connection = connection;
    }

    public List<Category> GetCategoryWhitPost()
    {
        
        var query = @"
            SELECT
                [Category].[Id],
                [Category].[Title],
                [Post].[Id],
                [Post].[Title]
            FROM 
                [Category]
                LEFT JOIN [Post] ON [Post].[CategoryId] = [Category].[Id]
            ORDER BY
                [Category].[Id],
                [Category].[Title],
                [Post].[Id],
                [Post].[Title]";
        
        var categories = new List<Category>();
        var posts = _connection.Query<Category, Post, Category>(query, (category, post) =>
        {
            var ctg = categories.FirstOrDefault(x => x.Id == category.Id);
            if (ctg == null)
            {
                ctg = category;
                if (post != null)
                    ctg.Posts.Add(post);
                categories.Add(ctg);
            }
            else
            {
               ctg.Posts.Add(post);
            }

            return category;
        }, splitOn: "Id");
        return categories;

    }

}