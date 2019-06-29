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
    [vxRegisterAsSandboxEntityAttribute("Purple Box", TemplateModPack.ContactPackName, ModItemCategories.Boxes, 68 * 2, 136, 68, 68)]
    public class TemplateItem_BoxPurple : TemplateBaseSandboxEntity
    {
        GravityController GravityController;

        public TemplateItem_BoxPurple(vxGameplayScene2D level, Vector2 position)
            : base(level, position, false)
        {
            PhysicCollider = BodyFactory.CreateRectangle(PhysicsSimulation,
                ConvertUnits.ToSimUnits(64),
                ConvertUnits.ToSimUnits(64), 10);

            PhysicCollider.IgnoreGravity = true;
            PhysicCollider.LinearDamping = 0.85f;
            GravityController = new GravityController(1, ConvertUnits.ToSimUnits(128 + 64), 0);

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