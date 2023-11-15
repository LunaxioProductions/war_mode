using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WarModeMod.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class ZoraArmor : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Celestial Armor");
            Tooltip.SetDefault("20% increased damage");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 18;
            item.value = 300000;
            item.rare = 5;
            item.defense = 127;
        }
        public override void UpdateEquip(Player player)
        {
            player.magicDamage += 0.20f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "WaterEssence", 50);

            recipe.AddTile(null, "ElementalForge");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
