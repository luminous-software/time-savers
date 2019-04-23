namespace Luminous.TimeSavers.Commands.Developer
{
    using Luminous.Code.VisualStudio.Packages;
    using Luminous.TimeSavers.Options.Pages;

    internal abstract class DeveloperCommand : TimeSaversCommand
    {
        private DeveloperDialogPage _developerOptions;

        protected DeveloperDialogPage DeveloperOptions
            => _developerOptions ?? (_developerOptions = AsyncPackageBase.GetDialogPage<DeveloperDialogPage>());

        protected DeveloperCommand(AsyncPackageBase package, int id) : base(package, id)
        { }

        protected override bool CanExecute
            => base.CanExecute && DeveloperOptions.DeveloperCommandsEnabled;

        protected override bool IsActive
            => base.IsActive && InCodeWindow;

    }
}