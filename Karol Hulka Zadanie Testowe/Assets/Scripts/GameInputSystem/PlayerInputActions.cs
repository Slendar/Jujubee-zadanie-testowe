//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/GameInputSystem/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""bb6ca9f2-a078-4b0e-acad-139b5d55f32a"",
            ""actions"": [
                {
                    ""name"": ""WeaponAttack"",
                    ""type"": ""Button"",
                    ""id"": ""db639f69-54fe-445a-aab2-ccfbb3b8469d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WeaponChange"",
                    ""type"": ""Button"",
                    ""id"": ""6a6f2f4c-ac9f-42c8-b51d-43b4840487f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CloseApplication"",
                    ""type"": ""Button"",
                    ""id"": ""f529a8be-cdfe-4cfe-b7dc-401f769f3957"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""22c91cf7-54dc-4415-84ac-d7d3b93b4401"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd9d5006-f787-4e42-a98b-152a2458639d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe7581aa-0c39-49c9-b79a-43defc4242ca"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseApplication"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_WeaponAttack = m_Player.FindAction("WeaponAttack", throwIfNotFound: true);
        m_Player_WeaponChange = m_Player.FindAction("WeaponChange", throwIfNotFound: true);
        m_Player_CloseApplication = m_Player.FindAction("CloseApplication", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_WeaponAttack;
    private readonly InputAction m_Player_WeaponChange;
    private readonly InputAction m_Player_CloseApplication;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @WeaponAttack => m_Wrapper.m_Player_WeaponAttack;
        public InputAction @WeaponChange => m_Wrapper.m_Player_WeaponChange;
        public InputAction @CloseApplication => m_Wrapper.m_Player_CloseApplication;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @WeaponAttack.started += instance.OnWeaponAttack;
            @WeaponAttack.performed += instance.OnWeaponAttack;
            @WeaponAttack.canceled += instance.OnWeaponAttack;
            @WeaponChange.started += instance.OnWeaponChange;
            @WeaponChange.performed += instance.OnWeaponChange;
            @WeaponChange.canceled += instance.OnWeaponChange;
            @CloseApplication.started += instance.OnCloseApplication;
            @CloseApplication.performed += instance.OnCloseApplication;
            @CloseApplication.canceled += instance.OnCloseApplication;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @WeaponAttack.started -= instance.OnWeaponAttack;
            @WeaponAttack.performed -= instance.OnWeaponAttack;
            @WeaponAttack.canceled -= instance.OnWeaponAttack;
            @WeaponChange.started -= instance.OnWeaponChange;
            @WeaponChange.performed -= instance.OnWeaponChange;
            @WeaponChange.canceled -= instance.OnWeaponChange;
            @CloseApplication.started -= instance.OnCloseApplication;
            @CloseApplication.performed -= instance.OnCloseApplication;
            @CloseApplication.canceled -= instance.OnCloseApplication;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnWeaponAttack(InputAction.CallbackContext context);
        void OnWeaponChange(InputAction.CallbackContext context);
        void OnCloseApplication(InputAction.CallbackContext context);
    }
}
