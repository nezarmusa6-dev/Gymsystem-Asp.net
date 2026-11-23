using System;
using Gymsystem_Api.Models;

namespace Gymsystem_Api.Endpoints;

public static class MemberEndpoint
{
    //List
    private static readonly List<Member> members = new()
        {
            new Member
            {
                id = Guid.NewGuid(),
                name = "John Doe",
                SubDate = DateOnly.FromDateTime(DateTime.UtcNow),
                SubPeriod = 30,
                SubType = "Monthly"
            },
            new Member
            {
                id = Guid.NewGuid(),
                name = "Jane Smith",
                SubDate = DateOnly.FromDateTime(DateTime.UtcNow),
                SubPeriod = 90,
                SubType = "Quarterly"
            }
        };
        
    public static void MapMemberEndpint(this WebApplication app)
    { 

        var group = app.MapGroup("/Members");
        group.MapGet("/", () => Results.Ok(members));

        group.MapGet("/{id}", (Guid id) => members.Find(m => m.id == id));
     
    }
}
