using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryThreads.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public string Prefix { get; set; }
        public string FirstNames { get; set; }
        public string MiddleNames { get; set; }
        public string Surname { get; set; }
        public string Suffix { get; set; }
        public string Degrees { get; set; }
        public string Title { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string MetricHeight { get; set; }
        public string MetricWeight { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Complextion { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
