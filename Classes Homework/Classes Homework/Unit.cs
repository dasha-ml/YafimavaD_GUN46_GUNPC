using Classes_Homework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Classes_Homework
{
    public class Unit
    {
        private float _health;
        public string Name { get; }
        public float Health => _health;
        public int Damage { get; }
        public float Armor { get; }

        public Unit (string name)
        {
            Name = name;
            Damage = 5;
            Armor = 0.6f;
            _health = 100f;
        }

        public Unit (): this (name: "Unknown Unit")
        { 
        }

        public float GetRealHealth()
        {
            return Health * (1f + Armor);
        }

        public bool SetDamage (float value)
        {
            _health = Health - value*Armor;
            return Health <= 0f;

        }
    }
}