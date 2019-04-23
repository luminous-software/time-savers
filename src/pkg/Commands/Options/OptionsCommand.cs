namespace Luminous.TimeSavers.Commands.Options
{
    using Luminous.Code.VisualStudio.Packages;
    using Luminous.TimeSavers.Options.Pages;

    internal abstract class OptionsCommand : TimeSaversCommand
    {
        private OptionsDialogPage _options;

        protected OptionsDialogPage Options
            => _options ?? (_options = AsyncPackageBase.GetDialogPage<OptionsDialogPage>());

        protected OptionsCommand(AsyncPackageBase package, int id) : base(package, id)
        { }

        protected override bool CanExecute
            => base.CanExecute && Options.OptionsCommandsEnabled;
    }
}