# C# Commands with UNIX style

## Commands implemented:

- `cat`- Reads all text in file
- `cp` - Copy a file
- `echo` -
- `ls` - List file
- `mv` - Move file
- `pwd` - Prints current directory
- `rm` - Delete file
- `touch` - Create a file
- `wc` - Counts lines, words and bytes in file

_This task is a group oriented project where each of us creates a branch and commits to main._
_Our task is to create functional UNIX style commands in C#._

**Stages:**

1. Create a repository containing the main features using `dotnet new console --use-program-main`
2. Invite members in repo, pull code to VSC and create branches using `git branch username` and `git checkout username`
3. Each member creates files with end name `Command.cs` under `Classes/Controllers`.
4. We then create a `switch/case` statement with the methods from `Controllers` in `Program.cs`.
5. Wrap them in a `while` loop so that we can continously type commands till user types `exit` in terminal.
