using MAUI_PulldownRefresh.PulldownRefresh;

namespace MAUI_PulldownRefresh;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void RefreshView_Refreshing(object sender, EventArgs e)
	{
		// Check we have an defined method to call
		if (RefreshablePageBase.Instance?.refreshPage != null)
		{
			// Make the request to Refresh the page
			RefreshablePageBase.Instance.refreshPage.CallRequestPageRefresh();
		}

        // After the call, clean up the refresh
        RefreshView.IsRefreshing = false;
    }
}
