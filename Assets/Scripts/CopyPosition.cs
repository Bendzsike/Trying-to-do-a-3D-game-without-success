using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour {
    [SerializeField] private Transform transTarget;

    // Update is called once per frame
    void Update() {
        transform.position = transTarget.position;
    }
}
