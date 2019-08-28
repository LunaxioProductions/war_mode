using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JoostMod.Projectiles
{
	public class ShockWave2 : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Desert Golem");
			Main.projFrames[projectile.type] = 4;
		}
		public override void SetDefaults()
		{
			projectile.width = 18;
			projectile.height = 50;
			projectile.aiStyle = 0;
			projectile.hostile = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 70;
			projectile.tileCollide = false;
			aiType = ProjectileID.Bullet;
            projectile.extraUpdates = 1;
		}

		public override void AI()
		{
			if (projectile.timeLeft > 60)
			{
				projectile.frame = 0;
				projectile.height = 18;
			}
			if (projectile.timeLeft == 60)
			{
				projectile.position.Y = projectile.position.Y - 6;
			}
			if (projectile.timeLeft <= 60 && projectile.timeLeft > 50)
			{
				projectile.frame = 1;
				projectile.height = 24;
			}
			if (projectile.timeLeft == 50)
			{
				projectile.position.Y = projectile.position.Y - 12;
			}
			if (projectile.timeLeft <= 50 && projectile.timeLeft > 40)
			{
				projectile.frame = 2;
				projectile.height = 36;
			}
			if (projectile.timeLeft == 40)
			{
				projectile.position.Y = projectile.position.Y - 13;
			}
			if (projectile.timeLeft <= 40 && projectile.timeLeft > 30)
			{
				projectile.frame = 3;
				projectile.height = 50;
			}
			if (projectile.timeLeft == 30)
			{
				projectile.position.Y = projectile.position.Y + 13;
			}
			if (projectile.timeLeft <= 30 && projectile.timeLeft > 20)
			{
				projectile.frame = 2;
				projectile.height = 36;
			}
			if (projectile.timeLeft == 20)
			{
				projectile.position.Y = projectile.position.Y + 12;		
			}
			if (projectile.timeLeft <= 20 && projectile.timeLeft > 10)
			{
				projectile.frame = 1;
				projectile.height = 24;
			}
			if (projectile.timeLeft == 10)
			{
				projectile.position.Y = projectile.position.Y + 6;
			}
			if (projectile.timeLeft <= 10)
			{
				projectile.frame = 0;
				projectile.height = 18;
			}
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.velocity.Y -= projectile.knockBack * target.knockBackResist;
            if (target.knockBackResist > 0)
            {
                target.velocity.X = 0;
            }
        }
        public override void OnHitPvp(Player target, int damage, bool crit)
        {
            Player player = Main.player[projectile.owner];
            if (!target.noKnockback)
            {
                target.velocity.Y -= projectile.knockBack;
            }
        }
        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            knockback = 0;
        }
    }
}
