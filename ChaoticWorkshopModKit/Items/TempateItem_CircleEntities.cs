using ChaoticWorkshop.SDK;
using FarseerPhysics;
using FarseerPhysics.Controllers;
using FarseerPhysics.Dynamics;
using FarseerPhysics.Factories;
using Microsoft.Xna.Framework;
using VerticesEngine.Core.Debug;

namespace ChaoticWorkshop.Mods.Template.Items
{
    /// <summary>
    /// The basic grey circle which is static
    /// </summary>
    public class TemplateItem_CircleGrey : TemplateBaseSandboxEntity
    {
        public TemplateItem_CircleGrey(ChaoticSandboxBaseScene level, Vector2 position)
            : base (level, position, true)
        {
            PhysicsBody = BodyFactory.CreateCircle(PhysicsSimulation,
                                                ConvertUnits.ToSimUnits(32),5,
                                                ConvertUnits.ToSimUnits(Position));
            

			PhysicsBody.Restitution = 0.25f;

            this.PhysicsBody.IsStatic = true;
		}

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

        }
    }


    /// <summary>
    /// A Green Circle which has a more bouncey side to it
    /// </summary>
    public class TemplateItem_CircleGreen : TemplateBaseSandboxEntity
    {
        public TemplateItem_CircleGreen(ChaoticSandboxBaseScene level, Vector2 position)
            : base(level, position, true)
        {
            PhysicsBody = BodyFactory.CreateCircle(PhysicsSimulation,
                                                ConvertUnits.ToSimUnits(32), 1,
                                                ConvertUnits.ToSimUnits(Position));


            PhysicsBody.Restitution = 0.99f;
        }
    }


    /// <summary>
    /// A Green Circle which has a more bouncey side to it
    /// </summary>
    public class TemplateItem_CircleOrange : TemplateBaseSandboxEntity
    {
        public TemplateItem_CircleOrange(ChaoticSandboxBaseScene level, Vector2 position)
            : base(level, position, true)
        {
            PhysicsBody = BodyFactory.CreateCircle(PhysicsSimulation,
                                                ConvertUnits.ToSimUnits(32), 1,
                                                ConvertUnits.ToSimUnits(Position));


            PhysicsBody.Restitution = 0.5f;
        }
    }


    /// <summary>
    /// A Green Circle which has a more bouncey side to it
    /// </summary>
    public class TemplateItem_CirclePurple : TemplateBaseSandboxEntity
    {
        GravityController GravityController;

        public TemplateItem_CirclePurple(ChaoticSandboxBaseScene level, Vector2 position)
            : base(level, position, true)
        {
            PhysicsBody = BodyFactory.CreateCircle(PhysicsSimulation,
                                                ConvertUnits.ToSimUnits(32), 5,
                                                ConvertUnits.ToSimUnits(Position));
            PhysicsBody.IgnoreGravity = true;
            PhysicsBody.LinearDamping = 0.85f;
            GravityController = new GravityController(1, ConvertUnits.ToSimUnits(128+64), 0);

            GravityController.Strength = 10;
            GravityController.AddBody(PhysicsBody);
            PhysicsSimulation.AddController(GravityController);

            PhysicsBody.Restitution = 0.95f;
        }

        protected override void StartSimulationForItem()
        {

            //GravityController.Strength = 0.5f;
            base.StartSimulationForItem();
            PhysicsBody.FixedRotation = false;

        }


        protected override void StopSimulationForItem()
        {
            //GravityController.Strength = 0;
            base.StopSimulationForItem();
        }

        public override void Dispose()
        {
            base.Dispose();

            PhysicsSimulation.RemoveController(GravityController);
        }
    }

}