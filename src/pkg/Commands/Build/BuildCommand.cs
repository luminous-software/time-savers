namespace Luminous.TimeSavers.Commands.Build
{
    using Luminous.Code.VisualStudio.Packages;
    using Luminous.TimeSavers.Options;

    internal abstract class BuildCommand : TimeSaversCommand
    {
        private BuildDialogPage _buildOptions;

        protected BuildDialogPage BuildOptions
            => _buildOptions ?? (_buildOptions = PackageBase.GetDialogPage<BuildDialogPage>());

        protected BuildCommand(PackageBase package, int id) : base(package, id)
        { }

        protected override bool CanExecute
            => base.CanExecute && BuildOptions.BuildCommandsEnabled;
    }
}