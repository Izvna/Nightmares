using Terraria;

using Terraria.ID;

using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Microsoft.Xna.Framework.Graphics;



namespace Nightmares.Tiles

{

    public class NitmarOreTile : ModTile

    {

        public override void SetDefaults()

        {

            Main.tileSolid[Type] = true; // Is the tile solid

            Main.tileMergeDirt[Type] = true; // Will tile merge with dirt?

            Main.tileLighted[Type] = true; // ???

            Main.tileBlockLight[Type] = false; // Emits Light

            

            drop = mod.ItemType("NitmarOreItem"); // What item drops after destorying the tile

            ModTranslation name = CreateMapEntryName();

            name.SetDefault("Nitmar Ore");

            AddMapEntry(new Color(0, 0, 0), name); 

            minPick = 210; // What power pick minimum is needed to mine this block.

        }
        public override bool CanExplode(int i, int j)
        {
           return false;
        }
    }
}		