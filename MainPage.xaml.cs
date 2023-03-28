using System.Collections.ObjectModel;

namespace MAUI_01_01_BindableLayout;

public partial class MainPage : ContentPage
{
	public ObservableCollection<string> MyStringList { get; set; }
    public Command ClearCommand { get; set; }

    public MainPage()
	{
		InitializeComponent();

        ClearCommand = new Command(()=> MyStringList.Clear());

        MyStringList = new ObservableCollection<string>
		{
            "https://www.youtube.com/watch?v=Gxo-85Cbii8",
            "Gerald Versluis",
            "BindableLayout: Repeater Control for all!"
        };

        BindingContext = this;
    }

}

