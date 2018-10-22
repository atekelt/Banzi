using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour {

    public void select_scene(string name)
    {
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(name);
#pragma warning restore CS0618 // Type or member is obsolete
    }

    public void quitgame()
    {
        Application.Quit();
    }
}
