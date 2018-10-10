﻿using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.Presenters.Hints;
using MvvmCross.ViewModels;

namespace mvvmcrosstabs
{
    public class NestedChildViewModel : MvxNavigationViewModel
    {
        public NestedChildViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            CloseCommand = new MvxAsyncCommand(async () => await NavigationService.Close(this));
            PopToChildCommand = new MvxCommand(() => NavigationService.ChangePresentation(new MvxPopPresentationHint(typeof(ChildViewModel))));
            PopToRootCommand = new MvxCommand(() => NavigationService.ChangePresentation(new MvxPopToRootPresentationHint()));
            RemoveCommand = new MvxCommand(() => NavigationService.ChangePresentation(new MvxRemovePresentationHint(typeof(SecondChildViewModel))));
        }

        public IMvxAsyncCommand CloseCommand { get; private set; }

        public IMvxCommand PopToChildCommand { get; private set; }

        public IMvxCommand PopToRootCommand { get; private set; }

        public IMvxCommand RemoveCommand { get; private set; }
    }
}
