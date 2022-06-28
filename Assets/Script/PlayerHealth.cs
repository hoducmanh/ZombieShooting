using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth;
    public int currHealth;
    [SerializeField] GameObject gameoverMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        currHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(currHealth <= 0)
        {
            Time.timeScale = 0f;
            gameoverMenuUI.SetActive(true);
        }
    }

    public void HurtPlayer(int damageTaken)
    {
        currHealth -= damageTaken;
    }
}
