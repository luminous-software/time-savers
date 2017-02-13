using System;

namespace Luminous.TimeSavers.Commands
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;
    using TimeSavers.Options;

    internal abstract class TimeSaversCommand : DynamicCommand, IDisposable
    {
        private GeneralDialogPage _generalOptions;

        //***

        protected GeneralDialogPage TimeSaversOptions
            => _generalOptions ?? (_generalOptions = Package?.GetDialogPage(typeof(GeneralDialogPage)) as GeneralDialogPage);

        //!!!

        protected TimeSaversCommand(PackageBase package, int id) : base(package, id)
        { }

        //!!!

        protected override bool CanExecute
            => TimeSaversOptions.TimeSaversEnabled;

        //===

        #region IDisposable Support

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _generalOptions.Dispose();
                    _generalOptions = null;
                }

                disposedValue = true;
            }
        }

        //---

        public void Dispose()
        {
            Dispose(true);
        }

        #endregion

        //***
    }
}