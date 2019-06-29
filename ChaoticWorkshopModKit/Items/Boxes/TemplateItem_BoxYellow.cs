using FarseerPhysics;
using FarseerPhysics.Controllers;
using FarseerPhysics.Factories;
using Microsoft.Xna.Framework;
using VerticesEngine;

namespace ChaoticWorkshop.Mods.Template.Items
{
    /// <summary>
    /// A Yellow Box that is more rigid to bounce
    /// </summary>
    [vxRegisterAsSandboxEntityAttribute("Yellow Box", TemplateModPack.ContactPackName, ModItemCategories.Boxes, 68, 136, 68, 68)]
    public class TemplateItem_BoxYellow : TemplateBaseSandboxEntity
    {
        public TemplateItem_BoxYellow(vxGameplayScene2D level, Vector2 position)
            : base(level, position, true)
        {
            PhysicCollider = BodyFactory.CreateRectangle(PhysicsSimulation,
                ConvertUnits.ToSimUnits(64),
                ConvertUnits.ToSimUnits(64), 2);

            PhysicCollider.Restitution = 0.5f;
        }
    }
}