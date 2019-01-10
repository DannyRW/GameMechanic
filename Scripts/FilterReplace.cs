using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FilterReplace : MonoBehaviour {

    public Text Correct;

    // Use this for initialization
    void Start()
    {
        Correct.text = "Fit Upgraded Air Filter - Incomplete";
    }

    // Update is called once per frame
    void Update()
    {

        

        if ((-0.05f > transform.position.x) && (transform.position.x > -0.07f))
        {
            Correct.text = "Fit Upgraded Air Filter - Complete";
        }
        else
        {
            Correct.text = "Fit Upgraded Air Filter - Incomplete";
        }

    }
}
