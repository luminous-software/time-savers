using System;

namespace Luminous.TimeSavers.Commands
{
    using Code.VisualStudio.Commands;
    using Code.VisualStudio.Packages;
    using TimeSavers.Options.Pages;

    internal abstract class TimeSaversCommand : AsyncDynamicCommand, IDisposable
    {
        private GeneralDialogPage _generalOptions;

        protected GeneralDialogPage GeneralOptions
            => _generalOptions ?? (_generalOptions = AsyncPackageBase.GetDialogPage<GeneralDialogPage>());

        protected TimeSaversCommand(AsyncPackageBase package, int id) : base(package, id)
        { }

        protected override bool CanExecute
            => GeneralOptions.TimeSaversEnabled;

        protected override void OnDisposeManaged(AsyncDynamicCommand command)
        {
            base.OnDisposeManaged(command);

            _generalOptions.Dispose();
            _generalOptions = null;
        }
    }
}