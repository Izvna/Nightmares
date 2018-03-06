using System;

using System.Collections.Generic;

using Microsoft.Xna.Framework;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using Terraria;

using Terraria.ModLoader;

using Terraria.ID;



namespace Nightmares.Projectiles

{

    public class DreamLaser : ModProjectile

    {

        public override void SetStaticDefaults()

        {

            DisplayName.SetDefault("DreamLaser");

            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;

            ProjectileID.Sets.TrailingMode[projectile.type] = 0;

        }



        public override void SetDefaults()

        {

            projectile.width = 8;

            projectile.height = 8;

            projectile.aiStyle = 1;

            projectile.friendly = true;         

            projectile.hostile = false;         

            projectile.ranged = true;           

            projectile.penetrate = 5;           

            projectile.timeLeft = 600;           

            projectile.light = 1.5f;            

            projectile.ignoreWater = true;      

            projectile.tileCollide = true;      

            projectile.extraUpdates = 1;                                           

            aiType = ProjectileID.GreenLaser; 

           
        }
    }
}
    

