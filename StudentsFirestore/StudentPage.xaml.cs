using StudentsFirestore.Services;
using StudentsFirestore.ViewModels;

namespace StudentsFirestore;

public partial class StudentPage : ContentPage
{
	public StudentPage()
	{
		InitializeComponent();
		var firestoreService = new FirestoreService();
		BindingContext = new StudentViewModel(firestoreService);
	}
}