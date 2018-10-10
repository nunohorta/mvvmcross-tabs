using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace mvvmcrosstabs.Droid
{
    //[MvxFragmentPresentation(typeof(RootViewModel), Resource.Id., true,
    //                         Resource.Animation.abc_fade_in,
    //                         Resource.Animation.abc_fade_out,
    //                         Resource.Animation.abc_fade_in,
    //                         Resource.Animation.abc_fade_out)]
    //[MvxFragmentPresentation(typeof(SplitRootViewModel), Resource.Id.split_)]
    [MvxFragmentPresentation(typeof(TabsRootViewModel), Resource.Id.content_frame)]
    //[MvxFragmentPresentation(fragmentHostViewType: typeof(ModalNavView), fragmentContentId: Resource.Id.dialog_)]
    [Register(nameof(ChildView))]
    public class ChildView : MvxFragment<ChildViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.ChildView, null);

            return view;
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
        }
    }
}
