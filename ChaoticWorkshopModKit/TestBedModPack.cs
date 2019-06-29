using ChaoticWorkshop.Mods.Template.Items;
using ChaoticWorkshop.SDK;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.IO;
using System.Reflection;
using VerticesEngine;

namespace ChaoticWorkshop.Mods.Template
{
    public class TemplateModPack : ChaoticModPack
    {
        public const string ContactPackName = "Test Content Pack Name";

        /// <summary>
        /// Load your sprite sheet here
        /// </summary>
        /// <returns></returns>
        protected override Texture2D LoadSpriteSheet()
        {
            return Content.Load<Texture2D>("textures/spritesheet");
        }


        /// <summary>
        /// Place your name here
        /// </summary>
        protected override string Author
        {
            get { return "Put Your Name here"; }
        }
        

        /// <summary>
        /// Enter in the title of your mod pack in the constructor here.
        /// </summary>
        public TemplateModPack() :base("Mod Pack Template")
        {
            
        }


        /// <summary>
        /// A Content manager which will load content relative to this *.dll. Your content must be in 
        /// a folder labeled "Content" in the same directory as your ContactPacks *.dll.
        /// </summary>
        protected virtual ContentManager Content
        {
            get
            {
                string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                if (_content == null)
                    _content = new ContentManager(Engine.Game.Services, Path.Combine(path, "Content"));
                
                return _content;
            }
        }
        ContentManager _content;

        public override void Initialise(vxEngine Engine)
        {
            base.Initialise(Engine);

            // add some initalisation code here

            // as an example, register the entity categories here: 
            RegisterNewCategory(ContactPackName, ModItemCategories.Circles, Rectangle.Empty, Color.MonoGameOrange);
            RegisterNewCategory(ContactPackName, ModItemCategories.Boxes, Rectangle.Empty, Color.DeepSkyBlue);
        }


        protected override void LoadSoundEffects()
        {
            // load sound effects here

            // example code:
            // vxSoundEffectManager.LoadSoundEffect(Content, key, "path/to/soundeffect");
        }

        protected override void LoadMusic()
        {
            // load music here

            // example code:
            // ChaoticCore.Music.Songs.Add(new vxSong(Content.Load<Song>("path/to/music"), "enter title", "author"));
        }

        protected override void LoadTextures()
        {
            // load textures here

            // example code:
            // myTexture = Content.Load<Texture2D>("path/to/texture");
        }
    }
}
