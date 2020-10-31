using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class buttonHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public string mainScene;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick(){
        Debug.Log("I HAVE RUN");
        SceneManager.LoadScene(mainScene);
    }
}
