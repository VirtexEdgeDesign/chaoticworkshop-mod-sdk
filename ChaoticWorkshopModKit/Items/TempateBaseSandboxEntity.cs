using ChaoticWorkshop.SDK.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using VerticesEngine;

namespace ChaoticWorkshop.Mods.Template.Items
{
    internal enum ModItemCategories
    {
        Circles,
        Boxes,
        Joints
    }


    // Sandbox Entities inherit from 'ChaoticBaseSandboxEntity'. 
    // It's useful to create a seperate intermediate SandboxEntity class for each mod 
    public class TemplateBaseSandboxEntity : ChaoticBaseSandboxEntity
    {
        public TemplateBaseSandboxEntity(vxGameplayScene2D level, Vector2 position, bool IsDynamic = false)
            : base(level, position, IsDynamic)
        {

        }
    }
}
