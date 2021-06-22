using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rec :MonoBehaviour
{
    public GameObject t;
    public GameObject actual;
    public int n = 0;
    // Start is called before the first frame update
    public void addn() {
        n = n + 1;
        Debug.Log("n =" + n);
        actual.GetComponent<UnityEngine.UI.Text>().text = "Puntuación actual: " + n;
    }

    public void save() {
        if (PlayerPrefs.GetInt("p") < n)
            PlayerPrefs.SetInt("p", n);
            Debug.Log("guardado n =" + n);
            Debug.Log("guardado en pref =" + PlayerPrefs.GetInt("p"));
    }

    public void upr() {
        t.GetComponent<UnityEngine.UI.Text>().text = "Mejor puntuación: " + PlayerPrefs.GetInt("p");

    }
}
