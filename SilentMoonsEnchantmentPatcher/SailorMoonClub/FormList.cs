// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class SailorMoonClub
    {
        public static class FormList
        {
            private static FormLink<IFormListGetter> Construct(uint id) => new FormLink<IFormListGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFormListGetter> LunarForge_LunarAbsorbFLST => Construct(0x81ed);
            public static FormLink<IFormListGetter> SMC_LeverPackageList => Construct(0x5b106);
            public static FormLink<IFormListGetter> LunarForge_UnenchantedFLST => Construct(0x81ea);
            public static FormLink<IFormListGetter> LunarForge_LunarBasicFLST => Construct(0x81eb);
            public static FormLink<IFormListGetter> LunarForge_AwakenedLunarFLST => Construct(0x81ec);
        }
    }
}
