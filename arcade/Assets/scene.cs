using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadHexagon() {
        SceneManager.LoadScene("1");
    }
    public void LoadArcade2() {
    SceneManager.LoadScene("2");
    }

    public void reset() {
         PlayerPrefs.SetInt("p", 0);
    }
}
