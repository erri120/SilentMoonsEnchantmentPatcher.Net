// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class SailorMoonClub
    {
        public static class ArtObject
        {
            private static FormLink<IArtObjectGetter> Construct(uint id) => new FormLink<IArtObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IArtObjectGetter> AbsorbMoonTargetPointFX => Construct(0x22f0);
            public static FormLink<IArtObjectGetter> AbsorbMoonCastPointFX01 => Construct(0x22ef);
        }
    }
}
