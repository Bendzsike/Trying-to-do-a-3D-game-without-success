using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int speed = 300;
    bool isMoving = false;

    void Update() {
        if (isMoving) {
            return;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
            StartCoroutine(Roll(Vector3.right));
        } else if (Input.GetKey(KeyCode.LeftArrow)  || Input.GetKey(KeyCode.A)) {
            StartCoroutine(Roll(Vector3.left));
        } else if (Input.GetKey(KeyCode.UpArrow)  || Input.GetKey(KeyCode.W)) {
            StartCoroutine(Roll(Vector3.forward));
        } else if (Input.GetKey(KeyCode.DownArrow)  || Input.GetKey(KeyCode.S)) {
            StartCoroutine(Roll(Vector3.back));
        }
    }

    IEnumerator Roll(Vector3 direction) {
        isMoving = true;

        float remainingAngle = 90;
        Vector3 rotationCenter = transform.position + Vector3.Scale(direction + Vector3.down, transform.localScale) / 2;
        Vector3 rotationAxis = Vector3.Cross(Vector3.up, direction);

        while (remainingAngle > 0) {
            float rotationAngle = Mathf.Min(Time.deltaTime * speed, remainingAngle);
            transform.RotateAround(rotationCenter, rotationAxis, rotationAngle);
            remainingAngle -= rotationAngle;
            yield return null;
        }

        isMoving = false;
    }
}
