using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeControler : MonoBehaviour
{
    //[SerializeField]
    [SerializeField] private float timeMultiplier;
    [SerializeField] private float startHour;
    [SerializeField] private float startDay;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private float countDownTime = 30f;
    private DateTime currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = DateTime.Now.Date + TimeSpan.FromDays(startDay) + TimeSpan.FromHours(startHour);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimeOfDay();
    }

    private void UpdateTimeOfDay()
    {

        currentTime = currentTime.AddSeconds(Time.deltaTime + timeMultiplier);
        if(timeText != null)
        {
            timeText.text = currentTime.ToString("dd    HH.mm");
        }
        countDownTime -= Time.deltaTime;
        if(countDownTime <= 0)
        {
            SceneManager.LoadScene("NextLevel");
        }
    }
}
