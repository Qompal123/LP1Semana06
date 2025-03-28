using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        private static int totalPowerUps;

        static Enemy()
        {
            totalPowerUps = 0;
        }

        public Enemy(string name)
        {
            SetName(name);
            health = 100;
        }

        public void PickupPowerUp(PowerUp powerUp, float value)
        {
            if (powerUp == PowerUp.Health)
            {
                health = MathF.Min(health + value, 100);
            }
            else if (powerUp == PowerUp.Shield)
            {
                shield = MathF.Min(shield + value, 100);
            }
            totalPowerUps++;
        }

        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public void SetName(string name)
        {
            if (name.Length > 8)
            {
                this.name = name.Substring(0, 8);
            }
            else
            {
                this.name = name;
            }
        }

        public static int GetTotalPowerUps()
        {
            return totalPowerUps;
        }
    }
}