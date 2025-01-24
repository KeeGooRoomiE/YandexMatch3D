using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoosterSet : MonoBehaviour
{
    public BoosterManager manager;
    public Button button;
    public Image bubble;
    public Text text;
    public int boosterNum;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (boosterNum == 1)
        {
            if (manager.booster1Count > 0)
            {
                bubble.gameObject.SetActive(true);
                text.gameObject.SetActive(true);
                text.text = manager.booster1Count.ToString();
            }
            else
            {
                bubble.gameObject.SetActive(false);
                text.gameObject.SetActive(false);
                //text.text = manager.booster1Count.ToString();
            }
        }
        
    }
}
