using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pattison
{
    public class ItemKey : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start() {

            if (Inventory.main.hasKeyCrystal) {
                Destroy(gameObject);
            }
           

        }

        void OnMouseDown() {

            Inventory.main.hasKeyCrystal = true;
            print("You pick up the crystal key.");
            Destroy(gameObject);

        }
    }
}