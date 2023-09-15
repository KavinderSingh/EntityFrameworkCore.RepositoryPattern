EntityFrameworkCore.RepositoryPattern

It is a simple implementation of repository pattern for .NET. It Contains a base repository class with general methods based on EntityFrameworkCore. In order to use it you need to register it as a service in your entry point file (program.cs in .NET 6). The class expects:
1. DbContext (or its inherited classes) as a argument to its constructor to create a context.
2. Entity class as a type argument.