using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pattison
{
    public class PlayerController : MonoBehaviour
    {

        public HudController prefabHUD;

        private float totalXP = 0;
        private float nextLevelXP = 750;

        public float GetPercentXP() {
            return totalXP / nextLevelXP;
        }

        void Start() {
            HudController obj = Instantiate(prefabHUD);
            obj.player = this;
        }


        void Update() {
            totalXP += 100 * Time.deltaTime;
        }
    }
}