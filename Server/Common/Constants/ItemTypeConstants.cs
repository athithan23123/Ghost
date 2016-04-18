﻿namespace Server.Common.Constants
{
    public class ItemTypeConstants
    {
        public enum EquipType : byte
        {
            Weapon = 0xFF,  // 武器[weapon]
            Mantle = 0xFE,  // 披風[mantle]
            Hat = 0xFD,     // 帽子[hat]
            Face2 = 0xFC,   // 臉下[face2]
            Face = 0xFB,    // 臉上[face]
            Outfit = 0xFA,  // [outfit]
            Dress = 0xF9,   // [dress]
            Seal = 0xF8     // 封印物[Seal]
        }

        public enum ItemType : byte
        {
            Equip1 = 1,     // [1]
            Equip2 = 2,     // [2]
            Use = 3,        // [3]
            Etc = 4,        // [4]
            Pet = 5         // [5]
        }
    }
}