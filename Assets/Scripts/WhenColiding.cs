using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenColiding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("This is just the beginning -vlad");
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
