using Microsoft.AspNetCore.Components;

namespace MAUI_PulldownRefresh.PulldownRefresh
{
    /// <summary>
    /// A class that any page that needs to implement PulldownRefresh can inherit from
    /// </summary>
    public abstract class RefreshablePageBase : ComponentBase
    {
        public static RefreshablePageBase Instance { get; private set;}

        [Inject]
        public RefreshPage refreshPage { get; set; }

        protected RefreshablePageBase()
        {
            Instance = this;
        }
    }
}
