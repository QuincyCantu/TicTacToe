using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownMashScript : MonoBehaviour
{
    public float timeValue = 15;
    private Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else 
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
            GameObject player1Score = GameObject.Find("Player1Score");
            GameObject player2Score = GameObject.Find("Player2Score");
            Player1PressCounter pressCount1 = player1Score.GetComponent<Player1PressCounter>();
            Player2PressCounter pressCount2 = player2Score.GetComponent<Player2PressCounter>();
            float score1 = pressCount1.scoreAmount;
            float score2 = pressCount2.scoreAmount;
            if(score1>score2)
            {
                SceneManager.LoadScene("Player1WinMash", LoadSceneMode.Single);
            }
            if(score2>score1)
            {
                SceneManager.LoadScene("Player2WinMash", LoadSceneMode.Single);
            }
        }

        timerText.text = Mathf.FloorToInt(timeToDisplay).ToString();

    }
}
