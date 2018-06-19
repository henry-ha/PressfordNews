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
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Interfaces;

public class PressfordNewsContext : BaseContext
{
    public PressfordNewsContext(IUser user) : base("PressfordNewsContext")
    {
        Userinfo = user;
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ArticleComment>()
                .HasKey(c => new { c.ArticleId, c.Id });

        modelBuilder.Entity<ArticleLikes>()
                .HasKey(c => new { c.ArticleId, c.Id });

        base.OnModelCreating(modelBuilder);
    }
}
