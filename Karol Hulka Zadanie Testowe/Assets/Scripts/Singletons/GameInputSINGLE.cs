using System;
using UnityEngine;

public class GameInputSINGLE : MonoBehaviour
{
    public static GameInputSINGLE Instance { get; private set; }

    #region EVENTS
    public event EventHandler OnLeftClick;
    public event EventHandler OnRightClick;
    #endregion

    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("GameInputInstance already exists");
        }
        Instance = this;

        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();

        playerInputActions.Player.WeaponAttack.performed += WeaponAttack_performed;
        playerInputActions.Player.WeaponChange.performed += WeaponChange_performed;

        playerInputActions.Player.CloseApplication.performed += CloseApplication_performed;
    }

    private void WeaponAttack_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnLeftClick?.Invoke(this, EventArgs.Empty);
    }

    private void WeaponChange_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnRightClick?.Invoke(this, EventArgs.Empty);
    }

    private void CloseApplication_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Application.Quit();
        Debug.Log("Application Quit");
    }
}
