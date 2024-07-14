using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public GameObject Window;
    public KeyCode Key;
    private bool WindowActive = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            WindowActive = ! WindowActive;
            Window.SetActive(WindowActive);
        }
    }
}