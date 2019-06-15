using System.Collections;
using System.Collections.Generic;
using UnityEngine;//Hot Garbadge (basicly s**t)
using UnityEngine.UI;

public class BuyObject : MonoBehaviour
{
    Button myButton;
    private int cost = 25;
    public GameObject sold;
    public bool objectsold;
    public int score;
    public GameObject scoreobject;
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("Score", 0);
    }
    private void Awake()
    {
        myButton = GetComponent<Button>(); // <-- you get access to the button component here

        myButton.onClick.AddListener(() => { myFunctionForOnClickEvent(); });  // <-- you assign a method to the button OnClick event here
        //myButton.onClick.AddListener(() => { myAnotherFunctionForOnClickEvent("stringValue", 3); }); // <-- you can assign multiple methods
    }
    // Update is called once per frame
    public void myFunctionForOnClickEvent()
    {
        if (score >= 25)
        {
            this.gameObject.SetActive(false);
            sold.SetActive(true);
            PlayerPrefs.SetInt("GotBall1", 1);
            PlayerPrefs.SetInt("Score", score - 25);
            score = score - 25;
            scoreobject.GetComponent<Text>().text = score.ToString();
        }
        else
        {
            print("thicccccc");
        }
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("GotBall1", 0) == 1)
        {
            this.gameObject.SetActive(false);
            sold.SetActive(true);
        }
    }
}
