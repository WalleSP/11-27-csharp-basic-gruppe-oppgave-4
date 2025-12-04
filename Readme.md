# C# Commands with UNIX style

## Usage:

1. Type `dotnet run` to run code.
2. A table of available commands will be displayed in terminal.
3. Type `exit` to quit the program.
4. Enjoy!

## Commands implemented with arguments:

- `cat`- Reads all text in file
- `cp` - Copy a file (-r)
- `echo` - Prints your text in terminal (>, >>)
- `help` - Gives a table of commands
- `ls` - List file (-l)
- `mkdir` - Create new directory
- `mv` - Move file
- `pwd` - Prints current directory
- `rm` - Delete file (-r)
- `head` - Display first 10 lines of file
- `tail` - Displays last 10 lines of file
- `touch` - Create a file
- `wc` - Counts lines, words and bytes in file
- `cd`- Change current directory to the one specified

_This task is a group oriented project where each of us creates a branch and commits to main._
_Our task is to create functional UNIX style commands in C#._

## Our team:

- https://github.com/hro1025
- https://github.com/WalleSP
- https://github.com/Henning-1025
- https://github.com/Maxkodehode

**Stages:**

1. Created a new C# console project: `dotnet new console --use-program-main`.
2. Invited members in repo, cloned the project and created branches using `git branch username` and `git checkout username`.
3. Each member created files with end name `Command.cs` under `Classes/Controllers`.
4. In `Program.cs`, we wrote a `switch` statement that reads the user’s input and decides which command to run by calling the correct method from each command class.
5. Wrap them in a `while` loop so that we can continously type commands until user types `exit` in terminal.
6. Using `Spectre.Console`, we create a table that displays the different commands to the user.
