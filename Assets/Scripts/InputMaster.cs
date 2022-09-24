// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""8507b90f-d990-4d36-a859-ee0fb49cb974"",
            ""actions"": [
                {
                    ""name"": ""Controller"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0ee4e5dd-e24c-47e0-bbc4-a6cfd7ff3698"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""8bab7eef-1d00-4649-8107-b22f9a7bb3ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""ce4a16fb-14c6-4a66-8034-84da3ed9587c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""8f7554b7-2ad6-47fa-b68f-bc1b8068a8e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""99676d0f-fd16-4175-95f4-db0df95e07de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Options"",
                    ""type"": ""Button"",
                    ""id"": ""641c3c9b-d41a-471e-919e-f4b9cf450e1d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fdc25374-389f-45aa-89ae-038c07c75898"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcf8a657-85cb-4fe4-ac2e-3a0ee6efbba1"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9369c68d-ad1a-4e97-8599-d487cd03221b"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9379f88-52b8-4019-9a4a-3fe2874603bb"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf670dd0-bb94-4491-adb6-c912b3f698f2"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f0eeab7-8084-4432-8798-8301b70fe7fc"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Options"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Xbox Control Scheme"",
            ""bindingGroup"": ""Xbox Control Scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Controller = m_Player.FindAction("Controller", throwIfNotFound: true);
        m_Player_A = m_Player.FindAction("A", throwIfNotFound: true);
        m_Player_B = m_Player.FindAction("B", throwIfNotFound: true);
        m_Player_X = m_Player.FindAction("X", throwIfNotFound: true);
        m_Player_Y = m_Player.FindAction("Y", throwIfNotFound: true);
        m_Player_Options = m_Player.FindAction("Options", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Controller;
    private readonly InputAction m_Player_A;
    private readonly InputAction m_Player_B;
    private readonly InputAction m_Player_X;
    private readonly InputAction m_Player_Y;
    private readonly InputAction m_Player_Options;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Controller => m_Wrapper.m_Player_Controller;
        public InputAction @A => m_Wrapper.m_Player_A;
        public InputAction @B => m_Wrapper.m_Player_B;
        public InputAction @X => m_Wrapper.m_Player_X;
        public InputAction @Y => m_Wrapper.m_Player_Y;
        public InputAction @Options => m_Wrapper.m_Player_Options;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Controller.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnController;
                @Controller.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnController;
                @Controller.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnController;
                @A.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnB;
                @X.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnX;
                @Y.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnY;
                @Options.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOptions;
                @Options.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOptions;
                @Options.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOptions;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Controller.started += instance.OnController;
                @Controller.performed += instance.OnController;
                @Controller.canceled += instance.OnController;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
                @Options.started += instance.OnOptions;
                @Options.performed += instance.OnOptions;
                @Options.canceled += instance.OnOptions;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_XboxControlSchemeSchemeIndex = -1;
    public InputControlScheme XboxControlSchemeScheme
    {
        get
        {
            if (m_XboxControlSchemeSchemeIndex == -1) m_XboxControlSchemeSchemeIndex = asset.FindControlSchemeIndex("Xbox Control Scheme");
            return asset.controlSchemes[m_XboxControlSchemeSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnController(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
        void OnOptions(InputAction.CallbackContext context);
    }
}
