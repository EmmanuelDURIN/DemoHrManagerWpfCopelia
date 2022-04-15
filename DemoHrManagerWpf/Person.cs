using ViewModel;

namespace DemoHrManagerWpf
{
  internal class Person : BindableBase
  {
    private int age;
    private string firstName;
    private string lastName;
    public string FirstName
    {
      get { return firstName; }
      set
      {
        SetProperty(ref firstName, value);
      }
    }
    public string LastName
    {
      get { return lastName; }
      set
      {
        SetProperty(ref lastName, value);
      }
    }
    public int Age
    {
      get { return age; }
      set
      {
        SetProperty(ref age, value);
      }
    }


    private Genre genre;
    public Genre Genre
    {
      get { return genre; }
      set
      {
        SetProperty(ref genre, value);
      }
    }
    public bool IsMale
    {
      set
      {
        if (value)
        {
          Genre = Genre.Male;
          OnPropertyChanged(nameof(IsMale));
        }
      }
      get => genre == Genre.Male;
    }
    public bool IsFemale
    {
      set { if (value)
        {
          Genre = Genre.Female;
          OnPropertyChanged(nameof(IsFemale));
        }
      }
      get => genre == Genre.Female;
    }
    public bool IsNonBinary
    {
      set { if (value)
        {
          Genre = Genre.NonBinary;
          OnPropertyChanged(nameof(IsNonBinary));
        }
      }
      get => genre == Genre.NonBinary;
    }
  }
}
