using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonDealer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
        {
            other.attachedRigidbody.AddForce(this.gameObject.transform.forward*1000);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
