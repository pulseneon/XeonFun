using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XeonFun.Models
{
    public class Assembling
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Desk { get; set; }
        public string PhotoPath { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Motherboad { get; set; }
        [Url]
        public string MotherboardLink { get; set; }
        [Required]
        public string Processor { get; set; }
        [Url]
        public string ProcessorLink { get; set; }
        [Required]
        public string Videocard { get; set; }
        [Url]
        public string VideocardLink { get; set; }
        public string Cooler { get; set; }
        [RegularExpression(@"(\d[x]\d+\s\w+)")]
        public string RAM { get; set; }
        [RegularExpression(@"(\d+ .+)")]
        public string ROM { get; set; }
    }
}
