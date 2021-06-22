 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 
 public class puntuacion : MonoBehaviour
 {
     public int n = 0;
     public int coins;
     public GameObject texto;
     public GameObject record;
 
    void Start()
    {
        record.GetComponent<UnityEngine.UI.Text>().text = "Record: " + PlayerPrefs.GetInt("puntuacion");
    }
    private void Update() {
       
    }
     public void ShowCoins (GameObject t)
     {
         n = n + 1;
         t.GetComponent<UnityEngine.UI.Text>().text = "Puntuación: " + n;
     }
     public void Addn (GameObject t)
     {
         n = n + 1;
     }
     public int GetN() {
         return n;
     }
 }