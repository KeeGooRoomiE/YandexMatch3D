using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterBehavior : MonoBehaviour
{
    public SceneManager scene;
    public BoosterManager manager;
    public GameController game;
    public SelectObject obj1 = null;
    public SelectObject obj2 = null;

    // Start is called before the first frame update

    public void UseBooster() {

        if (manager.booster2Count >= 1)
        {
            var i=0;
            i = Random.Range(0, game.pairGenNumber);
            if (game.objects[i] != null)
            {
                obj1 = game.objects[i].GetComponent<SelectObject>();
                var j = 0;
                for (j=0; j<game.objects.Length; j++)
                {
                    if (game.objects[j].GetComponent<SelectObject>().objectId == obj1.objectId)
                    {
                        obj2 = game.objects[j].GetComponent<SelectObject>();

                        obj1.ClearControllerObject();
                        obj1.AddScore();
                        obj1.Delete();
                        obj2.ClearControllerObject();
                        obj2.Delete();
                        ClearVars();
                        manager.booster2Count -= 1;
                    }
                }
            }
        } else
        {
            scene.ShowStore();
        }
    }

    public void ClearVars()
    {
        obj1 = null;
        obj2 = null;
    }
}
