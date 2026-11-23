namespace Gymsystem_Api.Dto;
 using System.ComponentModel.DataAnnotations;

public record class CreateMemberDto
(
    [Required][StringLength(20)] string name,
    [Required] DateTime RegisterDate,
    [Required][Range(30, 366)] int subscribtionPeriod,
    [Required] string Subscribtiontype
);
