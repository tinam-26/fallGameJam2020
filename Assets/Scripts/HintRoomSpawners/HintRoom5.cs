using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintRoom5 : MonoBehaviour
{
    public Transform[] hints;
    public Transform[] doors;

    // Start is called before the first frame update
    void Start()
    {
        
        ShufflePositions(doors);
        Debug.Log(doors.Length);

        for (int i = 0; i < doors.Length; i++)
        {
            if (doors[i].transform.position.x > 0)
            {
                Vector3 tempScale = doors[i].transform.localScale;
                tempScale = new Vector3(tempScale.x * -1, tempScale.y, tempScale.z);
                doors[i].transform.localScale = tempScale;
            }
        }

    }

    private void ShufflePositions(Transform[] s)
    {
        //just shuffle the array 100 times
        for (int i = 0; i < 100; i++)
        {
            for (int j = 1; j < s.Length; j++)
            {
                if (Random.Range(-1f, 1f) > 0)
                {
                    Vector3 tempTrans = s[j - 1].position;
                    s[j - 1].position = s[j].position;
                    s[j].position = tempTrans;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
