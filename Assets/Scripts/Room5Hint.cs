using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room5Hint : MonoBehaviour
{
    public SpriteRenderer sr;
    public Color clearColor;
    public Color origColor;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        origColor = sr.color;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            sr.color = clearColor;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        sr.color = origColor;
    }
}
