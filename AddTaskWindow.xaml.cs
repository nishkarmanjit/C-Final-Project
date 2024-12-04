using System;
using System.Windows;

namespace TaskOrganizer
{
    public partial class AddTaskWindow : Window
    {
        public Task NewTask { get; private set; }

        public AddTaskWindow()
        {
            InitializeComponent();
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(TaskNameTextBox.Text) || string.IsNullOrWhiteSpace(DeadlineTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Create a new task
            NewTask = new Task
            {
                TaskName = TaskNameTextBox.Text,
                Deadline =  $"Date: {DeadlineTextBox.Text}",
                Description = $"Description: {DescriptionTextBox.Text}"
            };

            // Close the form and return the new task
            DialogResult = true;
            Close();
        }
    }
}
