using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private Text Score;
    private int ScoreInt;
    // Start is called before the first frame update
    void Start()
    {
        Score = this.GetComponent<Text>();
        ScoreInt = 0;
        Score.text = ScoreInt.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            ScoreInt++;
            Score.text = ScoreInt.ToString();
        }
    }
}
