using FarseerPhysics;
using FarseerPhysics.Controllers;
using FarseerPhysics.Factories;
using Microsoft.Xna.Framework;
using VerticesEngine;

namespace ChaoticWorkshop.Mods.Template.Items
{
    /// <summary>
    /// The basic grey circle which is static
    /// </summary>
    [vxRegisterAsSandboxEntityAttribute("Grey Box", TemplateModPack.ContactPackName, ModItemCategories.Boxes, 0, 136, 68, 68)]
    public class TemplateItem_BoxGrey : TemplateBaseSandboxEntity
    {
        public TemplateItem_BoxGrey(vxGameplayScene2D level, Vector2 position)
            : base (level, position, false)
        {
            PhysicCollider = BodyFactory.CreateRectangle(PhysicsSimulation,
                ConvertUnits.ToSimUnits(64),
                ConvertUnits.ToSimUnits(64), 5);


            PhysicCollider.Restitution = 0.25f;

            this.PhysicCollider.IsStatic = true;
		}
    }
}