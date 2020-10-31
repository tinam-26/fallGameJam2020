using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintRoom1 : MonoBehaviour
{
    public GameObject[] hints;
    public GameObject[] doors;

    private int correctDir;

    // Start is called before the first frame update
    void Start()
    {
        //correctDir selects the correct direction to move in, 0 for right, 1 for up, 2 for left and 3 for down
        correctDir = Random.Range(0, 4);

        hints[correctDir].SetActive(false);

        for (int i = 0; i < doors.Length; i++)
        {
            float nextSpotX = Random.Range(-6f, 6f);
            nextSpotX -= Mathf.Abs(nextSpotX) % .5f * Mathf.Sign(nextSpotX);
            float nextSpotY = Random.Range(-3.5f, 3.5f);
            nextSpotY -= Mathf.Abs(nextSpotY) % .5f * Mathf.Sign(nextSpotY);

            doors[i].transform.position = new Vector3(nextSpotX, nextSpotY, 0);
        }

        //TODO figure out which door was spawned at the top/left/ectmost location and switch locations with the correct door
        switch (correctDir)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
