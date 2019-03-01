using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameInvaders {
	class Invader {
		public Vector2 position;
		public Vector2 velocity;
		public Texture2D texture;

		public Invader(String assetName) {
			texture = Global.content.Load<Texture2D>(assetName);
			Init();
		}

		public virtual void Init() {
			position.X = Global.Random(100, Global.width - 100);
			//position.Y = Global.Random(-300, 0);
			position.Y = Global.Random(75, Global.height - 400);

			velocity.X = Global.Random(2, 5);
			velocity.Y = Global.Random(8, 13);
			//velocity.X = velocityInvader.X;
			//velocity.Y = velocityInvader.Y;
		}

		public virtual void Update() {
			position.X += velocity.X;

			if(position.Y > Global.height) {
				Init();
			} else if((position.X > Global.width - texture.Width) || (position.X < 0)) {
				position.X -= velocity.X;
				velocity.X *= -1;
				position.Y += velocity.Y;
			}
		}

		public virtual void Draw() {
			Global.spriteBatch.Draw(texture, position, Color.White);
		}
	}
}