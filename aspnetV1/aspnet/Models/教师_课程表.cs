namespace aspnet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 教师_课程表
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int 课程编号 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string 教师工号 { get; set; }

        [StringLength(100)]
        public string 所在教室 { get; set; }

        [StringLength(100)]
        public string obligate1 { get; set; }

        [StringLength(100)]
        public string obligate2 { get; set; }

        [StringLength(100)]
        public string obligate3 { get; set; }

        [StringLength(100)]
        public string obligate4 { get; set; }

        [StringLength(100)]
        public string obligate5 { get; set; }

        [StringLength(100)]
        public string obligate6 { get; set; }

        [StringLength(100)]
        public string obligate7 { get; set; }

        [StringLength(100)]
        public string obligate8 { get; set; }

        [StringLength(100)]
        public string obligate9 { get; set; }

        [StringLength(100)]
        public string obligate10 { get; set; }

        public virtual 课程表 课程表 { get; set; }

        public virtual 教师表 教师表 { get; set; }
    }
}
