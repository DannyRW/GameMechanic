using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level1UI : MonoBehaviour {

    public Text GenBelt;
    public Text TimeBelt;
    public Text objectives;

	
	// Update is called once per frame
	void Update () {
		
        if (GenBelt.text == "false" & TimeBelt.text == "false")
        {
            objectives.text = "Current Objectives;\nReplace Timing Blet - Incomplete\nReplace Genrator Belt - Incomplete";
        }
        if (GenBelt.text == "true" & TimeBelt.text == "false")
        {
            objectives.text = "Current Objectives;\nReplace Timing Blet - Incomplete\nReplace Genrator Belt - Complete";
        }
        if (GenBelt.text == "false" & TimeBelt.text == "true")
        {
            objectives.text = "Current Objectives;\nReplace Timing Blet - Complete\nReplace Genrator Belt - Incomplete";
        }
        if (GenBelt.text == "true" & TimeBelt.text == "true")
        {
            objectives.text = "Current Objectives;\nReplace Timing Blet - Complete\nReplace Genrator Belt - Complete";
        }

    }
}
