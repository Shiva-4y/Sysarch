# 🎉 Sysarch

## 📌 Project Overview
This is a C# Windows Forms application for managing departments and colleges. It includes basic CRUD (Create, Read, Update, Delete) functionality to store and manage department and college data in a MySQL database.

## 🚀 How to Run
1. Clone this repository:
   ```sh
   git clone https://github.com/your-username/Sysarch.git
2. Navigate to the project folder:
   ```sh
   cd Sysarch
3. Configure your database in each form:
   ```sh
    private string connectionString = "server=127.0.0.1; database=your_databasename; uid=root; pwd=your_password;";
4. Start the application.

## 🔀 Git Workflow
main: Stable version

feature-branch: New features (create PRs before merging)

Pull Request Process: Code review before merging

1. Create a new branch
   ```sh
   git checkout -b your-name
2. Committing Changes
   ```sh
   git add .
   git commit -m "Added [feature/bugfix] - short description"
3. Pushing Changes
   ```sh
   git push origin feature/your-feature-name
4. Committing Changes
   ```sh
   git add .
   git commit -m "Added [feature/bugfix] - short description"
5. Creating a Pull Request (PR)
   ```sh
   Go to the GitHub repository.
   Click Pull Requests > New Pull Request.
   Select feature/your-feature-name as the source branch and dev as the target branch.
   Add a description and request a review.
5. Merging the PR
   ```sh
   git checkout dev
   git pull origin dev
   git merge feature/your-feature-name
   git push origin dev
6. Updating the main Branch
   ```sh
   git checkout main
   git merge dev
   git push origin main

 
## 🤝 Contributors
John Paul Sanoria (Shiva-4y)

Axell Senagan (axell27)

Jarcel Franz Tubigon (willowpf)

## 📌 Features
✅ Create, Read, Update, Delete (CRUD)

## 🛠️ Technologies Used
c# / Windowsform / MySQL (HeidiSQL)

Git & GitHub for version control







