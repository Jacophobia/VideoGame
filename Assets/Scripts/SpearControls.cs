// GENERATED AUTOMATICALLY FROM 'Assets/Input/SpearControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @SpearControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @SpearControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SpearControls"",
    ""maps"": [
        {
            ""name"": ""Spear"",
            ""id"": ""07d68186-f520-41ae-a5ec-3c516664522f"",
            ""actions"": [
                {
                    ""name"": ""Stab"",
                    ""type"": ""Value"",
                    ""id"": ""b6e18054-f7ca-47d9-afb4-55e44579d09c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""af847025-9fa2-422f-8dfe-e70163159386"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""06643cc8-7981-4492-ab68-ca84245cc17e"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Controller"",
                    ""action"": ""Stab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68a7affe-9b23-4e1e-a6be-b449ce8e6972"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38a8162f-2c8b-4426-89b5-63efd3d12d7d"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UserInterface"",
            ""id"": ""bf86d4fb-94db-4b5e-b1ec-9d5ebca03df3"",
            ""actions"": [
                {
                    ""name"": ""Unpause"",
                    ""type"": ""Button"",
                    ""id"": ""c7b302c4-1999-4b52-b780-916726241017"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aaa447b3-0578-4eb6-8813-615e4290edca"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Unpause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ccd1a53-14d6-4555-807d-267b7e347884"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Unpause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Spear
        m_Spear = asset.FindActionMap("Spear", throwIfNotFound: true);
        m_Spear_Stab = m_Spear.FindAction("Stab", throwIfNotFound: true);
        m_Spear_Pause = m_Spear.FindAction("Pause", throwIfNotFound: true);
        // UserInterface
        m_UserInterface = asset.FindActionMap("UserInterface", throwIfNotFound: true);
        m_UserInterface_Unpause = m_UserInterface.FindAction("Unpause", throwIfNotFound: true);
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

    // Spear
    private readonly InputActionMap m_Spear;
    private ISpearActions m_SpearActionsCallbackInterface;
    private readonly InputAction m_Spear_Stab;
    private readonly InputAction m_Spear_Pause;
    public struct SpearActions
    {
        private @SpearControls m_Wrapper;
        public SpearActions(@SpearControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Stab => m_Wrapper.m_Spear_Stab;
        public InputAction @Pause => m_Wrapper.m_Spear_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Spear; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SpearActions set) { return set.Get(); }
        public void SetCallbacks(ISpearActions instance)
        {
            if (m_Wrapper.m_SpearActionsCallbackInterface != null)
            {
                @Stab.started -= m_Wrapper.m_SpearActionsCallbackInterface.OnStab;
                @Stab.performed -= m_Wrapper.m_SpearActionsCallbackInterface.OnStab;
                @Stab.canceled -= m_Wrapper.m_SpearActionsCallbackInterface.OnStab;
                @Pause.started -= m_Wrapper.m_SpearActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_SpearActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_SpearActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_SpearActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Stab.started += instance.OnStab;
                @Stab.performed += instance.OnStab;
                @Stab.canceled += instance.OnStab;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public SpearActions @Spear => new SpearActions(this);

    // UserInterface
    private readonly InputActionMap m_UserInterface;
    private IUserInterfaceActions m_UserInterfaceActionsCallbackInterface;
    private readonly InputAction m_UserInterface_Unpause;
    public struct UserInterfaceActions
    {
        private @SpearControls m_Wrapper;
        public UserInterfaceActions(@SpearControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Unpause => m_Wrapper.m_UserInterface_Unpause;
        public InputActionMap Get() { return m_Wrapper.m_UserInterface; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UserInterfaceActions set) { return set.Get(); }
        public void SetCallbacks(IUserInterfaceActions instance)
        {
            if (m_Wrapper.m_UserInterfaceActionsCallbackInterface != null)
            {
                @Unpause.started -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnUnpause;
                @Unpause.performed -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnUnpause;
                @Unpause.canceled -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnUnpause;
            }
            m_Wrapper.m_UserInterfaceActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Unpause.started += instance.OnUnpause;
                @Unpause.performed += instance.OnUnpause;
                @Unpause.canceled += instance.OnUnpause;
            }
        }
    }
    public UserInterfaceActions @UserInterface => new UserInterfaceActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface ISpearActions
    {
        void OnStab(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IUserInterfaceActions
    {
        void OnUnpause(InputAction.CallbackContext context);
    }
}
