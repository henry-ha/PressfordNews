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
using System.Data.Entity;
using Interfaces;

public abstract class BaseContext : DbContext
{
    public BaseContext()
    {
        Database.SetInitializer<PressfordNewsContext>(null);
    }

    protected BaseContext(string connString)
    {
        this.Userinfo.ConnectionString = connString;
    }


    public IUser Userinfo;
    private string v;


    //public DbSet<Log.Activity> Activities { get; set; }

    public DbSet<Article> Articles { get; set; }
    public DbSet<ArticleComment> ArticleComments { get; set; }
    public DbSet<ArticleLikes> ArticleLikes { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EventCustomFields>()
            .HasKey(c => new { c.EventId, c.CustomFieldId });

        modelBuilder.Entity<Contact>().HasMany(p => p.Segments).WithMany(t => t.Contacts).Map(mc =>
        {
            mc.ToTable("PIT_CONTACT_ANALYSIS");
            mc.MapLeftKey("ContactId");
            mc.MapRightKey("AnalysisDetailId");
        });

        modelBuilder.Configurations.Add(new ActivityVideoMap());
    }

    //public override int SaveChanges()
    //{
    //    int currentUserId = Userinfo.CurrentUser.UserID;

    //    var addedAuditedEntities = ChangeTracker.Entries<IAuditable>().Where(item => item.State == EntityState.Added);
    //    foreach (var dbEntry in addedAuditedEntities)
    //    {
    //        Log.Activity entity = dbEntry.Entity.GetCreateActivity();
    //        entity.UserId = currentUserId;
    //        Activities.Add(entity);
    //    }

    //    var modifiedAuditedEntities = ChangeTracker.Entries<IAuditable>().Where(item => item.State == EntityState.Modified);
    //    foreach (var dbEntry in modifiedAuditedEntities)
    //    {
    //        Log.Activity entity = dbEntry.Entity.GetUpdateActivity();
    //        entity.UserId = currentUserId;
    //        Activities.Add(entity);
    //    }

    //    var deletedAuditedEntities = ChangeTracker.Entries<IAuditable>().Where(item => item.State == EntityState.Deleted);
    //    foreach (var dbEntry in deletedAuditedEntities)
    //    {
    //        Log.Activity entity = dbEntry.Entity.GetDeleteActivity();
    //        entity.UserId = currentUserId;
    //        Activities.Add(entity);
    //    }


    //    Entities.User user = Users.Single(item => item.Id == Userinfo.CurrentUser.UserID);
    //    return _logger.SaveChanges(user);
    //}
}
