using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowToPlay : MonoBehaviour
{
    public Text text;
    public GameObject panel;
    public void showHTP()
    {
        panel.SetActive(true);
        text.text = "Suppose you are in a game and you have the right to choose one of the three doors." +
            " Behind one of the doors is a carriage and behind the others there are goats. One of the doors, " +
            "let's say you choose 1st and the game who knows what's behind the doors, let's say one of the other doors," +
            " with the goat behind it, 3rd. Then you will have the right to change your choice. Is changing your choice to" +
            " your advantage or disadvantage?\n"+
            "To find out, play the game and check the statistics.";
    }

}
