# Notes

This README file is going to contain everything I learned while on my placement with RJJ Software

## Git and gitflow

Git is a source control system. It allows us to track all changes to a given code automatically.

[Atlassian - Learn Git](https://www.atlassian.com/git)

Basic overview of how Git works:

1. Create a repository (project) with a git hosting tool (GitHub)
1. Copy/clone the repository to your local machine
1. Add a file to your local repo and "commit" save the changes
1. Push the changes to your main branch
1. Make a change to your file with a git hosting tool and commit
1. "Pull" the changes to your local machine
1. Create a "branch" (version), make a change, commit the change
1. Open a "pull" request (propose the changes to the main branch)
1. Merge your branch to the main branch

List above explained further:

The basic idea is that when we create a git repo, there is a main branch. This represents the current state of play for the code within the code base. When we want to make a change to the code base, we create a branch - this is a copy of the code up to that point - and work on it until we have completed the work.

Changes made to the code base are committed into the branch, this ensures that related changes are saved into source control at the same time. Each commit requires a commmit message, and this should be a helpful description of what the changes are and how they effect the code base.

When the work is completed and has passed any QA or test requirements, the branch is then merged back into the main branch.

Merging is the process of taking the changes in one branch and applying them onto another branch. Git will take care of the majority of the changes, figuring out where to insert your new code and which code changes take precedent.

Sometimes you will get a merge conflict. This is when git can't automatically merge the changes from one branch into another. At this point, you need to intervene and tell git which changes need to be copied over and which changes need to be dropped.

Gitflow is a way of managing many different branches for developing applications and systems.

[Atlassian - Learn Gitflow](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow)

In a gitflow project, there is usually a main or trunk branch. The main branch represents the version of the application the client has access to. There is also a branch called develop, dev or development and is taken as a branch from the main branch. The development branch is where all active development happens; this helps to stop changes happening to the main branch.

When work on a work item begins, a feature branch is taken from the development branch. All work on the work item happens in the feature branch and when it passes QA/Testing, it is merged back into development. After the changes have been accepted into the development branch, the feature branch is deleted.

At certain points during development of the application (usually around the end of each sprint), the changes in the development branch are merged back into the main branch. The main branch is then tagged with a version number.

Tagging the main branch at certain points helps us to build and deliver specific versions of the application.

Sometimes we need to make a fix to the code in the main branch. We do this by creating a hotfix branch. This branch contains all of the fixes required to fix the identified issue, and is merged back into the main branch once it passes QA/Testing.

The point of gitflow is that the code in the main branch is only ever updated when a merge into it happens. This means that no one on the development team can merge changes into it. This protects the code base from any accidental damages to the main branch.

Branches are merged into other branches using Pull Requests. A Pull Request (or PR) represents a request to the other developers on the team to pull your changes into a certain branch. PRs allow development teams to apply a level of code quality checks to the code base, and for individual developers to learn best practises from other members of the team.

PRs can be accepted with or without comments, or they can be denied. When a PR is accepted, the changes in the source branch are merged into the destination branch. When a PR is denied, the changes are not merged. Comments on a PR allow the reviewer to ask questions to and leave advice for the creator of the PR. The creator is then asked to either respond to the comments or make any requested changes.

### Forks

A fork is a copy of a repository that you manage. A fork lets you make changes to a project without affecting the original repository. You have the ability to fetch uodates from or submit changes to the original repository with pull requests.
Forking a repository is similar to copying a repository, with two major differences:

You can use a pull request to suggest changes from your user-owned fork to the original repository in its GitHub instance, also known as the upstream repository.
You can also bring changes from the upstream repository to your local fork by synchronising your fork with the upstream repository (original repository in its GitHub instance).

### Pull Requests

Pull Requests let you tell others about changes you've pushed to a branch in a repository on GitHub. Once a pull request is opened, you can discuss and review the potential changes with collaborators and add follow-up commits before your changes are merged into the base branch.
After you initialise a pull request, you will see a review page that shows a high-level overview of the changes between your branch, (the compare branch) and the repository's base branch. You can add a summary of the proposed changes, review the changes made by commits, add labels, milestones, add assignees and @mention individual contributors or teams.

Pull requests are created to propose and collaborate on changes to a repository. These changes are proposed in a branch, which ensures that the default branch only contains finished and approved work.

Once you've created a pull request, you can push commits from your topic branch to add them to your existing pull request. These commits will appear in chronological order within your pull request and the changes will be visible in the "Files changed" tab.
Other contributors can review your proposed changes, add review comments, contribute to the pull request discussion and add commits to the pull request.

### Commits

Similar to saving a file that's been edited, a commit records changes to one or more files in your branch. Git assigns each commit a unique ID, called a SHA or hash that identifies:
> The specific changes
> When the changes were made
> Who created the changes

When you make a commit, you must include a commit message that briefly describes the changes.

## Entity Framework

Entity framework core is a modern object-database mapper for .NET. It supports LINQ queries, change tracking, updates and schema migrations. Entity Framework core works with many database, including SQL Database (on-premises and Azure), SQLite, MySQL, PostgreSQL and Azure Cosmos DB.
Entity Framework is an open-source ORM framework for .NET applications supported by Microsoft. It enables developers to work with data using objects of domain specific classes without focusing on the underlying database tables and columns where this data is stored. With the Entity Framework, developers can work at a higher level of abstraction when they deal with data and can create and maintain data-oriented applications with less code compared with traditional applications.
Official Definition: "Entity Framework is an object-relational mapper (O/RM) that enables .NET developers to work with a database using .NET objects. It eliminates the need for most of the data-access code that developers usually need to write".

## ORM

Object Relational Mapping (ORM) is a technique (Design Pattern) of accessing a relational database from an object- oriented language. The most important reason to use an ORM is so that you can have rich, object oriented business model and still be able to store it and write effective queries quickly against a relational database.

## SQL Injections

[PortSwigger](https://portswigger.net/web-security/sql-injection)

> SQL Injection is a web security vulnerability that allows an attacker to interfere with the queries that an application makes to its database. It generally allows an attacker to view data that they are not normally able to retrieve. This may include data belonging to other users, or any other data that the application itself is able to access. In many cases, an attacker can modify or delete this data, causing persistent changes to the application's content. In some cases, an attacker can escalate an SQL injection attack to compromise the underlying server or other back-end infrastructure or perform a denial-of-service attack.

### SQL Injection Examples

- Retrieving hidden data, where you can modify an SQL query to return additional results.
- Subverting application logic, where you can change a query to interfere with the application's logic.
- UNION attacks, where you can retrieve data from different database tables.
- Examining the database, where you can extract information about the version and structure of the database.
- Blind SQL injection, where the results of a query you control are not returned in the application's responses.

### SQL Injection Preventions

Use parameterised queries rather than string concatenation within the query.

Example of code that is vulnerable:

```csharp
var query = "SELECT * FROM products WHERE category = '" + input + "'";

var statement = connection.createStatement();

var resultSet = statement.executeQuery(query);
```

The code above is vulnerable to SQL Injection because the user input is concatenated directly into the query. The code above can be written in a way that easily prevents the user input from interfering with the query structure.

Example of code that is less vulnerable:

```csharp
var statement = connection.prepareStatement("SELECT * FROM products WHERE category = ?");

statement.setString(1, input);

var resultSet = statement.executeQuery();
```

Parameterised queries can be used for any situation where untrusted input appears as data within the query including the WHERE clause and values in an INSERT and UPDATE statement. Parameterised queries cannot be used to handle untrusted input in other parts of the query such as Table or Column names or the ORDER BY clause.

## .NET MAUI

.NET Multi-platform App UI (.NET MAUI) is a cross-platform framework for creating native mobile and desktop apps with C# and XAML.
Using .NET MAUI, you can develop apps that can run on Android, IOS, macOS and Windows from a single shared code-base

## Cmder

- `cd c:\Source` - Puts you into the Source file
- `gh auth` - Authenticates the user so you don't have to constantly login
- `gh repo clone Adam-Wilcock/invoice-generator` - Pulls the repository from GitHub and puts it into your folder
- `git clone https://github.com/Adam-Wilcock/invoice-generator.git` - Does same as above line
- `cd invoice-generator` - Puts you into the invoice-generator folder
- `ls` - Shows all fines within folder except for the hidden ones
- `ls -lha` - Shows all files within folder including the hidden ones
- `mkdir src` - Makes a directory called src
- `rmdir src` - Removes a directory called src
- `rm -rf src` - Removes a directory called src
- `touch readme.md` - Creates a file (touch is an OS command for creating files)
- `git add .` - Adds all changes in the working directory to the staging area
- `git status` - Displays that state of the working directory and the staging area, lets you see which changes have been staged, which haven't and which files aren't being tracked by git
-  `git commit -m "Initial commit of code base"` - Commits the previously added changes to git with the message "initial commit of code base"
- `git config user.name "Adam Wilcock"` - Set name of committer to "Adam Wilcock"
- `git config user.email "username@domain.tld"` - Set email of committer to "username@domain.tld"
- `git push` - Used to upload local repository content to a remote repository
- `git reset -- hard` - Resets your commit to the last saved changes, throws away all your committed changes (Removes only uncommitted files)
- `git clean -fd` - Deletes any untracked (i.e. haven't been added with `git add`) files and directories
- `git reset --hard HEAD~1 - This will destroy the commit and undo your work (Only works if you have not pushed yet)

## Dependency Injection

When we create a new concrete class, we use the **new** keywork. With dependency injection, rather than relying on using the **new** keyword to create new concrete classes, we ask a Dependency Injection framework (.NET has one built in) to inject one for us. The bonus for using this is that we can create an **interface** (which is different to a user interface) and pass that around.
The beauty of using interfaces is that they don't tell the consumer (the UI is a consumer of the ClientService and the ClientService is a consumer of the InvoiceDBContext) how the thing it's calling works, just how to call it.
An example of this would be a power socket. If you look at the power socket that your laptop is plugged into. You don't need to know how the power comes out of that socket, just that by plugging in a power adaptor, you'll get power. That's Dependency Injection.

Using Dependency Injection within this project would allow us to inject the database context rather than creating a new one with the keywork **new**, you can swap it for something else and your app never needs to know.

If you were to invert the dependency, you could change the ICLientRepository without having to worry about changing the ClientService. This means that you can silently, and quickly make changes to whatever implements the IClientRepository without the ClientService needing to know.

It also means that you can inject a mocked version of the IClientRepository for testing purposes.

Let's say you wanted to create an automatic test which checks that the GetClients method returns not just a list of ClientViewModels, but that each of them are set to the correct values. You would create a temporary class which performs a certain way, inject it into the ClientService, then call the ClientService's GetClients method and check that it hasn't done anything weird to the data.

The above is a bit of a trivial example, just remember that GetClients isn't returning the actual Client Database models. It's returning a list of ClientViewModels based on the contents of the Client database models. What if someone came along and changed the FromDbModel to alter the string values before returning the ClientViewModel. You could run the app with every possible Client model from the database, but that could take minutes. Whereas an automatic test will take around 50ms and will tell you instantly if something isn't right.

For further explanation, you could imagine Dependency Injection in a games context:
If you are building a cross platform game, you don't want to have code which reads an Xbox Series X controller and separate code which reads a PS5 controller - mainly because most of the buttons are the same. So, you could come up with an IController interface which exposes each of the buttons, then two classes which implement that interface PS5 controller and Xbox Series X Controller.

```csharp
public interface IController
{
  Jump();
  Melee();
  Reload();
  SwitchWeapon();
}

public class PS5Controller :  IController
{
  public void Jump()
  {
    // When the user presses X
  }
}

public class XboxSeriesXController :  IController
{
  public void Jump()
  {
    // When the user presses A
  }
}

public class Game
{
  private readonly IController _controller
  
  public Game(IController controller)
  {
      _contoller = controller;
  }
  
  public void ReadController
  {
      if (_controller.Jump())
      {
          // Do jump
      }
  }
}
```

The above would be similar for PC as well. The Jump() method would called when the user presses the space bar.

Using the above, you only have to change which controller class you're using in one place: **The Composition Root**. This is the place where you set up Dependency Injection - where we tell .NET which class to inject in.

## Testing

### What is Testing?

Testing is an integral part of the Software Development Life Cycle (SDLC). Often times, testing will be done in both the Design Phase and the Testing Phase. The Design Phase comes before the Development Phase and the Testing Phase comes after the Development Phase.

#### Design Phase

In the Design Phase of the SDLC, you start of with creating the interfaces which will be used, this can be done on paper or electronically. After that you create your data requirements and these will consist of Entity-Relationship-Diagrams, Data Dictionaries and Data Flow Diagrams. Once you have done that, you create your algorithms and these are often done in either flow charts or pseudocode. Once you have done that you can finally move on to the Testing part of the Design Phase. In the Design Phase, you create a Test Plan/Strategy which demonstrates a thorough and detailed understanding of:
1. How the components interrelate
2. The order in which components should be tested
3. The types of tests that are required

#### Testing Phase

In the Testing Phase of the SDLC, you refer back to the Test Plan/Strategy that you created and test your entire solution. On the Test Plan/Strategy, you should have two empty columns on the end of it, one for the actual results and one for the evidence of these results.
You go through your entire solution using different testing techniques and thoroughly test it all.
You could use different testing techniques such as: White Box & Black Box Testing, Unit Testing and Smoke Testing.

After you have carried out all your tests and fixed any errors, you will go through regression testing which is where you test to see if any changes you made to fix a problem haven't created any errors elsewhere.

### Different types of testing

#### Functional Testing

1. Unit Testing
2. Smoke Testing
3. Integration Testing
4. System Testing

##### Unit Testing

[Tech Target-Unit Testing](https://www.techtarget.com/searchsoftwarequality/definition/unit-testing#:~:text=Unit%20testing%20is%20a%20software,developers%20and%20sometimes%20QA%20staff.)

Unit Testing is a software development process in which the smallest testable parts of a solution, called units are individually tested. The main objective of unit testing is to isolate written code to test and determine if it works as intended.

Unit Testing is an extremely important step in the development process, because if done correctly, it can help detect early flaws in code which may be more difficult to find in later testing stages.

Unit Testing is a component of Test-Driven-Development, a methodology that takes a meticulous approach to building a solution by means of continual testing.

###### How Unit Tests Work

A unit test typically comprises of three stages: Plan, Cases & Scripting and the Unit Test itself. In the first step, the unit test is prepared and reviewed. The next step is for the test cases and scripts to be made, then the code is tested.

Each test case is tested independently in an isolated environment to ensure a lack of dependencies in the code. The software developer should code criteria to verify each test case and a testing framework that can be used to report any failed tests. Unit Tests should be performed frequently and can be done manually or automated.

###### Types of Unit Testing

Unit Tests can be performed manually or automated. Those employing a manual method may have an instinctual document made detailing each step in the process. However, automated testing is the more common method to unit tests. Automated approaches commonly use a testing framework to develop test cases. These frameworks are also set to flag and report any failed test cases while also providing a summary of test cases.

###### Advantages of Unit Testing

- The earlier a problem is identified, the fewer compound errors occur.
- Costs of fixing a problem early can quickly outweigh the cost of fixing it later.
- Debugging process are made easier.
- Developers can quickly make changes to the code base.
- Developers can also re-use code, migrating it to new projects

###### Disadvantages of Unit Testing

- Tests will not uncover every bug
- Unit Tests only test sets of data and it's functionality - it will not catch errors in integration.
- More lines of test code may need to be written to test one line of code - creating a potential time investment.
- Unit Testing may have a steep learning curve, for example, having to learn how to use specific automated software tools.

#### Non-Functional Testing

1. Availability Testing
2. Compatibility Testing
3. Configuration Testing
4. Load Testing

#### Front-End Testing

1. Code/Script Performance and Functionality
2. Browser Compatibility
3. Operating System Compatibility
4. Cross-Browser Performance
5. Formatting and Rendering
6. Loading Times
7. Responsiveness

#### Security Testing

1. Vulnerability Scanning
2. Static Analysis
3. Dynamic Analysis
4. Integration Analysis

### Testing Techniques

1. Acceptance Testing
2. Alpha Testing
3. Beta Testing
4. Black Box Testing
5. White Box Testing

### Appropriate Tests and Test Data

1. Purpose of the Identified Test
2. Test Data:
   - Valid Test Data
   - Invalid Test Data
   - Valid Extreme Text Data
   - Invalid Extreme Test Data
   - Erroneous Test Data
3. Pre-requisite to each test
4. Expected Test Results
5. Update the Plan to Include:
   - Actual Results
   - Changes Made
   - Retests/Regression Testing following changes made

### Test-Driven Development

[Wikepedia-Test-Driven Development](https://en.wikipedia.org/wiki/Test-driven_development)

Test-Driven Development (TDD) is a software development process relying on software requirements being converted to test cases before software is fully developed, and tracking all software development by repeatedly testing the software against all test cases. This is as opposed to software being developed first and test cases created later.

#### Test-Driven Development Cycle

1. Add a test
The adding of a new feature begins by writing a test that passes if the feature's specifications are met. The developer can discover these specifications by asking about use cases and user stories. A key benefit of Test-Driven Development is that it makes the developer focus on requirements before writing code. This is a contrast with the usual practive, where unit tests are only written after code.
2. Run all tests. The new test should fail for expected reasons
This shows that the new code is actually needed for the desired feature. It validates that the test harness is working correctly. It rules out the possibility that the new test is flawed and will always pass.
A test harness (automated test framework) is a collection of software and test data configured to test a program unit by running it under varying conditions and monitoring its behaviour and outputs.
3. Write the simplest code that passes the new test
Inelegant or hard code is acceptable, as long as it passes the test. 
4. All tests should now pass
If any fail, the new code must be revised until they pass. This ensures the new code meets the test requirements and does not break existing features.
5. Refractor as needed, using tests after each refractor to ensure that functionality is preserved.
   - Examples of refactoring:
     - Moving code to where it most logically belongs
     - Removing duplicate code
     - Making names self-documenting
     - Splitting methods into smaller pieces
     - Re-arranging inheritance hierarchies
Code is refactored for readability and maintainability. In particular, hard-coded test data should be removed. Running the test suite after each refactor helps ensure that no existing functionality is broken.
6. Repeat
The cycle above is repeated for each new piece of funcionality. Tests should be small, incremental with commits made often. That way, if new code fails some tests, the programmer can simply undo or revert rather than debug excessively.
