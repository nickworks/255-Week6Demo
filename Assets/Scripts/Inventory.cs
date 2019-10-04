using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pattison
{
    public class Inventory
    {

        #region Static / Singleton Stuff

        private static Inventory _main; // C# field
        public static Inventory main { // C# property
            get { // public getter
                if (_main == null) _main = new Inventory(); // lazy instantiation
                return _main;
            }
            private set { // private setter
                _main = value;
            }
        }

        public static void Reset() {
            main.hasSword = false;
            main.hasKeyCrystal = false;
        }

        #endregion

        public bool hasSword = false;
        public bool hasKeyCrystal = false;

        public float totalXP = 500;
        public float nextLevelXP = 750;


        private Inventory() { }
        

    }
}