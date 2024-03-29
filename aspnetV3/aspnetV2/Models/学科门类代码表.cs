namespace aspnetV2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 学科门类代码表
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 学科门类代码表()
        {
            专业代码表 = new HashSet<专业代码表>();
        }

        [Key]
        [StringLength(50)]
        public string 学科门类代码 { get; set; }

        [Required]
        [StringLength(50)]
        public string 学科门类 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<专业代码表> 专业代码表 { get; set; }
    }
}
