using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changeSceneButton : MonoBehaviour
{
    [SerializeField]

    private InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(TryLoadScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TryLoadScene()
    {
        string sceneName = inputField.text;

        if(sceneName == "Hola, alguien me puede escuchar?")
        {
            SceneManager.LoadScene(07);
        }
    }
}
