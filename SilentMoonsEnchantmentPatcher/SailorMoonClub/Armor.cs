// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class SailorMoonClub
    {
        public static class Armor
        {
            private static FormLink<IArmorGetter> Construct(uint id) => new FormLink<IArmorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IArmorGetter> SMC_AlchemyGloves => Construct(0x1ce04);
            public static FormLink<IArmorGetter> SMC_EnchRingParanoia => Construct(0x31884);
        }
    }
}
