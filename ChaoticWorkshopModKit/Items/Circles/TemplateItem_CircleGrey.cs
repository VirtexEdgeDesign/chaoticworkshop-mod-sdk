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
    [vxRegisterAsSandboxEntityAttribute("Grey Circle", TemplateModPack.ContactPackName, ModItemCategories.Circles, 0, 0, 68, 68)]
    public class TemplateItem_CircleGrey : TemplateBaseSandboxEntity
    {
        public TemplateItem_CircleGrey(vxGameplayScene2D level, Vector2 position)
            : base (level, position, true)
        {
            PhysicCollider = BodyFactory.CreateCircle(PhysicsSimulation,
                                                ConvertUnits.ToSimUnits(32),5,
                                                ConvertUnits.ToSimUnits(Position));


            PhysicCollider.Restitution = 0.25f;

            this.PhysicCollider.IsStatic = true;
		}

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            // TODO: Add update logic here!
        }
    }
}