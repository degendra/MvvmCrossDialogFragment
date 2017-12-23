using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views.Attributes;
using MvvmCrossDialogFragment.Core.ViewModels;

namespace MvvmCrossDialogFragment.Droid.Views
{
    [MvxDialogFragmentPresentation]
    [Register(nameof(ModalView))]
    public class ModalView : MvxAppCompatDialogFragment<ModalViewModel>
    {
        public ModalView()
        {
        }

        protected ModalView(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.ModalView, null);
            Dialog.Window.RequestFeature(WindowFeatures.NoTitle);
            return view;
        }
    }
}
