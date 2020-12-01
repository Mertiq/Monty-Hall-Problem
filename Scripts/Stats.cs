using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public Text wc;
    public Text lc;
    public Text wnc;
    public Text lnc;

    static int numberOfWinAfterChange = 0;
    static int numberOfWinAfterNotChange = 0;
    static int numberOfLooseAfterChange = 0;
    static int numberOfLooseAfterNotChange = 0;


    public static void RecordStats(int choosenDoor, int doorHasCar, bool win)
    {
        if((choosenDoor == doorHasCar) && !win)
        {
            numberOfLooseAfterChange++;
        }else if((choosenDoor == doorHasCar) && win)
        {
            numberOfWinAfterNotChange++;
        }else if((choosenDoor != doorHasCar) && !win)
        {
            numberOfLooseAfterNotChange++;
        }else if((choosenDoor != doorHasCar) && win)
        {
            numberOfWinAfterChange++;
        }
        PlayerPrefs.SetInt("numberOfWinAfterChange", numberOfWinAfterChange);
        PlayerPrefs.SetInt("numberOfLooseAfterChange", numberOfLooseAfterChange);
        PlayerPrefs.SetInt("numberOfWinAfterNotChange", numberOfWinAfterNotChange);
        PlayerPrefs.SetInt("numberOfLooseAfterNotChange", numberOfLooseAfterNotChange);
    }

    public void ShowStats()
    {
        numberOfWinAfterChange = PlayerPrefs.GetInt("numberOfWinAfterChange");
        numberOfLooseAfterChange = PlayerPrefs.GetInt("numberOfLooseAfterChange");
        numberOfWinAfterNotChange = PlayerPrefs.GetInt("numberOfWinAfterNotChange");
        numberOfLooseAfterNotChange = PlayerPrefs.GetInt("numberOfLooseAfterNotChange");
        wc.text = numberOfWinAfterChange.ToString();
        lc.text = numberOfLooseAfterChange.ToString();
        wnc.text = numberOfWinAfterNotChange.ToString();
        lnc.text = numberOfLooseAfterNotChange.ToString();
    }

    public void reset()
    {
        PlayerPrefs.DeleteAll();
        ShowStats();
    }

    private void Start()
    {
        ShowStats();
    }
}
