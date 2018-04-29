using Foundation;
using System;
using UIKit;

namespace SearchBarDemo
{
    public partial class SimpleTVController : UITableViewController
    {
        public SimpleTVController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
            var search = new UISearchController(new UIViewController())
            {
                DimsBackgroundDuringPresentation = false
            };
            DefinesPresentationContext = true;

            NavigationItem.TitleView = search.SearchBar;
		}

        //private void ShowSearchController(object sender, EventArgs e)
        //{
        //    var search = new UISearchController(searchResultsController: null)
        //    {
        //        DimsBackgroundDuringPresentation = false
        //    };
        //    DefinesPresentationContext = true;
        //    NavigationItem.TitleView = search.SearchBar;

        //}

        //private void HideSearchController(object sender, EventArgs e)
        //{
        //    NavigationItem.TitleView = null;
        //    this.NavigationItem.RightBarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.Search, ShowSearchController);
        //    NavigationController.NavigationBarHidden = false;
        //}
	}
}