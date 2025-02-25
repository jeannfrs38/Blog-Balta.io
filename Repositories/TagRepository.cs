using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories;

public class TagRepository : Repository<Tag>
{
    public readonly SqlConnection _connection;

    public TagRepository(SqlConnection connection) : base(connection)
    {
        _connection = connection;
    }

    public List<Tag> GetTagsWithPosts()
    {
        var sql = @"SELECT
                        [Tag].*,
                        [Post].*
                    FROM 
                        [Tag]
                        LEFT JOIN [PostTag] ON [PostTag].[TagId] = [Tag].[Id]
                        LEFT JOIN [Post] ON [PostTag].[PostId] = [Post].[Id]";

        var tags = new List<Tag>();
        var items = _connection.Query<Tag, Post, Tag>(sql, (tag, post) =>
        {
            var tg = tags.FirstOrDefault(x => x.Id == tag.Id);
            if (tg == null)
            {
                tg = tag;
                if (post != null)
                    tag.Posts.Add(post); 
                tags.Add(tag);
            }
            else
            {
                tag.Posts.Add(post);
            }

            return tag;
        }, splitOn: "Id");
        return tags;
    }
}