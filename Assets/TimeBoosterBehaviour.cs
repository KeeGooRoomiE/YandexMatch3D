using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBoosterBehaviour : MonoBehaviour
{
    public BoosterManager manager;
    public SceneManager scene;
    public GameController game;

public void UseBooster()
    {
        if(manager.booster1Count >=1)
        {
            game.currentTime += 30;
            manager.booster1Count -= 1;
        } else
        {
            scene.ShowStore();
        }
    }
}
