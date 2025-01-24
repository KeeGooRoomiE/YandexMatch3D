using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalyticsManager : MonoBehaviour
{
    public bool[] isLevelOpened;
    public bool[] isLevelSolved;
    public int IAPLive1BoughtTimes;
    public int IAPLive2BoughtTimes;
    public int IAPLive3BoughtTimes;
    public int IAPBoosterTime1BoughtTimes;
    public int IAPBoosterTime2BoughtTimes;
    public int IAPBoosterTime3BoughtTimes;
    public int IAPBoosterPair1BoughtTimes;
    public int IAPBoosterPair2BoughtTimes;
    public int IAPBoosterPair3BoughtTimes;
    public int adShowingCount;
    public int boosterTimeUsedTimes;
    public int boosterPairUsedTimes;

    //
    public LevelManager levels;

    // Start is called before the first frame update
    void InitStat()
    {
        var i=0;
        for (i=0; i<levels.levelSet.Length; i++)
        {
            isLevelOpened[i] = false;
            isLevelSolved[i] = false;
        }

    }
}
