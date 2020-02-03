# ASP .NET Core Sample App

1. create new new web app project using the commmand

```powershell
dotnet new webapp <name-of-the-app>
```

2. Inside the Pages directory

-   .cshtml file that contains HTML markup with C# code using Razor syntax.
-   .cshtml.cs file that contains C# code that handles page events.

3. Add a data model

-   Under /Models, create a Model class, which will represent the database table structure

```csharp
using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public enum Category
    {
        Transportation, Entertainment, Meal
    }

    public class Record
    {
        public int recordID { get; set; }
        public string recordName { get; set; }
        public string description { get; set; }
        [EnumDataType(typeof(Category))]
        public Category category { get; set; }

        [DataType(DataType.Date)]
        public DateTime addedDate { get; set; }
        public double amount { get; set; }
    }
}
```

-   Create a database context class, which create the link between the database and the web app

```csharp
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Data
{
    public class RecordContext : DbContext
    {
        public RecordContext(
            DbContextOptions<RecordContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Record> Record { get; set; }
    }
}
```

-   Add the database context class to the ConfigurationService method

```csharp
if (Environment.IsDevelopment())
{
    services.AddDbContext<RecordContext>(options =>
        options.UseSqlite(Configuration.GetConnectionString("RecordContext")));
}
else
{
    services.AddDbContext<RecordContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("RecordContext")));
}
```

5. Database Migration

-   Create Migration File

```powershell
dotnet ef migration add <name-of-the-migration>
```

-   Migration

```powershell
dotenet ef database update
```
