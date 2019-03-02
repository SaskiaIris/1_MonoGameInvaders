﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameInvaders {
	class Invader : GameObject {
		//public Vector2 position;
		//public Vector2 velocity;
		//public Texture2D texture;
		public int frameCounter = 0;
		//public int startingDirection;

		public Invader(String assetName) : base(assetName) {
			//texture = Global.content.Load<Texture2D>(assetName);
			isEnemy = true;
			//Init();
		}

		public override void Init() {
			base.Init();
			lives = 1;
			position.X = Global.Random(100, Global.width - 100);
			position.Y = Global.Random(-100, -texture.Height - 1);
			//position.Y = Global.Random(75, Global.height - 400);
			//startingDirection = Global.Random(-1, 3);
			//if(startingDirection == 0) {
			//	startingDirection = -1;
			//} else if(startingDirection == 2) {
			//	startingDirection = 1;
			//}
			//velocity.X *= startingDirection;
		}

		public override void Update() {
			base.Update();
			//position.X += velocity.X;

			//if(position.Y > Global.height) {
			//	Init();
			//} else if((position.X > Global.width - texture.Width) || (position.X < 0)) {
			//	//position.X -= velocity.X;
			//	//velocity.X *= -1;
			//	position.Y += velocity.Y;
			//}
		}

		//public override void Draw() {
		//	//Global.spriteBatch.Draw(texture, position, Color.White);
		//}
	}
}