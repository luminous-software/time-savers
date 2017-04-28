namespace Luminous.TimeSavers.Commands.Insert
{
    using Luminous.Code.VisualStudio.Packages;

    internal abstract class InsertCommand : TimeSaversCommand
    {
        //***

        //protected BuildDialogPage InsertOptions
        //    => ((PackageClass)Package).InsertOptions;

        //---M

        protected InsertCommand(PackageBase package, int id) : base(package, id)
        { }

        //---M

        protected override bool CanExecute
            => base.CanExecute; //&& InsertOptions.InsertCommandsEnabled;

        //protected override bool IsActive
        //    => base.IsActive && InCodeWindow;


        //***
    }
}