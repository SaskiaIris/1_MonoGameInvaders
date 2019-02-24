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
			/*position.X = Global.Random(100, Global.width - 100);
			position.Y = Global.Random(75, Global.height - 400);

			velocity.X = Global.Random(2, 5);
			velocity.Y = Global.Random(8, 13);*/
			Reset();
		}

		public virtual void Reset() {
			position.X = Global.Random(100, Global.width - 100);
			//position.Y = Global.Random(-300, 0);
			position.Y = Global.Random(75, Global.height - 400);

			//velocity.X = Global.Random(2, 5);
			//velocity.Y = Global.Random(8, 13);
			velocity.X = 3;
			velocity.Y = 10;
		}

		public virtual void Update() {
			position.X += velocity.X;

			if(position.Y > Global.height) {
				Reset();
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