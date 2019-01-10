using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FilterRemove : MonoBehaviour {

    public Text Correct;

    // Use this for initialization
    void Start()
    {
        Correct.text = "Remove Air Filter - Incomplete";
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("x" + transform.position.x + " y " + transform.position.y);

        if ((0.8f < transform.position.x) || (transform.position.x < -0.3f))
        {
            Correct.text = "Remove Air Filter - Complete";
        }
        else
        {
            Correct.text = "Remove Air Filter - Incomplete";
        }

    }
}
