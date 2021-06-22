using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{

    public float moveSpeed = 600f;

    float movement = 0f;
    // Start is called before the first frame update
    new puntuacion puntuacion1;
    public GameObject variableText;
    void Start()
    {
        variableText.GetComponent<rec>().upr();
    }

    // Update is called once per frame
    void Update()
    {
     movement =   Input.GetAxisRaw("Horizontal");
     if ( Input.GetTouch(0).position.x > 500)
        movement = 1;
    else if ( Input.GetTouch(0).position.x < 500)
        movement = -1;
        Debug.Log(Input.GetTouch(0).position.x);
    }

    private void FixedUpdate() {
        
transform.RotateAround(Vector3.zero,Vector3.forward,movement * Time.fixedDeltaTime * -moveSpeed);

    }

    private void OnTriggerEnter2D(Collider2D collision) {
      //  int n = variableText.GetComponent<puntuacion>().GetN();
      //  if (PlayerPrefs.GetInt("p") < n)
      //      PlayerPrefs.SetInt("p", n);
      variableText.GetComponent<rec>().save();



        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }


}
