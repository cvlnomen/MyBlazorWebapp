namespace MyBlazorWebapp.StateObjects
{
	public class ProfileState
	{
		public string? FirstName
		{
			get => _currentFirstName;
			set
			{
				_currentFirstName = value;
				StateHasChanged();
			}
		}

		public string? LastName
		{
			get => _currentLastName;
			set
			{
				_currentLastName = value;
				StateHasChanged();
			}
		}

		private string? _currentFirstName;
		private string? _currentLastName;

		public event EventHandler StateChangedHandler;

		private void StateHasChanged() => StateChangedHandler.Invoke(this, EventArgs.Empty);
	}
}
