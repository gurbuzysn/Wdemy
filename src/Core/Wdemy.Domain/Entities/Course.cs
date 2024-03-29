﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Domain.Common.Base;
using Wdemy.Domain.Enums;

namespace Wdemy.Domain.Entities
{
    public class Course : AuditableEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int StudentCount { get; set; }
        public int TotalParts { get; set; }
        public int TotalLesson { get; set; }
        public TimeSpan TotalDuration { get; set; }
        public Guid TrainerId { get; set; }

        public virtual Trainer Trainer { get; set; } = null!;
        public virtual ICollection<Section> Sections { get; set; } = new HashSet<Section>();
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
