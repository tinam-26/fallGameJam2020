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
        /*
        GameObject door1 = GameObject.Find("positiveDoor");
        GameObject door2 = GameObject.Find("negativeDoor");

        //go to random position
        //rounding change as warmup
        float nextSpotX = Random.Range(-6f, 6f);
        nextSpotX -= Mathf.Abs(nextSpotX) % .5f * Mathf.Sign(nextSpotX);
        float nextSpotY = Random.Range(-3.5f, 3.5f);
        nextSpotY -= Mathf.Abs(nextSpotY) % .5f * Mathf.Sign(nextSpotY);
        door1.transform.position = new Vector3(nextSpotX, nextSpotY, 0);
        Debug.Log("nextSpotX: " + nextSpotX + ", nextSpotY: " + nextSpotY);

        nextSpotX = Random.Range(-6f, 6f);
        nextSpotX -= Mathf.Abs(nextSpotX % .5f);
        nextSpotY = Random.Range(-3.5f, 3.5f);
        nextSpotY -= Mathf.Abs(nextSpotY % .5f);
        door2.transform.position = new Vector3(nextSpotX, nextSpotY, 0); /**/

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
            Debug.Log("collide2");
            winScore += 1;
            //handle random here
            SceneManager.LoadScene(mainScene);
        }else if(other.gameObject.tag == "negRoom"){
            winScore -= 1;
            SceneManager.LoadScene(mainScene);
        }else if(other.gameObject.tag == "goRoom"){
            
        }
    }
}
