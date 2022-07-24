using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour {
    [SerializeField] private KeyCode keyUp;
    [SerializeField] private KeyCode keyDown;
    [SerializeField] private KeyCode keyLeft;
    [SerializeField] private KeyCode keyRight;
    [SerializeField] private float maxVelocity = 20;
    [SerializeField]
    Vector3 v3XAxis;
    [SerializeField]
    Vector3 v3ZAxis;
    
    // Start is called before the first frame update
    void Start() {
        
    }

    private bool isMoving = false;
    // Update is called once per frame
    void FixedUpdate() {
        if (Input.GetKey(keyUp) && GetComponent<Rigidbody>().velocity.z <= maxVelocity && !isMoving) {
            GetComponent<Rigidbody>().velocity += v3ZAxis;
            isMoving = true;
        } else if (Input.GetKey(keyDown) && GetComponent<Rigidbody>().velocity.z >= -maxVelocity && !isMoving) {
            GetComponent<Rigidbody>().velocity -= v3ZAxis;
            isMoving = true;
        } else if (Input.GetKey(keyRight) && GetComponent<Rigidbody>().velocity.x <= maxVelocity && !isMoving) {
            GetComponent<Rigidbody>().velocity += v3XAxis;
            isMoving = true;
        } else if (Input.GetKey(keyLeft) && GetComponent<Rigidbody>().velocity.x >= -maxVelocity && !isMoving) {
            GetComponent<Rigidbody>().velocity -= v3XAxis;
            isMoving = true;
        }

        isMoving = false;
    }
}
