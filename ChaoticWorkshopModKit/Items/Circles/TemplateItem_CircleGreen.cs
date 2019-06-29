using FarseerPhysics;
using FarseerPhysics.Controllers;
using FarseerPhysics.Factories;
using Microsoft.Xna.Framework;
using VerticesEngine;

namespace ChaoticWorkshop.Mods.Template.Items
{
    /// <summary>
    /// A Green Circle which has a more bouncey side to it
    /// </summary>
    [vxRegisterAsSandboxEntityAttribute("Green Circle", TemplateModPack.ContactPackName, ModItemCategories.Circles, 68, 0, 68, 68)]
    public class TemplateItem_CircleGreen : TemplateBaseSandboxEntity
    {
        public TemplateItem_CircleGreen(vxGameplayScene2D level, Vector2 position)
            : base(level, position, true)
        {
            PhysicCollider = BodyFactory.CreateCircle(PhysicsSimulation,
                                                ConvertUnits.ToSimUnits(32), 1,
                                                ConvertUnits.ToSimUnits(Position));


            PhysicCollider.Restitution = 0.99f;
        }
    }
}