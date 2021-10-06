# TDD-Stack

Implementation of a simple Stack to learn TDD using C#.
The testing framework that will be used is MSTest.

# Stack Behavior

- Pop: An item can be popped off the stack.
- Last In First Out (LIFO) Stack.
- An empty stack doesn’t cause failure (throwing an exception).
- Null values cannot be pushed into the stack.

## Prerequisites

| **Programming Language** | **Testing Framework** | **Code editor**    | **Runtime** |
| ------------------------ | --------------------- | ------------------ | ----------- |
| C#                       | MSTest                | Visual Studio Code | .NET Core   |

## Creating The Project From Scratch

- Go to the directory where you want your project to be and run:

`dotnet new sln -o TDD-GenericStack`

- Go to that newly created directory

`cd TDD-GenericStack`

- Create a new class lib:

`dotnet new classlib -o GenericStack.Library`

**NOTE:** The dotnet new classlib command creates a new class library project in the GenericStack.Library folder. The new class library will contain the code to be tested.

- Rename the file Class1.cs to GenericStackService.cs

`mv ./GenericStack.Library/Class1.cs ./GenericStack.Library/GenericStackService.cs`

- Run the following command to add the class library project to the solution:

`dotnet sln add ./GenericStack.Library/GenericStack.Library.csproj`

- Create the GenericStack.Tests project by running the following command:

`dotnet new mstest -o GenericStack.Tests`

- Rename the file UnitTest1.cs to GenericStackTests.cs

`mv ./GenericStack.Tests/UnitTest1.cs ./GenericStack.Tests/GenericStackTests.cs`

- Add the test project to the solution file by running the following command:

`dotnet sln add ./GenericStack.Tests/GenericStack.Tests.csproj`

- Add the GenericStackService class library as a dependency to the GenericStack.Tests project:

`dotnet add ./GenericStack.Tests/GenericStack.Tests.csproj reference ./GenericStack.Library/GenericStack.Library.csproj`

## Running the tests

- To run the tests, we will use a tool called dotnetWatcher. In order for it to work properly run:

`dotnet watch -p ./Stack.Tests/ test`

**NOTE:** The dotnet Watcher allows us to watch our code and rerun all our tests anytime a code file is changed and saved.
