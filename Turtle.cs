using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace EasyTouchRemove
{
    internal class Turtle : Actor
    {
        private float rotationSpeed = 90f;
        private float speed = 200f;
        public override void Update(GameTime gameTime)
        {
            var deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            var keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Left))
            {
                // turn left
                Turn(-rotationSpeed * deltaTime);
            }
            if (keyboardState.IsKeyDown(Keys.Right))
            {
                // turn right
                Turn(rotationSpeed * deltaTime);
            }
            if (keyboardState.IsKeyDown(Keys.Up))
            {
                // move forward
                var distance = speed * deltaTime;
                Move(distance);
            }
            else if (keyboardState.IsKeyDown(Keys.Down))
            {
                // move backward at half speed
                var distance = speed / 2 * deltaTime;
                Move(-distance);
            }
            if (IsTouching(typeof(Plum)))
            {
                RemoveTouching(typeof(Plum));
            }
        }

    }
}
