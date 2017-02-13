namespace Luminous.TimeSavers
{
    public static class PackageConstants
    {
        //***

        //===

        public const string Actions = "Actions";
        public const string Advanced = "Advanced";
        public const string Debug = "Debug";
        public const string Output = "Output";
        public const string Package = "Package";
        public const string VS = "VS";
        public const string Restart = "Restart";
        public const string AsAdmin = "As Admin";
        public const string Separator = "Separator";
        public const string InsertGuid = "Insert Guid";

        //---

        public const string General = "General";
        public const string Build = "Build";
        public const string Developer = "Developer";
        public const string Options = "Options";
        public const string Separators = "Separators";
        public const string VisualStudio = "Visual Studio";

        //---

        public const string Space = " ";
        public const string H1 = "1." + Space;
        public const string H2 = "2." + Space;

        public const string Feature = "Feature";
        public const string Features = "Features";
        public const string FeatureSet = "Feature Set";
        public const string Keyboard = "Keyboard";

        public const string Enable = "Enable";
        public const string Enabled = "Enabled";
        public const string EnablesDisables = "Enables/disables";
        public const string EnablesDisablesAll = EnablesDisables + Space + "ALL";

        //===

        public const string TimeSavers = "Time Savers";
        public const string TimeSaversFeatureSet = TimeSavers + Space + FeatureSet;

        //---

        public const string BuildFeatureSet = Build + Space + FeatureSet;
        public const string RebuildSolution = "Rebuild Solution";
        public const string RebuildProject = "Rebuild Project";
        public const string CancelBuild = "Cancel Build";

        //---

        public const string DeveloperFeatureSet = Developer + Space + FeatureSet;
        public const string ActivityLog = "Activity Log";
        public const string DiagnosticsLog = "Diagnostics Log";
        public const string PathVariables = "Path Variables";

        //---

        public const string VisualStudioFeatureSet = VisualStudio + Space + FeatureSet;
        public const string ReopenStartPage = "Reopen Start Page";
        public const string RestartVisualStudio = Restart + Space + VisualStudio;
        public const string RestartVisualStudioAsAdmin = RestartVisualStudio + Space + AsAdmin;

        //---

        public const string SeparatorsFeature = Separators + Space + Feature;
        public const string Definitions = "Definitions";

        //---

        public const string OptionsFeatureSet = Options + Space + FeatureSet;
        public const string TimeSaversOptions = TimeSavers + Space + Options;
        public const string KeyboardOptions = Keyboard + Space + Options;

        //===

        public const bool SupportsAutomation = true;

        //***
    }
}