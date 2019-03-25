namespace Luminous.TimeSavers.Commands.VisualStudio
{
    using Luminous.Code.VisualStudio.Packages;
    using Luminous.TimeSavers.Options.Pages;

    internal abstract class VisualStudioCommand : TimeSaversCommand
    {
        private VisualStudioDialogPage _visualStudioOptions;

        protected VisualStudioDialogPage VisualStudioOptions
            => _visualStudioOptions ?? (_visualStudioOptions = PackageBase.GetDialogPage<VisualStudioDialogPage>());

        protected VisualStudioCommand(PackageBase package, int id) : base(package, id)
        { }

        protected override bool CanExecute
            => base.CanExecute && VisualStudioOptions.VisualStudioCommandsEnabled;
    }
}