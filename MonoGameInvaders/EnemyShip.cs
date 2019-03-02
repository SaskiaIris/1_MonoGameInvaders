using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameInvaders {
	class EnemyShip : GameObject {
		//public Vector2 position;
		//public Vector2 velocity;
		//public Texture2D texture;

		//public int enemyShipLives;

		public EnemyShip() : base("sprites/enemies/spr_enemy_ship") {
			//texture = Global.content.Load<Texture2D>("sprites/enemies/spr_enemy_ship");
			isEnemy = true;
			//Init();
		}

		public override void Init() {
			base.Init();
			position.X = Global.width/2;
			position.Y = 50;

			velocity.X = 4;
			velocity.Y = 0;

			lives = 2;
			//enemyShipLives = 2;
			//velocity.X *= startingDirection;
		}

		//public override void Update() {
		//	//position.X += velocity.X;

		//	//if((position.X > Global.width - texture.Width) || (position.X < 0)) {
		//	//	position.X -= velocity.X;
		//	//	velocity.X *= -1;
		//	//}
		//}

		//public override void Draw() {
		//	//Global.spriteBatch.Draw(texture, position, Color.White);
		//}
	}
}