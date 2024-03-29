﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Rigidbody
    {
        public Vector2 Velocity
        {
            get; private set;
        }

        public float mass = 1.0f;
        public float force = 150.0f;
        public float dragCoefficient = .47f;

        public void AddForce(Vector2 forceDirection, float deltaTime)
        {
            Vector2 vector2 = forceDirection * this.force / this.mass * deltaTime;
            this.Velocity = new Vector2()
            {
                x = (float)(1.0f / dragCoefficient * Math.Exp(-dragCoefficient / mass * deltaTime) * (dragCoefficient * Velocity.x + mass * (double)vector2.x) - mass * (double)vector2.x / dragCoefficient),
                y = (float)(1.0f / dragCoefficient * Math.Exp(-dragCoefficient / mass * deltaTime) * (dragCoefficient * Velocity.y + mass * (double)vector2.y) - mass * (double)vector2.y / dragCoefficient)
            };


            //Vector2 acceleration = forceDirection / mass;
            //Velocity = (1 / dragCoefficient * (float)Math.Exp(-dragCoefficient / mass * deltaTime) * (forceDirection * dragCoefficient)) + (acceleration * mass) - (acceleration * mass / dragCoefficient);
        }
    }
}
