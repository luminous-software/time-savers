namespace Luminous.TimeSavers.Commands.VisualStudio
{
    using Luminous.Code.VisualStudio.Packages;
    using Luminous.TimeSavers.Options.Pages;

    internal abstract class VisualStudioCommand : TimeSaversCommand
    {
        private VisualStudioDialogPage _visualStudioOptions;

        protected VisualStudioDialogPage VisualStudioOptions
            => _visualStudioOptions ?? (_visualStudioOptions = AsyncPackageBase.GetDialogPage<VisualStudioDialogPage>());

        protected VisualStudioCommand(AsyncPackageBase package, int id) : base(package, id)
        { }

        protected override bool CanExecute
            => base.CanExecute && VisualStudioOptions.VisualStudioCommandsEnabled;
    }
}