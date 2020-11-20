using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameManager gameManager;
    public SceneControl scenecontrol;
    public Stats stats;
    public HowToPlay htp;
    public ReklamRewarded r;
    public ReklamInterstitial i;
    public void FirstButton()
    {
        if (gameManager.firstChoice)
        {
            gameManager.eleminateTheGoat(1);
        }
        else
        {
            gameManager.DeclareTheResult(1);
        }
    }
    public void SecondButton()
    {
        if (gameManager.firstChoice)
        {
            gameManager.eleminateTheGoat(2);
        }
        else
        {
            gameManager.DeclareTheResult(2);
        }
    }
    public void ThirdButton()
    {
        if (gameManager.firstChoice)
        {
            gameManager.eleminateTheGoat(3);
        }
        else
        {
            gameManager.DeclareTheResult(3);
        }
    }

    public void Play()
    {
        scenecontrol.Play();
    }

    public void BackToTheMenu()
    {
        scenecontrol.Menu();
    }

    public void PlayAgain()
    {
        InterReklam();
        gameManager.reset();
    }

    public void Stats()
    {
        scenecontrol.Stats();
    }

    public void HowToPlay()
    {
        htp.showHTP();
    }

    public void disablehtp()
    {
        htp.panel.SetActive(false);
    }

    public void resetStats()
    {
        stats.reset();
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ReklamGoster()
    {
        r.RewardedReklamGoster();
    }

    public void InterReklam()
    {
        i.InterstitialGoster();
    }
}
