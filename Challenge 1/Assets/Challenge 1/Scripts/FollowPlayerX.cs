/*
 * Josh Beck
 * Challenge 1
 * Controls player camera
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        transform.position = offset;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
