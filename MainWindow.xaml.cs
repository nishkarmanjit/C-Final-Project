using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace TaskOrganizer
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Task> Tasks { get; set; }
        public ICommand DeleteTaskCommand { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Initialize tasks
            Tasks = new ObservableCollection<Task>
            {
                new Task { TaskName = "Complete WPF App", Deadline = "29th November", Description = "Develop a WPF Task Organizer App for the final project." },
                new Task { TaskName = "Prepare Presentation", Deadline = "28th November", Description = "Create slides for the final project presentation." }
            };

            // Command to delete tasks
            DeleteTaskCommand = new RelayCommand<Task>(DeleteTask);

            // Set data context for binding
            DataContext = this;

            TaskList.ItemsSource = Tasks;
        }

        private void OpenAddTaskForm(object sender, RoutedEventArgs e)
        {
            // Open the Add Task Form
            AddTaskWindow addTaskWindow = new AddTaskWindow();
            bool? result = addTaskWindow.ShowDialog(); // Show dialog and wait for result
            if (result == true && addTaskWindow.NewTask != null)
            {
                // Add the new task to the collection
                Tasks.Add(addTaskWindow.NewTask);
            }
        }

        private void DeleteTask(Task task)
        {
            if (task != null)
            {
                Tasks.Remove(task);
            }
        }
    }

    // RelayCommand implementation
    public class RelayCommand<T> : ICommand
    {
        private readonly System.Action<T> execute;
        private readonly System.Func<T, bool> canExecute;

        public RelayCommand(System.Action<T> execute, System.Func<T, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => canExecute == null || canExecute((T)parameter);

        public void Execute(object parameter) => execute((T)parameter);

        public event System.EventHandler CanExecuteChanged;
        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, System.EventArgs.Empty);
    }
}
