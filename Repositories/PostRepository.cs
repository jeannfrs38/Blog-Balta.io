using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories;

public class PostRepository : Repository<Post>
{
    public readonly SqlConnection _connection;

    public PostRepository(SqlConnection connection) : base(connection)
    {
        _connection = connection;
    }

    public  IEnumerable<Post> GetPostWithCategory()
    {
        
        var sql = @"SELECT 
                        *
                    FROM
                        [Post]
                        INNER JOIN [Category] ON [Post].[CategoryId] = [Category].[Id]";

        var posts = _connection.Query<Post, Category, Post>(sql,
            (post, category) =>
            {
                post.Category = category;
                return post;
            }, splitOn:"Id");
        return posts;
    }

    public List<Post> GetPostsWithTags()
    {
        var sql = @"SELECT
                        [Post].*,
                        [Tag].*
    
                    FROM 
                        [Post]
                        LEFT JOIN [PostTag] ON [PostTag].[PostId] = [Post].[Id]
                        LEFT JOIN [Tag] ON [PostTag].[TagId] = [Tag].[Id]";

        var posts = new List<Post>();
        var items = _connection.Query<Post, Tag, Post>(sql, (post, tag) =>
        {
            var pst = posts.FirstOrDefault(x => x.Id == post.Id);
            if (pst == null)
            {
                pst = post;
                if (tag != null)
                    post.Tags.Add(tag);
                posts.Add(pst);
            }
            else
            {
                post.Tags.Add(tag);
            }

            return post;
        }, splitOn: "Id");
        return posts;
    }
}