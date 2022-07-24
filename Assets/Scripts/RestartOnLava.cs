using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnLava : MonoBehaviour
{
    
    [SerializeField]
    string strTag;
    
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == strTag) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
