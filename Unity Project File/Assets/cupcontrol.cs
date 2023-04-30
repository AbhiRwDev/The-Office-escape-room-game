using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupcontrol : MonoBehaviour
{

    public bool IsInPlace;
    public Material green, red;
    // Start is called before the first frame update
    void Start()
    {
        IsInPlace = false;
    }

    // Update is called once per frame
    
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("cupholder"))
        {
            IsInPlace = true;
            other.GetComponent<Renderer>().material = green;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("cupholder"))
        {
            IsInPlace = false;
            other.GetComponent<Renderer>().material = red;
        }
    }
}
