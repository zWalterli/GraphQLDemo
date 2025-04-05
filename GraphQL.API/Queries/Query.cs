using GraphQL.Infra;
using GraphQL.Infra.Models;

namespace GraphQL.API.Queries;
public class Query
{
    public IQueryable<TaskItem> GetTasks(
    [Service] AppDbContext context,
    int? id,
    string title,
    string description)
    {
        var query = context.Tasks.AsQueryable();

        if (id.HasValue)
        {
            query = query.Where(t => t.Id == id.Value);
        }

        if (!string.IsNullOrEmpty(title))
        {
            query = query.Where(t => t.Title.ToLower().Contains(title.ToLower()));
        }

        if (!string.IsNullOrEmpty(description))
        {
            query = query.Where(t => t.Description.ToLower().Contains(description.ToLower()));
        }

        return query;
    }
}
