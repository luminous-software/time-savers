namespace Luminous.TimeSavers.Commands.Developer
{
    using Luminous.Code.VisualStudio.Packages;
    using Luminous.TimeSavers.Options;

    internal abstract class DeveloperCommand : TimeSaversCommand
    {
        private DeveloperDialogPage _developerOptions;

        protected DeveloperDialogPage DeveloperOptions
            => _developerOptions ?? (_developerOptions = PackageBase.GetDialogPage<DeveloperDialogPage>());

        protected DeveloperCommand(PackageBase package, int id) : base(package, id)
        { }

        protected override bool CanExecute
            => base.CanExecute && DeveloperOptions.DeveloperCommandsEnabled;
    }
}