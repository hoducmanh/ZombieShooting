using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelMenu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject settingMenuUI;
    [SerializeField] GameObject gameoverMenuUI;
    [SerializeField] GameObject player;
    [SerializeField] GameObject timer;
    [SerializeField] GameObject Appear;
    [SerializeField] PlayerControler playerProp;
    [SerializeField] private float countDownTime = 4f;
    bool isPlaying = true;
    void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        countDown();
    }
    public void Setting()
    {
        settingMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Back()
    {
        if (isPlaying == false)
        {

            settingMenuUI.SetActive(false);
            Time.timeScale = 0f;
        }
        else
        {
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
    private void countDown()
    {
        countDownTime -= Time.deltaTime;
        if(countDownTime <= 0)
        {
            Appear.SetActive(false);
        }
    }
}