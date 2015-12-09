using System;

using UIKit;
using CTNavigationDrawers;
using CoreGraphics;

namespace CTNavigationDrawersSample
{
	public partial class SidePanelViewController : JASidePanelController
	{
		public SidePanelViewController (IntPtr handle) : base (handle)
		{
		}

		public SidePanelViewController ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.ShouldDelegateAutorotateToVisiblePanel = false;

			LeftPanelViewController vc = new LeftPanelViewController ();
			this.LeftPanel = vc;
			this.LeftFixedWidth = 256;


			UIViewController vc3 = new UIViewController ();
			vc3.View.BackgroundColor = UIColor.Green;
			this.RightPanel = vc3;


			UINavigationController vc2 = new UINavigationController(new UIViewController ());
			vc2.ViewControllers[0].View.BackgroundColor = UIColor.Red;
			this.CenterPanel = vc2;


			UIButton bt = new UIButton (new CGRect(0,0,100,100));
			bt.Center = View.Center;
			bt.SetTitle ("PRESS ME", UIControlState.Normal);
			bt.TouchUpInside += (object sender, EventArgs e) => {
				this.ShowRightPanel(true);
			};

			this.CenterPanel.View.AddSubview (bt);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		public static SidePanelViewController ParentSidePanelController(UIViewController child)
		{

			UIViewController iter = child.ParentViewController;
			while (iter != null) {
				if (iter.GetType() == typeof(SidePanelViewController)) {
					return (SidePanelViewController )iter;
				} else if (iter.ParentViewController != null && iter.ParentViewController != iter) {
					iter = iter.ParentViewController;
				} else {
					iter = null;
				}
			}
			return null;

		}

	}
}

