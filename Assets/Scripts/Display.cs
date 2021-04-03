using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    public Text Name;
    public Text Score;

    void Update()
    {
        Name.text = "Player: " + Data.playerName;
        Score.text = "Score: " + Data.scoreNum;
    }
}
