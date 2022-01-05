using System;
using System.Collections.Generic;

namespace Coursework2Comp2001.Models
{
    public partial class Project
    {
        public int? StudentId { get; set; }
        public int ProjectNo { get; set; }
        public string ProjectTitle { get; set; } = null!;
        public string ProjectDescriprion { get; set; } = null!;
        public int ProjectYear { get; set; }
        public byte[]? ThumbnailImageFile { get; set; }
        public byte[]? PosterImageFile { get; set; }

        public virtual Student? Student { get; set; }
    }
}
