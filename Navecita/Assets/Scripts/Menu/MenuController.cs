using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    [SerializeField]
    private Button btnGame;


	// Use this for initialization
	void Start () {
        btnGame.onClick.AddListener(() => goGame());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void goGame() {
        btnGame.onClick.RemoveAllListeners();
        SceneManager.LoadScene("Menu");
    }
}
