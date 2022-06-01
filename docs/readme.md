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
- `git reset --hard HEAD~1` - This will destroy the commit and undo your work (Only works if you have not pushed yet)

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

##### Smoke Testing

[Wikepedia-Smoke Testing](https://en.wikipedia.org/wiki/Smoke_testing_(software))

[GlobalAppTesting-Smoke Testing](https://www.globalapptesting.com/blog/the-ultimate-guide-to-smoke-testing)

Smoke testing is preliminary testing to reveal simple failures severe enough to, for example, reject a prospective software release. Smoke tests are a subset of test cases that cover the most important functionality of a component or system, used to aid assessment of whether main functions of the software appear to work correctly.

###### Why is Smoke Testing important?

Without smoke tests, it's a waste of time to run other tests. In short, smoke testing is important because it's an indicator of whether a build is even ready for formal testing. Without it, major issues slip through the cracks and have the chance to stay within a build for longer - that's why smoke testing lets developers squash bugs early on.

###### Benefits of Smoke Testing

- System stability

It's incredibly useful to be able to verify, reliably and early on, that your builds are stable. This makes them more usable at later stages, and reduces the amount of work developers have to put into manually searching for and reporting bugs late into the development cycle.
- Simple process

One of the biggest advantages of smoke tests is that they're very easy to conduct. Due to their simplicity, smoke tests are compatible with just about every testing methodology you could think to combine them with.
- Identifies bugs easily

The fewer bugs that make it to the users, the better. That's why it's important to catch bugs as early as possible; it gives developers more time to fix them and ensures that the most prominent ones never make it to end-users.
By smoke testing often, you can ensure that your software is relatively bug-free when it rolls out. At the very least, you can promise your users that you've already caught and fixed any potentially harmful bugs.

##### Integration Testing

[Tech Target-Integration Testing](https://www.techtarget.com/searchsoftwarequality/definition/integration-testing#:~:text=Integration%20testing%20%2D%2D%20also%20known,be%20coded%20by%20different%20programmers.)

Integration testing is a type of software testing in which the different units, modules or components of a software application are tested as a combined entity. However, these modules may be coded by different programmers.

The aim of integration testing is to test the interfaces between the modules and expose any defects that may arise when these components are integrated and need to interact with each other.

###### What does integration testing involve?

Integration testing involves integrating the various modules of an application and then testing their behaviour as a combined or integrated unit. Verifying if the individual units are communicating with each other properly and working as intended post-integration is essential.

To perform integration testing, testers use test drivers and stubs, which are dummy programs that act as substitutes for any missing modules, and simulate data communications between modules for testing purposes. They also use integration-testing tools, including the following:

- [Selenium](https://www.techtarget.com/searchsoftwarequality/tip/Cypress-vs-Selenium-Compare-test-automation-frameworks) is an open source suite that facilitates automated web application testing.
- [Pytest](https://docs.pytest.org/en/6.2.x/) is a Python testing tool, according to Pytest.org, enables small tests to be written easily "yet scales to support a complex functional testing for applications and libraries."
- [IBM's RFT](https://www.ibm.com/products/rational-functional-tester) (Rational Functional Tester) is an object-oriented automated functional testing tool for performing automated functional, regression, GUI and data-driven testing.
- [Junit](https://junit.org/junit5/) is an open source framework designed for writing and running tests for Java and Java Virtual Machine (JVM).
- [Mockito](https://site.mockito.org/) is an open source testing framework for java.
- [Jasmine](https://jasmine.github.io/) is a development framework for testing JavaScript.
- FitNesse in an open source framework in which software testers, developers and customers can work together to build test cases on a wiki.
- [Steam](https://www.softwaretestinghelp.com/integration-testing-tools/) developed by GitHub, is an open source framework, used to test JavaScript-enabled websites.
- LDRA tools are used for integration testing in organisations requiring verification to compliance standards.

Integration testing is usually done simultaneously with development. But this can create a challenge if the modules to be tested are not yet available.

###### Why integration testing is essential

Integration testing is vital in today's IT and software development landscapes, especially when requirements are dynamic and deadlines are tight. Even when each module of the application is unit-tested, some errors may still exist. To identify these errors and ensure that the modules work well together after integration, integration testing is crucial.

###### Common approaches to integration testing

Big-bang testing: The big-bang approach involves integrating all the modules at once and testing them all as one unit.

Big-bang testing's advantages include the following:

- Its suitability for testing small systems
- Its ease of identifying errors in such systems, saving time and speeding up application deployment

Big-bang testing's disadvantages include the following:

- Locating the source of defects can be difficult since different modules are integrated as one unit.
- Big-bang testing is time consuming for a large system with numerous units.
- Testers must wait until all modules are available, so they have less time to do the testing and developers have less time to fix any errors.

Top-down testing: The top-down approach in an incremental approach that involves testing from the topmost or highest-level module and gradually proceeding to the lower modules. Each module is tested one by one, and then integrated to check the final software's functionality.

Advantages of top-down testing are as follows:

- It is easier to identify defects and isolate their sources
- Testers check important units first, so they are more likely to find critical design flaws
- It is possible to create an early prototype

Disadvantages of top-down testing are as follows:

- The examination of lower-level modules can take a lot of time, so testers may not test them adequately or completely
- When too many testing stubs are involved, the testing process can become complicated.

Bottom-up testing: Bottom-up integration testing is the opposite of the top-down approach. It involves testing lower-level modules first, and then gradually progressing incrementally to higher-level modules. This approach is suitable when all units are available for testing.

Advantages of bottom-up testing are as follows:

- It is easier to find and localise faults
- Less time is needed for troubleshooting since testers don't have to wait for all modules to be available for testing

Disadvantages of bottom-up testing are as follows:

- Testing all modules can take a lot of time, so there may be delays in releasing the final product
- Critical modules are tested only in the final stages, so testers may miss some defects and developers may not have enough time to fix found defects
- It is not possible to create an early prototype

##### System Testing

[Tech Target-System Testing](https://www.techtarget.com/searchsoftwarequality/definition/system-testing#:~:text=System%20testing%2C%20also%20referred%20to,full%2C%20integrated%20system%20or%20application.)

###### What is System Testing?

System testing is the process in which a quality assurance (QA) team evaluates how the various components of an application interact together in the full, integrated system or application.

System testing verifies that an application performs tasks as designed. This step, a kind of black box testing, focuses on the functionality of an application. System testing, for example, might check that every kind of user input produces the intended output across the application.

With system testing, a QA team gauges if an application meets all of its requirements, which includes technical, business and functional requirements. To accomplish this, the QA team might utilise a variety of test types, inclding performance, usability, load testing and functional tests.

With system testing, a QA team determines whether a test case corresponds to each of an application's most crucial requirements and user stories. These individual test cases determine the overall test coverage for an application, and help the team catch critical defects that hamper an application's core functionalities before release. A QA team can log and tabulate each defect per requirement.

Additionally, each individual type of system test reports relevant metrics of a piece of software, including:

- Performance testing: speed, average, stability and peak Response times;
- Load testing: throughput, number of users, latency; and
- Usability testing: User error rates, task success rate, time to complete a task, user satisfaction.

###### Phases of System Testing

System testing examines every component of an application to make sure that they work as a complete and unified whole. A QA team typically conducts system testing after it checks individual modules with functional or user-story testing and then each component through integration testing.

If a software build acheives the desired results in system testing, it gets a final check via acceptance testing before it goes to production, where users consume the software. An app-dev team logs all defects, and establishes what kinds and amount of defects are tolerable.

###### System testing tools

Various commercial and open source tools help QA teams, perform and review the results of system testing. These tools can create, manage and automate tests or test cases, and they might also offer features beyond system testing, such as requirements management capabilities.

Commercial system testing tools include froglogic's Squish and Inflectra's SpiraTest, while open source tools include Robotium and SmartBear's SoapUI.

#### Non-Functional Testing

1. Availability Testing
2. Compatibility Testing
3. Configuration Testing
4. Load Testing

##### Availability Testing

[TestMatick-Availability Testing](https://testmatick.com/software-testing-glossary/availability-testing/#:~:text=Availability%20Testing%20which%20is%20also,to%20the%20service%20level%20agreement.)

[Microsoft Documentation-Availability and Resiliency](https://docs.microsoft.com/en-us/azure/architecture/framework/resiliency/testing)

[The Test Therapist-Availability Testing](https://thetesttherapist.com/2021/03/15/availability-testing-what-how-and-why/)

###### What is Availability Testing?

Availability Testing is a kind of performance testing in which the application runs for a set period of time and collects failure events and repair times and compares the availability percentage to the service level agreement.

Availability describes the amount of time when an application runs in a healthy state without significant downtime.

###### Why do we Availability Testing?

The target here is to measure and collect data in case of application/database failure, and to make sure that your application setup is properly configured and with a reasonable downtime which will not affect your customers badly in case of unplanned failures or downtime.

##### Compatibility Testing

[guru99-Compatiblity Testing](https://www.guru99.com/compatibility-testing.html)

###### What is Compatiblity Testing?

Compatiblity Testing is a type of Software testing to check whether your software is capable of running on different hardware, operating systems, applications, network environments or mobile devices.

###### What are some types of Compatibility Tests?

1. Hardware
   - It checks software to be compatible with different hardware configurations.
2. Operating Systems
   - It checks your software to be compatible with different Operating Systems like Windows, Unix, Mac OS etc.
3. Software
   - It checks your developed software to be compatible with other software. For example, MS Word application should be compatible with other software like MS Outlook, MS Excel, VBA etc.
4. Network
   - Evaluation of performance of a system in a network with varifying parameters such as Bandwidth, Operating speed, Capacity. It also checks the application in different networks with all the parameters mentioned earlier.
5. Browser
   - It checks the compatibility of your software with differnt devices like USB port Devices, Printers and Scanners. Other media devices and Bluetooth.
6. Mobile
   - Checking your software is compatible with mobile platforms like Android, iOS etc.
7. Versions of the Software
   - It is verifying your software application to be compatible with different versions of the software. For instance checking your Microsoft Word to be compatible with Windows 7, Windows 7 SP1, Windows 7 SP2, Windows 7 SP3.

There are two types of version checking in Compatibility Testing:

Backward Compatibility Testing

Backward Compatibility Testing is a technique to verify the behaviour and compatiblity of the developed hardware or software with their older versions of the hardware or software. Backward compatibility testing is much more predictable as all the changes from the previous versions are known.

Forward Compatibility Testing

Forward Compatibility Testing is a process to verify the behaviour and compatibility of the developed hardware or software with the newer versions of the hardware or software. Forward compatibility testing is a bit harder to predict as the changes that will be made in the newer versions are not known.

##### Configuration Testing

[guru99-Configuration Testing](https://www.guru99.com/configuration-testing.html#:~:text=Configuration%20Testing%20is%20a%20software,without%20any%20defects%20or%20flaws.)

###### What is Configuration Testing?

Configuration Testing is a software technique in which the software application is tested with multiple combinations of software and hardware in order to evaluate the functional requirements and find out optimal configurations under which the software application works without any defects or flaws.

###### What are the objectives of Configuration Testing?

The objectives of configuration testing is to:

- Validating the application to determine if it fulfills the configurability requirements
- Manually causing failures which help in identifying the defects that are not efficiently found during testing (Ex: changing the regional settings of the system like Time Zone, Language, Date time formats, etc.)
- Determine an optimal configuration of the application under test.
- Analyzing the system performance by adding or modifying the hardware resources like Load Balancers, increase or decrease in memory size, connecting various printer models, etc.
- Analyzing system Efficiency based on the prioritization, how efficiently the tests were performed with the resources available to achieve the optimal system configuration.
- Verification of the system in a geographically distributed Environment to verify how effectively the system performs.
- For Ex: Server at a different location and clients at a different location, the system should work fine irrespective of the system settings.
- Verifying how easily the bugs are reproducible irrespective of the configuration changes.
- Ensuring how traceable the application items are by properly documenting and maintaining the versions which are easily identifiable.
- Verifying how manageable the application items are throughout the software development life cycle.

###### How would you do Configuration Testing?

In this section, we will discuss the strategy that needs to be followed for configuration testing types and there are two types of configuration testing as mentioned below.

- Software Configuration Testing
- Hardware Configuration Testing

Software Configuration Testing

Software configuration testing is testing the Application under test with multiple OS, different software updates, etc. Software Configuration testing is very time consuming as it takes time to install and uninstall different software’s that is used for the testing.

One of the approaches that is followed to test the software configuration is to test on Virtual Machines. Virtual Machine is an Environment that is installed on software and acts like a Physical Hardware and users will have the same feel as of a Physical Machine. Virtual Machines simulates real-time configurations.

Instead of installing and uninstalling the software in multiple physical machines which is time-consuming, it’s always better to install the application/software in the virtual machine and continue testing. This process can be performed by having multiple virtual machines, which simplifies the job of a tester.

Software configuration testing can typically begin when:

- Configurability requirements to be tested are specified
- Test Environment is ready
- Testing Team is well trained in configuration testing
- Build released is unit and Integration test passed

Hardware Configuration Testing

Hardware configuration testing is generally performed in labs, where we find physical machines with different hardware attached to them.

Whenever a build is released, the software has to be installed in all the physical machines where the hardware is attached, and the test suite has to be run on each machine to ensure that the application is working fine.

To perform the above task a significant amount of effort is required to install the software on each machine, attach the hardware and manually running or even to automate the above said process and running the test suite.

Also, while performing hardware configuration test, we specify the type of hardware to be tested, and there are a lot of computer hardware and peripherals which make it quite impossible to run all of them. So it becomes the duty of the tester to analyze what hardware is mostly used by users and try to make the testing based on the prioritization.

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

### Automated Testing

[Global App Testing](https://www.globalapptesting.com/blog/what-is-automation-testing)

#### What is Automation Testing?

Automated Testing is the process of testing software and other tech products to ensure it meets strict requirements. Essentially, it's a test to double-check that the equipment or software does exactly what it was designed to do. It tests for bugs. defects and any other issues that can arise with product development.
Although some types of testing, such as regression or functional testing can be done manually, there are greater benefits of doing it automatically. Automation Testing can be run at any time of the day. It uses scripted sequences to examine the software. It then reports on what's been found, and this information can be compared with earlier test runs. Automation developers generally write in the following programming language: C#, JavaScript and Ruby.

Many software businesses will have an appointed QA (Quality Assurance) automation tester. They design and write the test scripts in the beginning stages. The QA automation tester will work with automation test engineers and product developers to actually test the software and products. They will form a team and control the test automation intiatives and use different types of test automation frameworks to establish the best one for successful test automation.

#### Why is Automation needed?

Automation benefits product development. That's because when software, an app, or another product can be designed and produced more efficiently, it makes way for continuous development once it's been launched. Essentially, the business will be able to work on more software and products, even with the same amount of team members, thanks to automation. Not only does this mean they perfect the final products they put out, but it also means they are creating new software all the time.

#### What are the benefits of Automation Testing?

- Detailed reporting capabilites
Automation Testing uses well-crafted test cases for various scenarios. These scripted sequences can be incredibly high in-depth, and provide detailed reports that simply would't be possible when done by a human. Not to mention providing them in a shorter amount of time.
- Improved bug detection
One of the main reasons to test a product is to detect bugs and other defects. Automation Testing makes this process an easier one. It's also able to analyse a wider test coverage than humans may be able to.
- Simplifies testing
Testing is a routine part of the operations of most SaaS and tech companies. Making it as simple as possible is key. Using automation is extremely beneficial. When automating test tools, the test scripts and be reused. Manual testing calls for a single code line to be written for the same test case, each time it needs to be run.
- Speeds up the testing process
Machines and automated technology work faster than humans. Along with improved accuracy, this is why we use them. In turn, this shortens your software development life cycles.
- Reduces human intervention
Tests can be run at any time of day, even overnight, without needing humans to oversee it. Plus, when it's conducted automatically, this can also reduce the risk of human error.
- Saves time and money
Testing can be time-consuming. Though automation may require an initial investment, it can save money in the long run to become more cost-effective. Team members use their time in other areas and are no longer required to carry out manual testing in many situations. This improves their workflow.

### CI/CD Pipeline?

#### What is a CI/CD Pipeline?

A continuous integration and continuous deployment (CI/CD) pipeline is a series of steps that must be performed in order to deliver a new version of software. CI/CD pipelines are a practice focused on improving software delivery throughout the software development life cycle via automation.

By automating Ci/CD throughout development, testing, production and monitoring phases of the software development life cycle, organisations are able to develop higher quality code, faster. Although it's possible to manually execute each of the steps of a CI/CD pipeline, the true value of CI/CD pipiles realised through automation.

#### What is a CI/CD Pipeline? Explained further

A pipeline is a process that drives software development through a path of building, testing, and deploying code, also known as CI/CD. By automating the process, the objective is to minimize human error and maintain a consistent process for how software is released. Tools that are included in the pipeline could include compiling code, unit tests, code analysis, security and binaries creation. For containerized environments, this pipeline would also include packaging the code into a container image to be deployed across a hybrid cloud.

CI/CD is the backbone of a DevOps methodology, bringing developers and IT operations teams together to deploy software. As custom applications become key to how companies differentiate, the rate at which code can be released has become a competitive differentiator.
