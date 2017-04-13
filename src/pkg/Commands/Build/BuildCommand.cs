namespace Luminous.TimeSavers.Commands.Build
{
    using Luminous.Code.VisualStudio.Packages;
    using Luminous.TimeSavers.Options;

    internal abstract class BuildCommand : TimeSaversCommand
    {
        //***

        protected BuildDialogPage BuildOptions
            => ((PackageClass)Package).BuildOptions;

        //!!!

        protected BuildCommand(PackageBase package, int id) : base(package, id)
        { }

        //!!!

        protected override bool CanExecute
        => (base.CanExecute && BuildOptions.BuildCommandsEnabled);

        //***
    }
}