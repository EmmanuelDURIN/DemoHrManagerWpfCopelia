using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace DemoHrManagerWpf.ViewModel
{
  internal class MainViewModel : BindableBase
  {
    private Person person;
    private ObservableCollection<Person> people = new ObservableCollection<Person>();
    public Person SelectedPerson
    {
      get { return person; }
      set
      {
        SetProperty(ref person, value);
      }
    }
    public ObservableCollection<Person> People
    {
      get { return people; }
      set
      {
        SetProperty(ref people, value);
      }
    }
    public async Task LoadData()
    {
      IsLoading = true;
      try
      {
        await Task.Delay(TimeSpan.FromMilliseconds(3));
        var loadedPeople = Enumerable
                              .Range(1, 10)
                              .Select
                              (
                                  i => new Person
                                  {
                                    FirstName = "FirstName" + (i + 1),
                                    LastName = "LastName" + (i + 1),
                                    Age = 18 + i
                                  }
                              );
        foreach (var person in loadedPeople)
          people.Add(person);
      }
      finally
      {
        IsLoading = false;
      }
    }
    private bool isLoading;

    public bool IsLoading
    {
      get { return isLoading; }
      set
      {
        // Emet l'évt pour dire que IsLoading a changé
        bool hasChanged = SetProperty(ref isLoading, value);
        if (hasChanged)
          OnPropertyChanged(nameof(IsNotLoading));
      }
    }
    // principe de propriété dérivée
    public bool IsNotLoading
    {
      get => !isLoading;
    }
  }
}
