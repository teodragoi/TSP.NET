namespace Lab4
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelSelfReference : DbContext
    {
        // Your context has been configured to use a 'ModelSelfReference' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Lab4.ModelSelfReference' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelSelfReference' 
        // connection string in the application configuration file.
        public ModelSelfReference()
            : base("name=ModelSelfReference")
        {
        }

        public virtual DbSet<SelfReference> SelfReferences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SelfReference>()
                .HasMany(m => m.References)
                .WithOptional(m => m.ParentSelfReference);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}