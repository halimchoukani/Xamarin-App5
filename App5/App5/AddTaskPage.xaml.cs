using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTaskPage : ContentPage
    {
        private ObservableCollection<Task> _tasks;
        public AddTaskPage(ObservableCollection<Task> tasks)
        {
            InitializeComponent();
            _tasks = tasks;
        }
        private async void OnAddTaskClicked(object sender, EventArgs e)
        {
            var taskTitle = taskEntry.Text;
            if (!string.IsNullOrEmpty(taskTitle))
            {
                _tasks.Add(new Task { Title = taskTitle });
                await Navigation.PopAsync();//Retourner à la MainPage
            }
        }
    }
}