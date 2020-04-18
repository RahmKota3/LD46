using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    public Action OnRestartButtonPressed;

    void CheckForInput()
    {
        if (Input.GetButtonDown("Restart"))
            OnRestartButtonPressed?.Invoke();
    }

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        CheckForInput();
    }
}
