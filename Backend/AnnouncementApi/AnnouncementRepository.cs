using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Threading.Tasks;
public class AnnouncementRepository : BaseRepository, IRepository<Announcement>
{

    public AnnouncementRepository(IConfiguration configuration) : base(configuration) { }

    public async Task<IEnumerable<Announcement>> GetAll()
    {
        using var connection = CreateConnection();
        return await connection.QueryAsync<Announcement>("SELECT * FROM Announcements;");

    }

    public void Delete(long id)
    {
        using var connection = CreateConnection();
        connection.Execute("DELETE FROM Announcements WHERE Id = @Id;", new { Id = id });
    }

    public async Task<Announcement> Get(long id)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Announcement>("SELECT * FROM Announcements WHERE Id = @Id;", new { Id = id });
    }

    public async Task<Announcement> Update(Announcement Announcement)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Announcement>("UPDATE Announcements SET Date = @Date, Title = @Title, Description = @Description, Industry = @Industry WHERE Id = @Id RETURNING *", Announcement);
    }

    public async Task<Announcement> Insert(Announcement Announcement)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Announcement>("INSERT INTO Announcements (Date, Title, Description, Industry) VALUES (@Date, @Title, @Description, @Industry) RETURNING *;", Announcement);
    }

    public async Task<IEnumerable<Announcement>> Search(string query)
    {
        using var connection = CreateConnection();
        return await connection.QueryAsync<Announcement>("SELECT * FROM Announcements WHERE Date ILIKE @Query OR Title ILIKE @Query OR Description ILIKE @Query OR Industry ILIKE @Query;", new { Query = $"%{query}%" });

    }


}



