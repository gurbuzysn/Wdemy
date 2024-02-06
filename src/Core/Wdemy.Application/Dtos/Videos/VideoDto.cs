using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wdemy.Application.Dtos.Videos
{
    public class VideoDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string DocumentUri { get; set; } = null!;
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public byte[] VideoData { get; set; } = null!;
        public TimeSpan Duration { get; set; }
        public Guid SectionId { get; set; }
    }
}
