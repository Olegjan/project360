using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Change360Photo : MonoBehaviour
{
    public Texture2D texture360_1;
    public Texture2D texture360_2;
    bool chackerImg;
    
    // Start is called before the first frame update
    void Start()
    {
        ChangePhoto();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangePhoto()
    {
        if (chackerImg)
        {
            GetComponent<Renderer>().material.mainTexture = texture360_1;
        }
        else
        {
            GetComponent<Renderer>().material.mainTexture = texture360_2;
        }
        chackerImg = !chackerImg;
        Debug.Log("text");
    }
}
