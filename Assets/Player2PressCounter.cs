using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2PressCounter : MonoBehaviour
{
    private Text score;
    public int scoreAmount;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        scoreAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            scoreAmount++;
            score.text = scoreAmount.ToString();
        }
    }
}
