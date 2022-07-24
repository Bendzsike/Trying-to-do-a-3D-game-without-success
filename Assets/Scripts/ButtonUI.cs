using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour {
    [SerializeField] private string newGameLevel = "Level1";
    
    public void NewGameButton() {
        if (SceneManager.GetActiveScene().name == "Start Menu") {
            SceneManager.LoadScene(newGameLevel);
        } else if (SceneManager.GetActiveScene().name == "End Menu") {
            SceneManager.LoadScene("Start Menu");
        }
    }
}
