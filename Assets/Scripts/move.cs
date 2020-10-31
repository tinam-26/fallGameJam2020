using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public string mainScene;
    public string currentScene;
    public string nextScene;
    public string failScene;
    private Rigidbody2D rb2d; 
    private int roomTotal; 
    private float winScore; 
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode){
        Debug.Log("nextScene");

        if(winScore >= 5){ 
            //player won
            Debug.Log("Player Won");
            SceneManager.LoadScene(mainScene); //update to win 
        }
    }
    // Update is called once per frame
    void Update()
    {
        float horz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (horz, vert, 0);
        transform.position = transform.position + movement * speed * Time.deltaTime;

    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("collide");
        if(other.gameObject.tag == "posRoom"){
            winScore += 1;
            //handle random here
            SceneManager.LoadScene(nextScene);
        }else if(other.gameObject.tag == "negRoom"){
            winScore -= 1;
            SceneManager.LoadScene(failScene);
        }else if(other.gameObject.tag == "goRoom"){
            
        }
    }
}
