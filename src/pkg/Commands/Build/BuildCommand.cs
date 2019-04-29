namespace Luminous.TimeSavers.Commands.Build
{
    using Luminous.Code.VisualStudio.Packages;
    using Luminous.TimeSavers.Options.Pages;

    internal abstract class BuildCommand : TimeSaversCommand
    {
        private BuildDialogPage _buildOptions;

        protected BuildDialogPage BuildOptions
            => _buildOptions ?? (_buildOptions = AsyncPackageBase.GetDialogPage<BuildDialogPage>());

        protected BuildCommand(AsyncPackageBase package, int id) : base(package, id)
        { }

        protected override bool CanExecute
            => base.CanExecute && BuildOptions.BuildCommandsEnabled;

        protected override bool IsActive
            => base.IsActive && SolutionHasProjects;
    }
}