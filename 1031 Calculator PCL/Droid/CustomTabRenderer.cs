[assembly: ExportRenderer(typeof(TabbedPage), typeof(Calculator1031.Droid.CustomTabRenderer))]
namespace Calculator1031.Droid
{
    public class CustomTabRenderer: TabbedRenderer 
   {
        private Activity _activity;

        protected override void OnModelChanged(VisualElement oldModel, VisualElement newModel)
        {
            base.OnModelChanged(oldModel, newModel);

            _activity = this.Context as Activity;
        }

        // May put this code in a different method - was just for testing
        public override void OnWindowFocusChanged(bool hasWindowFocus)
        {   
            // Here the magic happens:  get your ActionBar and select the tab you want to add an image
            ActionBar actionBar = _activity.ActionBar;

            if (actionBar.TabCount == 4)
            {
              Android.App.ActionBar.Tab tabOne = actionBar.GetTabAt(0);
              tabOne.SetIcon(Resource.Drawable.calculator);
              
              Android.App.ActionBar.Tab tabTwo = actionBar.GetTabAt(0);
              tabTwo.SetIcon(Resource.Drawable.save);
              
              Android.App.ActionBar.Tab tabThree = actionBar.GetTabAt(0);
              tabThree.SetIcon(Resource.Drawable.about);
              
              Android.App.ActionBar.Tab tabFourth = actionBar.GetTabAt(0);
              tabFourth.SetIcon(Resource.Drawable.disclaimer);
            }
            base.OnWindowFocusChanged(hasWindowFocus);
        }
    }
}
