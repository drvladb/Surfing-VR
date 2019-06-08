using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnToPlaygroundButton : MonoBehaviour
{
    Button myButton;
    // Start is called before the first frame update
    void Start()
    {
        myButton = GetComponent<Button>(); // <-- you get access to the button component here

        myButton.onClick.AddListener(() => { myFunctionForOnClickEvent(); });  // <-- you assign a method to the button OnClick event here
        //myButton.onClick.AddListener(() => { myAnotherFunctionForOnClickEvent("stringValue", 3); }); // <-- you can assign multiple methods
    }
    public void myFunctionForOnClickEvent()
    {
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
