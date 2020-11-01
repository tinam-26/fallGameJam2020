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
        //correctDir selects the correct direction to move in, 0 for left, 1 for up, 2 for right and 3 for down
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
        //0 for left, 1 for up, 2 for right and 3 for down
        int next = 0;
        switch (correctDir)
        {
            case 0:
                float smallestX = doors[0].transform.position.x;

                for (int i = 1; i < doors.Length; i++)
                {
                    if (doors[i].transform.position.x < smallestX)
                    {
                        smallestX = doors[i].transform.position.x;
                        next = i;
                    }
                    //if two doors are equally leftmost, move one over to the right
                    else if (doors[i].transform.position.x == smallestX)
                    {
                        Vector2 nextPos = new Vector2(doors[i].transform.position.x + .5f, doors[i].transform.position.y);
                        doors[i].transform.position = nextPos;
                    }
                }

                if (next != 0)
                {
                    Vector2 origPos = new Vector2(doors[0].transform.position.x, doors[0].transform.position.y);
                    doors[0].transform.position = doors[next].transform.position;
                    doors[next].transform.position = origPos;
                }
                break;

            case 1:
                float biggestY = doors[0].transform.position.y;

                for (int i = 1; i < doors.Length; i++)
                {
                    if (doors[i].transform.position.y > biggestY)
                    {
                        biggestY = doors[i].transform.position.y;
                        next = i;
                    }
                    else if (doors[i].transform.position.y == biggestY)
                    {
                        Vector2 nextPos = new Vector2(doors[i].transform.position.x, doors[i].transform.position.y - .5f);
                        doors[i].transform.position = nextPos;
                    }
                }

                if (next != 0)
                {
                    Vector2 origPos = new Vector2(doors[0].transform.position.x, doors[0].transform.position.y);
                    doors[0].transform.position = doors[next].transform.position;
                    doors[next].transform.position = origPos;
                }
                break;

            case 2:
                float biggestX = doors[0].transform.position.x;

                for (int i = 1; i < doors.Length; i++)
                {
                    if (doors[i].transform.position.x > biggestX)
                    {
                        biggestX = doors[i].transform.position.x;
                        next = i;
                    }
                    else if (doors[i].transform.position.x == biggestX)
                    {
                        Vector2 nextPos = new Vector2(doors[i].transform.position.x - .5f, doors[i].transform.position.y);
                        doors[i].transform.position = nextPos;
                    }
                }

                if (next != 0)
                {
                    Vector2 origPos = new Vector2(doors[0].transform.position.x, doors[0].transform.position.y);
                    doors[0].transform.position = doors[next].transform.position;
                    doors[next].transform.position = origPos;
                }
                break;

            case 3:
                float smallestY = doors[0].transform.position.x;

                for (int i = 1; i < doors.Length; i++)
                {
                    if (doors[i].transform.position.x < smallestY)
                    {
                        smallestY = doors[i].transform.position.y;
                        next = i;
                    }
                    else if (doors[i].transform.position.y == smallestY)
                    {
                        Vector2 nextPos = new Vector2(doors[i].transform.position.x, doors[i].transform.position.y + .5f);
                        doors[i].transform.position = nextPos;
                    }
                }

                if (next != 0)
                {
                    Vector2 origPos = new Vector2(doors[0].transform.position.x, doors[0].transform.position.y);
                    doors[0].transform.position = doors[next].transform.position;
                    doors[next].transform.position = origPos;
                }
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
