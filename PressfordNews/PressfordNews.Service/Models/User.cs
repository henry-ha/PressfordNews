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

[Table("PN_USER")]
public class User : BaseEntity<int>
{
    public int Id { get; set; }

    [StringLength(100)]
    public string UserName { get; set; }
    public bool IsPublisher { get; set; }
    
    public DateTime? CreateDateUTC { get; set; }
    public DateTime? UpdateDateUTC { get; set; }

    public List<Article> Articles { get; set; }
}
