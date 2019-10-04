using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements
{

    private static Achievements _main = new Achievements();
    public static Achievements main {
        get {
            return _main;
        }
        private set {
            _main = value;
        }
    }

    Dictionary<int, bool> achievements = new Dictionary<int, bool>();

    private Achievements() {

    }

    public void Unlock(int num) {
        achievements[num] = true;
    }

}
