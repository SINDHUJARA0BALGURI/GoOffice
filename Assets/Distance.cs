using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{

    // Start is called before the first frame update
    public Vector3 startpoint;
    public Vector3 endpoint;
    public Vector3 distance;

    void Start()
    {
        print(" welcome to gooficegame");
        print("please use uparrow  to move top, \n down arrow to move down, \n right arrow to move right \n press Qkey and Ekey to move");
        distance = endpoint - startpoint;
        print("the distance to office is" + distance.magnitude);
        if (startpoint.magnitude > endpoint.magnitude)
        {
            print("to move forward");
        }
        else if (startpoint.magnitude < endpoint.magnitude)
        {
            print(" to move backward");
        }
        else
        {
            print("reached to office ");
        }

    }


    // Update is called once per frame
    void Update()
    {
        PlayerMovement(KeyCode.W, new Vector3(0, 1, 0));
        PlayerMovement(KeyCode.S, new Vector3(0, -1, 0));
        PlayerMovement(KeyCode.A, new Vector3(-1, 0, 0));
        PlayerMovement(KeyCode.D, new Vector3(1, 0, 0));
        PlayerMovement(KeyCode.Q, new Vector3(0, 0, 1));
        PlayerMovement(KeyCode.E, new Vector3(0, 0, -1));

    }

    private void PlayerMovement(KeyCode arrow, Vector3 value)
    {

        NewMethod(arrow, value);

    }
    private void NewMethod(KeyCode arrow, Vector3 value)
    {
        if (Input.GetKeyDown(arrow))
        {
            startpoint = startpoint + value;
            distance = endpoint - startpoint;
            print("the distance to your office is: " + distance.magnitude);
            if (startpoint == endpoint)
            {
                print("You reached office");
            }
        }
    }
}

