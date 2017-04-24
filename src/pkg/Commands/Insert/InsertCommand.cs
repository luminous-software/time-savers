//temp for testing
using static Microsoft.VisualStudio.Shell.Interop.UIContextGuids80;

namespace Luminous.TimeSavers.Commands.Insert
{
    using Luminous.Code.VisualStudio.Packages;
    using Luminous.TimeSavers.Options;

    internal abstract class InsertCommand : TimeSaversCommand
    {
        //***

        //protected BuildDialogPage InsertOptions
        //    => ((PackageClass)Package).InsertOptions;

        //!!!

        protected InsertCommand(PackageBase package, int id) : base(package, id)
        { }

        //!!!

        protected override bool CanExecute
            => base.CanExecute; //&& InsertOptions.InsertCommandsEnabled;

        protected override bool IsActive
            => base.IsActive && IsCodeWindow;


        //temp for testing

        protected bool IsCodeWindow
            => ContextIsActive(CodeWindow);


        //***
    }
}