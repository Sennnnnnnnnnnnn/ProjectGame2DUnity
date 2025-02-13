﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour {
    public static UIManager instance;

    public GameObject startMenu;
    public InputField usernameField;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Debug.Log("instance already exists, destroying object!");
            Destroy(this);
        }
    }

    public void ConnectedToServer()
    {
        if(usernameField.text == "" || usernameField.text == null)
        {
            Debug.Log("Tên không được để trống!");
            return;
        }
        
        startMenu.SetActive(false);
        usernameField.interactable = false;
        Client.instance.ConnectToServer();

    }
}
