using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnapTime : MonoBehaviour
{

    public Text Correct;

    // Use this for initialization
    void Start()
    {
        Correct.text = "Replace Timing Belt - Incomplete";
    }

    // Update is called once per frame
    void Update()
    {

        if ((0.1f < transform.position.x) & (transform.position.x < 0.3f) & (transform.position.y < 0.7f) & (transform.position.y > 0.5f))
        {
            Correct.text = "Replace Timing Belt - Complete";
        }
        else
        {
            Correct.text = "Replace Timing Belt - Incomplete";
        }

    }



}
