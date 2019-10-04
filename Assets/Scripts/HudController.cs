using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Pattison
{
    public class HudController : MonoBehaviour
    {

        public PlayerController player;
        public Image progressBar;

        private static HudController current;

        void Start() {

            if (current == null) {
                current = this;
                DontDestroyOnLoad(gameObject);
            } else {
                Destroy(gameObject);
            }

        }


        void Update() {

            //float p = Inventory.main.totalXP / Inventory.main.nextLevelXP;
            
            if (player != null) {
                float p = player.GetPercentXP();
                progressBar.fillAmount = p;
            }
        }


        public void LoadNextScene() {
            //print("CLICKED");
            SceneManager.LoadScene("Scene02", LoadSceneMode.Single);
        }
        public void LoadFirstScene() {
            print("???");
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

        }

    }
}