using System;
using Microsoft.Xna.Framework;
using ChaoticWorkshop.SDK;
using Microsoft.Xna.Framework.Graphics;
using ChaoticWorkshop.SDK.Entities;

namespace ChaoticWorkshop.Mods.Template.Items
{
    // entities are registered by category
    public enum TemplateEntityCategories
    {
        TestBed_CirclularItems,
        TestBed_RectangularItems
    }

    // Sandbox Entities inherit from 'ChaoticBaseSandboxEntity'. 
    // It's useful to create a seperate intermediate SandboxEntity class for each mod 
    public class TemplateBaseSandboxEntity : ChaoticBaseSandboxEntity
    {
        public TemplateBaseSandboxEntity(ChaoticSandboxBaseScene level, Vector2 position, bool IsDynamic = false)
            : base(level, position, IsDynamic)
        {
        }

        public override Texture2D GetSpriteSheet()
        {
            return ChaoticBaseSandboxEntity.EntitySpriteSheetRegister[GetItemTypeKey()].SpriteSheet;
        }
    }
}
