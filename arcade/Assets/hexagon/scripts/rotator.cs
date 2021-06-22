using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    private int n = 0;
    private int colorchange = 0;
    private float vel = 0.8f;
    public Camera camera;
    private Color colorCamera;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("r",2); 
        PlayerPrefs.SetFloat("g",0);
        PlayerPrefs.SetFloat("b",0);  
    }

    // Update is called once per frame
    void Update()
    {
      //  transform.RotateAround(Vector3.forward, Time.deltaTime * 0.5f);
        PlayerPrefs.SetFloat("r",(PlayerPrefs.GetFloat("r") - 0.000f)); 
        if (PlayerPrefs.GetFloat("g") < 0f)
            colorchange = 0;
        if (PlayerPrefs.GetFloat("g") > 1f)
            colorchange = 1;
        if (colorchange == 0)
            PlayerPrefs.SetFloat("g",PlayerPrefs.GetFloat("g") + 0.001f);
        if (colorchange == 1)
            PlayerPrefs.SetFloat("g",PlayerPrefs.GetFloat("g") - 0.001f);
        //Debug.Log(PlayerPrefs.GetFloat("g"));
        PlayerPrefs.SetFloat("b",PlayerPrefs.GetFloat("b") - 0);
        Color colorCamera = new Vector4(0.5f, PlayerPrefs.GetFloat("g") - 0.1f, 0.5f, 200);
       // Debug.Log(PlayerPrefs.GetInt("r"));  colorCamera color = new Vector4(PlayerPrefs.GetFloat("r"), PlayerPrefs.GetFloat("g"), PlayerPrefs.GetFloat("b"), 200);
       // Debug.Log(PlayerPrefs.GetInt("r"));
        camera.backgroundColor = Color.Lerp(colorCamera, colorCamera, 10);
    }
    void FixedUpdate()
    {
        n = n + Random.Range(0,3);
        if (n % 250 < 10) 
            n = n + Random.Range(0,100);
        //Debug.Log(n%200);
        if ( n % 1000 < 500) 
            transform.RotateAround(Vector3.forward, Time.deltaTime * vel);
        else 
            transform.RotateAround(Vector3.forward, Time.deltaTime * -vel);
        if (n > 1000) {
            vel = Random.Range(0.5f,3f);
            n = n - 1000;
        }
    }
}
