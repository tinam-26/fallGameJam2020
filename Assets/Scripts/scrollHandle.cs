using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollHandle : MonoBehaviour
{
    public GameObject scrollingBlock;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("placeTile", 0.2f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void placeTile(){
        float x = Random.Range(-6f, 6f);
        GameObject newTile = Instantiate(scrollingBlock, new Vector3(x, 10, 0), Quaternion.identity);
        Rigidbody2D rgbd2D = newTile.GetComponent<Rigidbody2D>();
        rgbd2D.velocity = new Vector3(0,-5,0);
        Destroy(newTile, 2.0f);
    }
}
