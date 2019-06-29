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
    [vxRegisterAsSandboxEntityAttribute("Purple Circle", TemplateModPack.ContactPackName, ModItemCategories.Circles, 68 * 3, 0, 68, 68)]
    public class TemplateItem_CirclePurple : TemplateBaseSandboxEntity
    {
        GravityController GravityController;

        public TemplateItem_CirclePurple(vxGameplayScene2D level, Vector2 position)
            : base(level, position, true)
        {
            PhysicCollider = BodyFactory.CreateCircle(PhysicsSimulation,
                                                ConvertUnits.ToSimUnits(32), 5,
                                                ConvertUnits.ToSimUnits(Position));
            PhysicCollider.IgnoreGravity = true;
            PhysicCollider.LinearDamping = 0.85f;
            GravityController = new GravityController(1, ConvertUnits.ToSimUnits(128+64), 0);

            GravityController.Strength = 10;
            GravityController.AddBody(PhysicCollider);
            PhysicsSimulation.AddController(GravityController);

            PhysicCollider.Restitution = 0.95f;
        }

        protected override void OnSimulationStart()
        {
            base.OnSimulationStart();
            PhysicCollider.FixedRotation = false;
            PhysicCollider.IgnoreGravity = true;
        }

        protected override void OnSimulationStop()
        {
            base.OnSimulationStop();
        }

        public override void Dispose()
        {
            base.Dispose();

            PhysicsSimulation.RemoveController(GravityController);
        }
    }

}