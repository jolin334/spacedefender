using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicator : MonoBehaviour
{
    System.Random rand;
    int x;
    int y;
    public GameObject ship;
    int[] array;



    // Start is called before the first frame update
    void Start()
    {
        array = new int[41];
        for (int i = 0; i < 41; i+=2)
        {

            print(i);

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}