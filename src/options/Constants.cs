namespace Luminous.TimeSavers.Options
{
    using static Core.Constants;

    internal static class Constants
    {
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

        public const string TimeSavers = "Time Savers";
        public const string TimeSaversFeatureSet = TimeSavers + Space + FeatureSet;
        public const string TimeSaversVersion = "Version Number";

        public const string BuildFeatureSet = Build + Space + FeatureSet;
        public const string RebuildSolution = "Rebuild Solution";
        public const string RebuildProject = "Rebuild Project";
        public const string CancelBuild = "Cancel Build";

        public const string DeveloperFeatureSet = Developer + Space + FeatureSet;
        public const string ActivityLog = "Activity Log";
        public const string DiagnosticsLog = "Diagnostics Log";
        public const string PathVariables = "Path Variables";

        public const string VisualStudioFeatureSet = VisualStudio + Space + FeatureSet;
        public const string ReopenStartPage = "Reopen Start Page";
        public const string RestartVisualStudio = Restart + Space + VisualStudio;
        public const string RestartVisualStudioAsAdmin = RestartVisualStudio + Space + AsAdmin;

        public const string SeparatorsFeature = Separators + Space + Feature;
        public const string Definitions = "Definitions";

        public const string OptionsFeatureSet = Options + Space + FeatureSet;
        public const string TimeSaversOptions = TimeSavers + Space + Options;
        public const string KeyboardOptions = Keyboard + Space + Options;
    }
}