using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name)
    {
        Debug.Log("try " + name);   // ispis na konzolu da vidimo ako se funkcija poziva
        Application.LoadLevel(name); // idemo na drugu scenu
    }


    public void QuitRequest()
    {
        Debug.Log("try Quit");   // ispis na konzolu da vidimo ako se funkcija poziva
        Application.Quit();
    }
}
