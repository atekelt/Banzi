using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public Text text;
    public int scores = 0;
    private int status = 1;
    
	void Start () {
        text.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
        
        scores = (manone.scoring() + mantwo.scoring() + manthree.scoring()) * status;

        currentscore();
	}
    
    void currentscore()
    {
        text.text = scores.ToString();
    }
}
