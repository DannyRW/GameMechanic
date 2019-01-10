using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnapGen : MonoBehaviour {

    public Text Correct;

    // Use this for initialization
    void Start () {
        Correct.text = "Replace Generator Belt - Incomplete";
	}
	
	// Update is called once per frame
	void Update () {



        if ((0.1f < transform.position.x) & (transform.position.x < 0.2f) & (transform.position.y <0.3f) & (transform.position.y>0.2f))
        {
            Correct.text = "Replace Generator Belt - Complete";
        }
        else
        {
            Correct.text = "Replace Generator Belt - Incomplete";
        }
        
    }

    

}
