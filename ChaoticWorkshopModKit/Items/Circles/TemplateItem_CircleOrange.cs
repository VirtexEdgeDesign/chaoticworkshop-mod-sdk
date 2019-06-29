using FarseerPhysics;
using FarseerPhysics.Controllers;
using FarseerPhysics.Factories;
using Microsoft.Xna.Framework;
using VerticesEngine;

namespace ChaoticWorkshop.Mods.Template.Items
{
    /// <summary>
    /// An Orange Circle which has some bounc to it
    /// </summary>
    [vxRegisterAsSandboxEntityAttribute("Orange Circle", TemplateModPack.ContactPackName, ModItemCategories.Circles, 68 * 2, 0, 68, 68)]
    public class TemplateItem_CircleOrange : TemplateBaseSandboxEntity
    {
        public TemplateItem_CircleOrange(vxGameplayScene2D level, Vector2 position)
            : base(level, position, true)
        {
            PhysicCollider = BodyFactory.CreateCircle(PhysicsSimulation,
                                                ConvertUnits.ToSimUnits(32), 1,
                                                ConvertUnits.ToSimUnits(Position));


            PhysicCollider.Restitution = 0.5f;
        }
    }
}