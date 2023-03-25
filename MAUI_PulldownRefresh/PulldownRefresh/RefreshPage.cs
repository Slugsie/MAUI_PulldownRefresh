namespace MAUI_PulldownRefresh.PulldownRefresh
{
    public sealed class RefreshPage
    {
        public event Action RefreshPageRequested;

        public void CallRequestPageRefresh()
        {
            RefreshPageRequested?.Invoke();
        }
    }
}