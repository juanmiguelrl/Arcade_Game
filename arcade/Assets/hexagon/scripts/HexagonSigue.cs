using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonSigue : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D rb;
    public float escala = 1;
    public float shrinkSpeed = 3f;
    public float reducerate;
    private GameObject variableText; //= GameObject.GetComponent<puntuacion>();
    private puntuacion puntuacion;

    public GameObject rec;
    private rec record;
    Spawner spawner;

    public LineRenderer renderer;
    public int r;
    public int g;
    public int b;

    public HexagonSigue(Spawner spawner) {
        this.spawner = spawner;
    }
    void Start()
    {
      //  rb.rotation = Random.Range(0f,360f);
      //List<int> rotation = new List<int>();
      Color c1 = Color.blue;
      Color color = new Vector4(PlayerPrefs.GetInt("r"), PlayerPrefs.GetInt("g"), PlayerPrefs.GetInt("b"), 200);
      //renderer.material.SetColor("green",color);
        renderer.SetColors(color,color);
      //int rotation = Random.Range(1,6);
       // rb.rotation = 60 *rotation;
        transform.localScale = Vector3.one * 15f * escala;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        shrinkSpeed = shrinkSpeed - reducerate;
        
        if(transform.localScale.x <= .05f) {
            Destroy(gameObject);
            GameObject variableText = GameObject.Find("record");
            record = variableText.GetComponent<rec>();
            record.addn();
        }
           // puntuacion = variableText.GetComponent<puntuacion>;
          // puntuacion = variableText.GetComponent<puntuacion>();
          // puntuacion.ShowCoins(variableText);       
        Color color = new Vector4(PlayerPrefs.GetFloat("r"), PlayerPrefs.GetFloat("g"), PlayerPrefs.GetFloat("b"), 200);
       // Debug.Log(PlayerPrefs.GetInt("r"));
        renderer.SetColors(color,color);
    }
}
