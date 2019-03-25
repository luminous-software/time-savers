namespace Luminous.TimeSavers.Commands.Insert
{
    using Luminous.Code.VisualStudio.Packages;

    internal abstract class InsertCommand : TimeSaversCommand
    {
        protected InsertCommand(PackageBase package, int id) : base(package, id)
        { }

        protected override bool CanExecute
            => base.CanExecute; //&& InsertOptions.InsertCommandsEnabled;

        protected override bool IsActive
            => base.IsActive && (Package.GetSelectedItemCount() == 1); //&& InCodeWindow;
    }
}