using System;

namespace Luminous.TimeSavers.Options
{
    public static class Guids
    {
        internal const string GeneralDialogPageString = "dcbbd0f7-6463-48f4-9c86-1ce95ef7c1a2";
        internal const string BuildDialogPageString = "e967a459-0b9e-4222-ba52-a66496edaee3";
        internal const string DeveloperDialogPageString = "7a9f803b-96de-4d30-b1cd-590443192092";
        internal const string VisualStudioDialogPageString = "13c28243-07fb-4034-a035-3a44ff0330aa";
        internal const string SeparatorsDialogPageString = "736339a2-2ba5-4e37-9e55-1e72f5ae4721";
        internal const string OptionsDialogPageString = "6bf7c9fa-8e42-4673-83cb-288efe5ae3b5";

        public static Guid GeneralDialogPage = new Guid(GeneralDialogPageString);
        public static Guid BuildDialogPage = new Guid(BuildDialogPageString);
        public static Guid DeveloperDialogPage = new Guid(DeveloperDialogPageString);
        public static Guid VisualStudioDialogPage = new Guid(VisualStudioDialogPageString);
        public static Guid SeparatorsDialogPage = new Guid(SeparatorsDialogPageString);
        public static Guid OptionsDialogPage = new Guid(OptionsDialogPageString);
    }
}