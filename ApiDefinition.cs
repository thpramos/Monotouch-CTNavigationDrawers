using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace CTNavigationDrawers {

	// @interface JASidePanelController : UIViewController <UIGestureRecognizerDelegate>
	[BaseType (typeof (UIViewController))]
	interface JASidePanelController : IUIGestureRecognizerDelegate {

		// @property (nonatomic, strong) UIViewController * leftPanel;
		[Export ("leftPanel", ArgumentSemantic.Retain)]
		UIViewController LeftPanel { get; set; }

		// @property (nonatomic, strong) UIViewController * centerPanel;
		[Export ("centerPanel", ArgumentSemantic.Retain)]
		UIViewController CenterPanel { get; set; }

		// @property (nonatomic, strong) UIViewController * rightPanel;
		[Export ("rightPanel", ArgumentSemantic.Retain)]
		UIViewController RightPanel { get; set; }

		// @property (nonatomic) JASidePanelStyle style;
		[Export ("style")]
		_JASidePanelStyle Style { get; set; }

		// @property (assign, nonatomic) BOOL pushesSidePanels;
		[Export ("pushesSidePanels", ArgumentSemantic.UnsafeUnretained)]
		bool PushesSidePanels { get; set; }

		// @property (nonatomic) CGFloat leftGapPercentage;
		[Export ("leftGapPercentage")]
		nfloat LeftGapPercentage { get; set; }

		// @property (nonatomic) CGFloat leftFixedWidth;
		[Export ("leftFixedWidth")]
		nfloat LeftFixedWidth { get; set; }

		// @property (readonly, nonatomic) CGFloat leftVisibleWidth;
		[Export ("leftVisibleWidth")]
		nfloat LeftVisibleWidth { get; }

		// @property (nonatomic) CGFloat rightGapPercentage;
		[Export ("rightGapPercentage")]
		nfloat RightGapPercentage { get; set; }

		// @property (nonatomic) CGFloat rightFixedWidth;
		[Export ("rightFixedWidth")]
		nfloat RightFixedWidth { get; set; }

		// @property (readonly, nonatomic) CGFloat rightVisibleWidth;
		[Export ("rightVisibleWidth")]
		nfloat RightVisibleWidth { get; }

		// @property (nonatomic) CGFloat minimumMovePercentage;
		[Export ("minimumMovePercentage")]
		nfloat MinimumMovePercentage { get; set; }

		// @property (nonatomic) CGFloat maximumAnimationDuration;
		[Export ("maximumAnimationDuration")]
		nfloat MaximumAnimationDuration { get; set; }

		// @property (nonatomic) CGFloat bounceDuration;
		[Export ("bounceDuration")]
		nfloat BounceDuration { get; set; }

		// @property (nonatomic) CGFloat bouncePercentage;
		[Export ("bouncePercentage")]
		nfloat BouncePercentage { get; set; }

		// @property (nonatomic) BOOL bounceOnSidePanelOpen;
		[Export ("bounceOnSidePanelOpen")]
		bool BounceOnSidePanelOpen { get; set; }

		// @property (nonatomic) BOOL bounceOnSidePanelClose;
		[Export ("bounceOnSidePanelClose")]
		bool BounceOnSidePanelClose { get; set; }

		// @property (nonatomic) BOOL bounceOnCenterPanelChange;
		[Export ("bounceOnCenterPanelChange")]
		bool BounceOnCenterPanelChange { get; set; }

		// @property (nonatomic) BOOL panningLimitedToTopViewController;
		[Export ("panningLimitedToTopViewController")]
		bool PanningLimitedToTopViewController { get; set; }

		// @property (nonatomic) BOOL recognizesPanGesture;
		[Export ("recognizesPanGesture")]
		bool RecognizesPanGesture { get; set; }

		// @property (readonly, nonatomic) JASidePanelState state;
		[Export ("state")]
		_JASidePanelState State { get; }

		// @property (assign, nonatomic) BOOL centerPanelHidden;
		[Export ("centerPanelHidden", ArgumentSemantic.UnsafeUnretained)]
		bool CenterPanelHidden { get; set; }

		// @property (readonly, nonatomic, weak) UIViewController * visiblePanel;
		[Export ("visiblePanel", ArgumentSemantic.Weak)]
		UIViewController VisiblePanel { get; }

		// @property (assign, nonatomic) BOOL shouldDelegateAutorotateToVisiblePanel;
		[Export ("shouldDelegateAutorotateToVisiblePanel", ArgumentSemantic.UnsafeUnretained)]
		bool ShouldDelegateAutorotateToVisiblePanel { get; set; }

		// @property (assign, nonatomic) BOOL canUnloadRightPanel;
		[Export ("canUnloadRightPanel", ArgumentSemantic.UnsafeUnretained)]
		bool CanUnloadRightPanel { get; set; }

		// @property (assign, nonatomic) BOOL canUnloadLeftPanel;
		[Export ("canUnloadLeftPanel", ArgumentSemantic.UnsafeUnretained)]
		bool CanUnloadLeftPanel { get; set; }

		// @property (assign, nonatomic) BOOL shouldResizeRightPanel;
		[Export ("shouldResizeRightPanel", ArgumentSemantic.UnsafeUnretained)]
		bool ShouldResizeRightPanel { get; set; }

		// @property (assign, nonatomic) BOOL shouldResizeLeftPanel;
		[Export ("shouldResizeLeftPanel", ArgumentSemantic.UnsafeUnretained)]
		bool ShouldResizeLeftPanel { get; set; }

		// @property (assign, nonatomic) BOOL allowRightOverpan;
		[Export ("allowRightOverpan", ArgumentSemantic.UnsafeUnretained)]
		bool AllowRightOverpan { get; set; }

		// @property (assign, nonatomic) BOOL allowLeftOverpan;
		[Export ("allowLeftOverpan", ArgumentSemantic.UnsafeUnretained)]
		bool AllowLeftOverpan { get; set; }

		// @property (assign, nonatomic) BOOL allowLeftSwipe;
		[Export ("allowLeftSwipe", ArgumentSemantic.UnsafeUnretained)]
		bool AllowLeftSwipe { get; set; }

		// @property (assign, nonatomic) BOOL allowRightSwipe;
		[Export ("allowRightSwipe", ArgumentSemantic.UnsafeUnretained)]
		bool AllowRightSwipe { get; set; }

		// @property (readonly, nonatomic, strong) UIView * leftPanelContainer;
		[Export ("leftPanelContainer", ArgumentSemantic.Retain)]
		UIView LeftPanelContainer { get; }

		// @property (readonly, nonatomic, strong) UIView * rightPanelContainer;
		[Export ("rightPanelContainer", ArgumentSemantic.Retain)]
		UIView RightPanelContainer { get; }

		// @property (readonly, nonatomic, strong) UIView * centerPanelContainer;
		[Export ("centerPanelContainer", ArgumentSemantic.Retain)]
		UIView CenterPanelContainer { get; }

		// -(void)showLeftPanel:(BOOL)animated;
		[Export ("showLeftPanel:")]
		void ShowLeftPanel (bool animated);

		// -(void)showRightPanel:(BOOL)animated;
		[Export ("showRightPanel:")]
		void ShowRightPanel (bool animated);

		// -(void)showCenterPanel:(BOOL)animated;
		[Export ("showCenterPanel:")]
		void ShowCenterPanel (bool animated);

		// -(void)showLeftPanelAnimated:(BOOL)animated;
		[Export ("showLeftPanelAnimated:")]
		void ShowLeftPanelAnimated (bool animated);

		// -(void)showRightPanelAnimated:(BOOL)animated;
		[Export ("showRightPanelAnimated:")]
		void ShowRightPanelAnimated (bool animated);

		// -(void)showCenterPanelAnimated:(BOOL)animated;
		[Export ("showCenterPanelAnimated:")]
		void ShowCenterPanelAnimated (bool animated);

		// -(void)toggleLeftPanel:(id)sender;
		[Export ("toggleLeftPanel:")]
		void ToggleLeftPanel (NSObject sender);

		// -(void)toggleRightPanel:(id)sender;
		[Export ("toggleRightPanel:")]
		void ToggleRightPanel (NSObject sender);

		// -(void)styleContainer:(UIView *)container animate:(BOOL)animate duration:(NSTimeInterval)duration;
		[Export ("styleContainer:animate:duration:")]
		void StyleContainer (UIView container, bool animate, double duration);

		// -(void)stylePanel:(UIView *)panel;
		[Export ("stylePanel:")]
		void StylePanel (UIView panel);

		// +(UIImage *)defaultImage;
		[Static, Export ("defaultImage")]
		UIImage DefaultImage ();

		// -(UIBarButtonItem *)leftButtonForCenterPanel;
		[Export ("leftButtonForCenterPanel")]
		UIBarButtonItem LeftButtonForCenterPanel ();
	}
}
