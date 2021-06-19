using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class readInput : MonoBehaviour
{
    private string input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(input == "Hola")
        {
            SceneManager.LoadScene(06);
        }
    }

    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
    }
}
