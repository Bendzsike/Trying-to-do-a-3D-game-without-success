using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcceptButton : MonoBehaviour {
    public int winCon;
    public string strTag;
    public GuessUpperSide script;
    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == strTag) {
            if (script.upperSide == winCon && winCon != 0) {
                string currentLevel = SceneManager.GetActiveScene().name;
                if (currentLevel == "Level3") {
                    SceneManager.LoadScene("End Menu");
                }
                else {
                    string nextLevel = "Level" + ((currentLevel[currentLevel.Length - 1] - '0') + 1);
                    SceneManager.LoadScene(nextLevel);
                }
            }
            else if (winCon == 0){
                string currentLevel = SceneManager.GetActiveScene().name;
                if (currentLevel == "Level3") {
                    SceneManager.LoadScene("End Menu");
                }
                else {
                    string nextLevel = "Level" + ((currentLevel[currentLevel.Length - 1] - '0') + 1);
                    SceneManager.LoadScene(nextLevel);
                }
            }
        }
    }
}
