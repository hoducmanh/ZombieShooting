using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject mainMenuUI;
    [SerializeField] GameObject settingMenuUI;
    [SerializeField] GameObject gameoverMenuUI;
    [SerializeField] GameObject player;
    [SerializeField] GameObject timer;
    [SerializeField] PlayerControler playerProp;
    bool isPlaying = false;
    void Start()
    {
        Time.timeScale = 0f;
    }
    public void Play()
    {
        mainMenuUI.SetActive(false);
        settingMenuUI.SetActive(false);
        Time.timeScale = 1f;
        player.SetActive(true);
        timer.SetActive(true);
        isPlaying = true;
    }

    public void Setting()
    {
        
        mainMenuUI.SetActive(false);
        settingMenuUI.SetActive(true);
        timer.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Back()
    {
        if (isPlaying == false)
        {
            mainMenuUI.SetActive(true);
            settingMenuUI.SetActive(false);
            Time.timeScale = 0f;
        }
        else
        {
            timer.SetActive(true);
            settingMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void isLookingFalse()
    {
        playerProp.isLooking = false;
    }

    public void gameover()
    {
        SceneManager.LoadScene("Maingame");
    }
}
