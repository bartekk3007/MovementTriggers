using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)    
    {
        print(other.gameObject.name + " wszedl do szescianu");
    }
    void OnTriggerStay(Collider other) 
    {
        print(other.gameObject.name + " nadal pozostaje w szescianie");
    }
	void OnTriggerExit(Collider other) 
    {
        print(other.gameObject.name + " opuscil szescian");
    }
}
