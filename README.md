# invoice-generator
A desktop application for generating invoices for a given set of clients

## Note

A SQL Connection string is required. At the time of committing (17 May, 2022), the connection string should be hard coded. To ensure security of the database is upheld, the connection string has been removed from source control. In later versions, it will be supplied via an appsettings.json entry.

For now, you will need to open the InvoiceDBContext and add a connection string to the following line:

```csharp
optionsBuilder.UseSqlServer(@"CONNECTION_STRING_HERE");
```

Without this connection string, the application will not connect to the database.

### DB Access

If you receive an exception when connecting to the database relating to not having access, please send your IP address (google "what's my IP") to Jamie, and he will add it to the IP allow list for the SQL Server.
