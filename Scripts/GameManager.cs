using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region public variables

    public Button[] buttons;
    public GameObject[] cars;
    public GameObject[] goats;
    public GameObject[] doors;
    public Sprite[] inactiveButtons;
    public Sprite[] activeButtons;
    public Button tryagainButton;

    #endregion

    #region public static variables

    public int doorHasCar = 0;
    public int doorPlayerChoosed = 0;
    public bool firstChoice = true;
    bool win = false;
    #endregion

    void makeReadyScene()
    {
        determineWhichDoorHasCar();

        cars[doorHasCar-1].SetActive(true);
        goats[doorHasCar-1].SetActive(false);
    }

    void determineWhichDoorHasCar()
    {
        doorHasCar = Random.Range(1, 4);
    }

    void OpenAllDoors()
    {
        foreach (var door in doors)
        {
            door.SetActive(false);
        }
    }

    void DeleteAllButtons()
    {
        int a = 0;
        foreach (var button in buttons)
        {
            button.image.sprite = inactiveButtons[a];
            button.enabled = false;
            a++;
        }
    }

    public void eleminateTheGoat(int door)
    {
        doorPlayerChoosed = door;
        firstChoice = false;
        int[] x = { 1, 2, 3 };
        foreach (var a in x)
        {
            if(a != doorHasCar && a != doorPlayerChoosed)
            {
                buttons[a-1].image.sprite = inactiveButtons[a-1];
                buttons[a - 1].enabled = false;
                doors[a-1].SetActive(false);
                break;
            }
        }
    }

    public void DeclareTheResult(int door)
    {
        OpenAllDoors();
        DeleteAllButtons();
        if (door == doorHasCar)
        {
            win = true;
        }
        else
        {
            win = false;
        }
        Stats.RecordStats(doorPlayerChoosed, doorHasCar, win);
        ActivateTryAgainButton();
    }

    void ActivateTryAgainButton()
    {
        tryagainButton.gameObject.SetActive(true);
    }

    public void reset()
    {
        doorHasCar = 0;
        doorPlayerChoosed = 0;
        firstChoice = true;
        tryagainButton.gameObject.SetActive(false);
        foreach (var door in doors)
        {
            door.SetActive(true);
        }
        int a = 0;
        foreach (var button in buttons)
        {
            button.image.sprite = activeButtons[a];
            button.enabled = true;
            a++;
        }
        foreach (var goat in goats)
        {
            goat.SetActive(true);
        }
        foreach (var car in cars)
        {
            car.SetActive(false);
        }
        makeReadyScene();
    }


    private void Start()
    {
        makeReadyScene();
    }
     
}
