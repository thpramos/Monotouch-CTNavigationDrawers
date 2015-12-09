using System;

using UIKit;
using CoreGraphics;

namespace CTNavigationDrawersSample
{
	public partial class LeftPanelViewController : UIViewController
	{
		public LeftPanelViewController () : base ("LeftPanelViewController", null)
		{
		}
		UIButton bt2;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.View.BackgroundColor = UIColor.Gray;

			UIButton bt = new UIButton (new CGRect(0,0,100,200));
			bt.SetTitle ("PRESS ME", UIControlState.Normal);
			bt.TouchUpInside += (object sender, EventArgs e) => {
				var sidePanelController = SidePanelViewController.ParentSidePanelController(this);
				sidePanelController.ShowRightPanel(true);
			};
			this.View.AddSubview (bt);


			bt2 = new UIButton (new CGRect(0,200,200,200));
			bt2.SetTitle ("PRESS 2", UIControlState.Normal);
			bt2.TouchUpInside += (object sender, EventArgs e) => {
				var sidePanelController = SidePanelViewController.ParentSidePanelController(this);

				UINavigationController vc2 = new UINavigationController(new UIViewController ());
				vc2.ViewControllers[0].View.BackgroundColor = UIColor.Yellow;
				sidePanelController.CenterPanel = vc2;
			};
			this.View.AddSubview (bt2);



		}

		public override void ViewDidLayoutSubviews ()
		{
			base.ViewDidLayoutSubviews ();
			bt2.Center = View.Center;

		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


