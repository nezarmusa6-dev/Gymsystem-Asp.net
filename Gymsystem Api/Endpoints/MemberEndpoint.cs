using System;
using Gymsystem_Api.Dto;
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
                RegisterDate = DateTime.UtcNow,
                SubPeriod = 30,
                SubType = "Monthly"
            },
            new Member
            {
                id = Guid.NewGuid(),
                name = "Jane Smith",
                RegisterDate = DateTime.UtcNow,
                SubPeriod = 90,
                SubType = "Quarterly"
            }
        };
        
    public static void MapMemberEndpint(this WebApplication app)
    { 

        var group = app.MapGroup("/Members");
        group.MapGet("/", () => 
        members.Select(members => new MemberDto(
            members.id,
            members.name,
            members.RegisterDate,
            members.SubPeriod,
            members.SubType
        )));

        group.MapGet("/{id}", (Guid id) => members.Find(m => m.id == id));
     
    }
}
