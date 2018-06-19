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

[Table("PN_ARTICLE_LIKE")]
public class ArticleLikes : BaseEntity<int>
{
    public override int Id { get; set; }

    public int ArticleId { get; set; }
    public int UserID { get; set; }
    public int Count { get; set; }
}
