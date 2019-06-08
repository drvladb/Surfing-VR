using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public GameObject Score;
    private Text ScoreText;
    private int ScoreInt;


    // Start is called before the first frame update
    void Start()
    {
        ScoreText = Score.GetComponent<Text>();
        //ScoreInt = 0;
        ScoreInt = PlayerPrefs.GetInt("Score", 0);
        ScoreText.text = ScoreInt.ToString();
    }
    public void addscore(int ammount)
    {
        ScoreInt=ScoreInt+ammount;
        ScoreText.text = ScoreInt.ToString();
        PlayerPrefs.SetInt("Score", ScoreInt);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //addscore(1);
            addscore(1);
        }
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
