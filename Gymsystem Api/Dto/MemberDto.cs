using System.ComponentModel.DataAnnotations;

namespace Gymsystem_Api.Dto;

public record class MemberDto
(
    [Required]Guid id,
    [Required][StringLength(20)] string name,
    [Required]DateTime RegisterDate,
    [Required][Range(30,366)]int subscribtionPeriod,
    [Required]string Subscribtiontype
);
