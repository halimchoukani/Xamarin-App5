using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Task> Tasks { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<Task>();
            taskListView.ItemsSource = Tasks;
        }
        private async void OnAddTaskClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddTaskPage(Tasks));
        }
        private async void OnTaskSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedTask = e.SelectedItem as Task;
            if (selectedTask != null)
            {
                await Navigation.PushAsync(new TaskDetailPage(selectedTask));
            }
        }


    }
}
public class Task
{
    public string Title { get; set; }
}

