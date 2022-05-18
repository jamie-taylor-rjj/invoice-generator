# Notes:
```
This read me file is going to contain everything I learned while on my placement with RJJ Software
```
## Git and gitflow:
```
Git is a source control system. It allows us to track all changes to a given code automatically.
```
[Atlassian - Learn Git](https://www.atlassian.com/git#:~:text=Here%20is%20a%20basic%20overview,commit%22%20(save)%20the%20changes)

Basic overview of how Git works:
```
1. Create a repository (project) with a git hosting tool (GitHub)
2. Copy/clone the repository to your local machine
3. Add a file to your local repo and "commit" save the changes
4. Push the changes to your main branch
5. Make a change to your file with a git hosting tool and commit
6. "Pull" the changes to your local machine
7. Create a "branch" (version), make a change, commit the change
8. Open a "pull" request (propose the changes to the main branch)
9. Merge your branch to the main branch
```
List above explained further:
```
The basic idea is that when we create a git repo, there is a main branch. This represents the current state of play for the code within the code base. When we want to make a change to the code base, we create a branch - this is a copy of the code up to that point - and work on it until we have completed the work.
Changes amde to the code base are committed into the branch, this ensures that related changes are saved into source control at the same time. Each commit requires a commmit message, and this should be a helpful description of what the changes are and how they effect the code base.
When the work is completed and has passed any QA or test requirements, the branch is then merged back into the main branch.
Merging is the process of taking the changes in one branch and applying them onto another branch. Git will take care of the majority of the changes, figuring out where to insert your new code and which code changes take precedent.
Sometimes you will get a merge conflict. This is when git can't automatically merge the changes from one branch into another. At this point, you need to intervene and tell git which changes need to be copied over and which changes need to be dropped.
```
```
Gitflow is a way of managing many different branches for developing applications and systems.
```
[Atlassian - Learn Gitflow](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow)
```
In a gitflow project, there is usually a main or trunk branch. The main branch represents the version of the application the client has access to. There is also a branch called develop, dev or development and is taken as a branch from the main branch. The development branch is where all active development happens; this helps to stop changes happening to the main branch.
When work on a work item begins, a feature branch is taken from the development branch. All work on the work item happens in the feature branch and when it passes QA/Testing, it is merged back into development. After the changes have been accepted into the development branch, the feature branch is deleted.
At certain points during development of the application (usually around the end of each sprint), the changes in the development branch are merged back into the main branch. The main branch is then tagged with a version number.
Tagging the main branch at certain points helps us to build and deliver specific versions of the application.
Sometimes we need to make a fix to the code in the main branch. We do this by creating a hotfix branch. This branch contains all of the fixes required to fix the identified issue, and is merged back into the main branch once it passes QA/Testing.
The point of gitflow is that the code in the main branch is only ever updated when a merge into it happens. This means that no one on the development team can merge changes into it. This protects the code base from any accidental damages to the main branch.
Branches are merged into other branches using Pull Requests. A Pull Request (or PR) represents a request to the other developers on the team to pull your changes into a certain branch. PRs allow development teams to apply a level of code quality checks to the code base, and for individual developers to learn best practises from other members of the team.
PRs can be accepted with or without comments, or they can be denied. When a PR is accepted, the changes in the source branch are merged into the destination branch. When a PR is denied, the changes are not merged. Comments on a PR allow the reviewer to ask questions to and leave advice for the creator of the PR. The creator is then asked to either respond to the comments or make any requested changes.
```

### Forks
```
A fork is a copy of a repository that you manage. A fork lets you make changes to a project without affecting the original repository. You have the ability to fetch uodates from or submit changes to the original repository with pull requests.
Forking a repository is similar to copying a repository, with two major differences:

You can use a pull request to suggest changes from your user-owned fork to the original repository in its GitHub instance, also known as the upstream repository.
You can also bring changes from the upstream repository to your local fork by synchronising your fork with the upstream repository (original repository in its GitHub instance).
```

### Pull Requests
```
Pull Requests let you tell others about changes you've pushed to a branch in a repository on GitHub. Once a pull request is opened, you can discuss and review the potential changes with collaborators and add follow-up commits before your changes are merged into the base branch.
After you initialise a pull request, you will see a review page that shows a high-level overview of the changes between your branch, (the compare branch) and the repository's base branch. You can add a summary of the proposed changes, review the changes made by commits, add labels, milestones, add assignees and @mention individual contributors or teams.
Pull requests are created to propose and collaborate on changes to a repository. These changes are proposed in a branch, which ensures that the default branch only contains finished and approved work.
Once you've created a pull request, you can push commits from your topic branch to add them to your existing pull request. These commits will appear in chronological order within your pull request and the changes will be visible in the "Files changed" tab.
Other contributors can review your proposed changes, add review comments, contribute to the pull request discussion and add commits to the pull request.
```

### Commits
```
Similar to saving a file that's been edited, a commit records changes to one or more files in your branch. Git assigns each commit a unique ID, called a SHA or hash that identifies:
> The specific changes
> When the changes were made
> Who created the changes
When you make a commit, you must include a commit message that briefly describes the changes.
```
