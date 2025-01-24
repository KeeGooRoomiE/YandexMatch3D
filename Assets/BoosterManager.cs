using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterManager : MonoBehaviour
{

    public int booster1Count;
    public int booster2Count;
    public bool canUseBooster=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canUseBooster == true)
        {
            canUseBooster = false;
        }
        
    }

    public void AddBoosterTime(int value)
    {
        booster1Count += value;
    }

    public void AddBoosterSolver(int value)
    {
        booster2Count += value;
    }

    public void UseBoosterTime()
    {
        if (booster1Count > 0)
        {
            booster1Count -= 1;
            canUseBooster = true;
        }
    }

    public void UseBoosterSolver()
    {
        if (booster2Count > 0)
        {
            booster2Count -= 1;
            canUseBooster = true;
        }
    }
}
