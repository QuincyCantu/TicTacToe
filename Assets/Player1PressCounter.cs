using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1PressCounter : MonoBehaviour
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
        if (Input.GetKeyDown("w"))
        {
            scoreAmount++;
            score.text = scoreAmount.ToString();
        }
    }
}
