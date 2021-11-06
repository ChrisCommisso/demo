using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cardProducer : MonoBehaviour
{
    public GameObject parent;
    public GameObject card;
    // Start is called before the first frame update
    void Start()
    {
        print("start");
    }
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.L)) 
        {
            SceneManager.LoadScene(1);
        }
    }
    // FixedUpdate is called once per physics frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(card, Input.mousePosition, Quaternion.identity,parent.transform);
        }
    }
}
