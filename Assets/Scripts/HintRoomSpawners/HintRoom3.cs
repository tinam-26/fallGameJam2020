using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintRoom3 : MonoBehaviour
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

            Vector2 nextSpot = new Vector2(nextSpotX, nextSpotY);
            doors[i].position = new Vector3(nextSpotX, nextSpotY, 0);

            hints[i].position = Vector2.Lerp(nextSpot, hints[5].position, .15f);

            if (i == 0)
            {
                hints[4].position = Vector2.Lerp(nextSpot, hints[5].position, .85f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
