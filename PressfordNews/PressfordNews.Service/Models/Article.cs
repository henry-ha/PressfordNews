using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("PN_ARTICLE")]
public class Article : BaseEntity<int>
{
    [Key]
    public override int Id { get; set; }

    [StringLength(255)]
    public string Title { get; set; }
    public string Body { get; set; }
    public DateTime? CreateDateUTC { get; set; }
    public DateTime? UpdateDateUTC { get; set; }
    public DateTime? PublishDateUTC { get; set; }
    public DateTime? ArchiveDateUTC { get; set; }
    public User User { get; set; }
    public List<ArticleComment> Comments { get; set; }
    public List<ArticleLikes> Likes { get; set; }
    public int LikeCount { get; set; }
}
