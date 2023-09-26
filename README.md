EntityFrameworkCore.RepositoryPattern

It is a simple implementation of repository pattern for .NET. It Contains a base repository class with general methods based on EntityFrameworkCore. In order to use it you need to register it as a service in your entry point file (program.cs in .NET 6).
![image](https://github.com/KavinderSingh/EntityFrameworkCore.RepositoryPattern/assets/51209505/5a8dfb9f-e1a8-4227-8495-245ca5c47177)

The class expects:
1. DbContext (or its inherited classes) as a argument to its constructor to create a context.
2. Entity class as a type argument.
   
![image](https://github.com/KavinderSingh/EntityFrameworkCore.RepositoryPattern/assets/51209505/d11d48b2-2d50-482c-9185-a644af2f0662)
