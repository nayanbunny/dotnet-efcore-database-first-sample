using System;
using System.Collections.Generic;

namespace DotNet.EFCore.DBFirst.Sample.WebApp.Models
{
    public partial class EmployeeSkill
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid SkillId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual Skill Skill { get; set; } = null!;
    }
}
