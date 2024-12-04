# Task Organizer App 📝

## Overview 🖥️
The **Task Organizer** is a desktop application built using WPF (Windows Presentation Foundation) that helps users manage their tasks efficiently. The app allows users to add, view, and delete tasks, and organize them with details such as task name, deadline, and description.

This project was created for educational purposes to showcase the usage of WPF, MVVM (Model-View-ViewModel) pattern, and basic CRUD operations.

## Features 🚀
- Add new tasks with a name, deadline, and description.
- View your tasks in a clean, organized list.
- Delete tasks from your task list.
- Intuitive and simple user interface.

## Setup Instructions 🛠️

### Prerequisites ⚙️
To run this project, ensure that you have the following installed on your system:
- **Visual Studio** (with WPF support)
- **.NET Framework 4.7.2** or higher
- **Git** (for cloning the repository)

### Cloning the Repository 📂

1. Clone the repository to your local machine:
   ```bash
   git clone https://github.com/yourusername/task-organizer.git
2. Open the solution in Visual Studio:
Navigate to the project folder and open TaskOrganizer.sln.

## Running the Application ▶️
Once the solution is loaded in Visual Studio, press F5 to build and run the application.
The Task Organizer app will open, allowing you to interact with the task management interface.

## Code Structure 📂
TaskOrganizer/
│
├── TaskOrganizer/           # Main WPF application code
│   ├── AddTaskWindow.xaml    # Window to add new tasks
│   ├── MainWindow.xaml      # Main interface displaying task list
│   ├── Task.cs              # Task class (model)
│   └── MainWindow.xaml.cs   # Code-behind for MainWindow
│
|
│
└── README.md                # Project documentation (this file)
## Documentation 📚
### Task Class 🧑‍💻
The Task class represents a task that the user will create in the app. It contains the following properties:

TaskName: The name of the task.
Deadline: The deadline date for the task.
Description: A description of the task.
### MainWindow.xaml 🖥️
The MainWindow.xaml contains the main interface, which displays the list of tasks and includes options to add or delete tasks. The layout is made using Grid and StackPanel controls to ensure responsiveness.

### AddTaskWindow.xaml 🗂️
The AddTaskWindow.xaml allows the user to enter the details of a new task (task name, deadline, and description). Once the form is filled out, users can add the task to the main list.

### RelayCommand 💡
The RelayCommand class is an implementation of the ICommand interface used to bind button click events to methods in the ViewModel or code-behind. It allows for easy command handling in WPF applications.

## License 🔑
This project is licensed under the MIT License - see the LICENSE file for details.
