using System;

namespace Gymsystem_Api.Models;

public class Member
{
    public Guid id { get; set; }
    public string name { get; set; }
    public DateTime RegisterDate { get; set; }
    public int SubPeriod { get; set; }
    public string SubType { get; set; }
}
