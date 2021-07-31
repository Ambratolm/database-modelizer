# ![Icon](./icon.png) Database Modelizer (C#)

[![C# 4.0](https://img.shields.io/badge/C%23-4.0-blue?logo=c-sharp)](https://github.com/topics/csharp)
[![.NET Framework 4.0](https://img.shields.io/badge/.NET%20Framework-4.0-blue?logo=dot-net)](https://github.com/topics/dotnet)

Simple object–relational mapping (**ORM**) library for **C# .NET**.

It helps creating **model classes** to represent the **tables** of a **relational database** and access them through **objects** and **generic collections** to perform **CRUD operations** without having to write **queries** or dealing with table **rows** and **columns** names.

## 📝 How to use ?

1. Add `DatabaseModelizer.dll` to project references.

2. Add the namespace `DatabaseModelizer`:

```csharp
using DatabaseModelizer;
```

3. Create a new `DataAccessor` object using a connection string and choose a provider (Ex: Sql, OleDb, Odbc, ...etc):

```csharp
DataAccessor dataAccessor = new DataAccessor("connection-string-here", DataProvider.Sql);
```

4. Now, let's say you have a **sql database** with the following **table**:

👤 **persons** (🔑 **id**, full_name, gender, birth_date)

Create a new `Person` model class for this table as follow:

```csharp
class Person : Model
{
    [Column("id")]
    public object Id { get; set; }

    [Column("full_name")]
    [System.ComponentModel.DisplayName("Full Name")]
    public object Name { get; set; }

    [Column("gender")]
    public object Gender { get; set; }

    [Column("birth_date")]
    [System.ComponentModel.DisplayName("Birth Date")]
    public object BirthDate { get; set; }
}
```

As you see, you must derive from `Model` class and use the `ColumnAttribute` to specify the database table column that the class property must map to. You can also take this chance to set the .NET `DisplayNameAttribute` to give the field a name that will be showed when it is used in a control like `DataGridView`.

5. Create a generic `ModelTable` object for the created `Person` Type:

```csharp
ModelTable<Person> persons = new ModelTable<Person>("persons", dataAccessor);
```

The created `persons` object represents the `👤 persons` table in database and can be used to query the table.

6. User `persons` object to perform the CRUD operations:

a. Create:

```csharp
Person newPerson = new Person()
{
    Id = Guid.NewGuid(),
    Name = "Nina",
    Gender = "F",
    BirthDate = DateTime.Now
};
Database.Persons.Create(newPerson);
```

b. Read:

```csharp
List<Person> allPersons = Database.Persons.Read();
List<Person> personsNamedNina = Database.Persons.Read(p => p.Name == "Nina");
Person nina = personsNamedNina[0];
```

b. Update:

```csharp
nina.Name = "Maria";
Database.Persons.Update(nina, p => p.Id == nina.Id);
```

b. Delete:

```csharp
Database.Persons.Delete(p => p.Id == nina.Id);
```

_**PS:**_ Check the included **`Sample Client`** example project.

## 🚀 Development

- Language: **[C#](https://github.com/dotnet/csharplang) 4.0**
- Framework: **[.NET](https://github.com/dotnet) Framework 4.0** / **[WinForms](https://github.com/dotnet/winforms)**
- IDE: **[Visual Studio](https://github.com/microsoft) 2010**

## 📄 License

Licensed under [MIT](./LICENSE).
