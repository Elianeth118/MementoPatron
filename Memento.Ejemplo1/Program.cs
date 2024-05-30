// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Memento.Ejemplo1;

Repository repo= new Repository();
Git git= new Git();
repo.Code = "Initial code";
git.Commit(repo);

Console.WriteLine(repo.Code);

repo.Code = "Code after first change";
git.Commit(repo);

Console.WriteLine(repo.Code);

repo.Code = "Code after second change";
git.Commit(repo);

Console.WriteLine(repo.Code);

git.Revert(repo);
Console.WriteLine(repo.Code);