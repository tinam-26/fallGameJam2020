using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintRoom4T : MonoBehaviour
{
    public Transform[] hints;
    public Transform[] doors;
    // Start is called before the first frame update
    void Start()
    {
    
        for (int i = 0; i < doors.Length; i++)
        {
            float nextSpotX = Random.Range(-6f, 6f);
            nextSpotX -= Mathf.Abs(nextSpotX) % .5f * Mathf.Sign(nextSpotX);
            float nextSpotY = Random.Range(-3.5f, 3.5f);
            nextSpotY -= Mathf.Abs(nextSpotY) % .5f * Mathf.Sign(nextSpotY);

            doors[i].transform.position = new Vector3(nextSpotX, nextSpotY, 0);
            Vector2 nextSpot = new Vector2(nextSpotX, nextSpotY);
            hints[i].position = nextSpot + new Vector2(0.3f,0.2f);

            if (i == 0)
            {
                hints[3].position = nextSpot + new Vector2(0.3f,0.4f);
            }
        }

        hints[4].position = new Vector2(4f,4f);
        hints[5].position = new Vector2(4.2f,4.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
