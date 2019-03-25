using System;

namespace Luminous.TimeSavers.Commands
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    using Luminous.TimeSavers.Options.Pages;

    internal abstract class TimeSaversCommand : DynamicCommand, IDisposable
    {
        private GeneralDialogPage _generalOptions;

        protected GeneralDialogPage TimeSaversOptions
            => _generalOptions ?? (_generalOptions = PackageBase.GetDialogPage<GeneralDialogPage>());

        protected TimeSaversCommand(PackageBase package, int id) : base(package, id)
        { }

        protected override bool CanExecute
            => TimeSaversOptions.TimeSaversEnabled;

        #region IDisposable Support

        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _generalOptions.Dispose();
                    _generalOptions = null;
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        #endregion IDisposable Support
    }
}