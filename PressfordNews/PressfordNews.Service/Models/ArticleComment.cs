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

[Table("PN_ARTICLE_COMMENT")]
public class ArticleComment : BaseEntity<int>
{
    public override int Id { get; set; }

    public int ArticleId { get; set; }
    public string Comment { get; set; }    
    public DateTime? CreateDateUTC { get; set; }
    public DateTime? UpdateDateUTC { get; set; }
}
