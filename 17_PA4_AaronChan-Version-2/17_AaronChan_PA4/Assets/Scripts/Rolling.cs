using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolling : MonoBehaviour
{
    public float MoveSpeed = 100;

    private Rigidbody thisRigibody;

    // Start is called before the first frame update
    void Start()
    {
        thisRigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MoveX = Input.GetAxis("Horizontal") * Vector3.right;

        Vector3 MoveZ = Input.GetAxis("Vertical") * Vector3.forward;

        Vector3 MoveDirection = MoveX + MoveZ;

        thisRigibody.AddForce(MoveDirection * MoveSpeed * Time.deltaTime);
    }
}
