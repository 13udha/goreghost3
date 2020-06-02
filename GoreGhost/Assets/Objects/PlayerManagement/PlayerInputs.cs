// GENERATED AUTOMATICALLY FROM 'Assets/Objects/PlayerManagement/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""90471198-2deb-41cf-b0c2-ff1cf085957e"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""ff619c57-9b8d-446c-aadf-518441cf20ce"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bef44eb2-8c2b-4bed-9d2e-bf32cf89651b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""457b16e5-4635-45f7-a8f9-642aff48a89b"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""e459d719-3bed-4d4b-91cc-53d24d547f76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""9cb125dc-83ea-4531-8f25-63c474c97f28"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Options"",
                    ""type"": ""Button"",
                    ""id"": ""b4f3d21b-6126-4685-896a-22488a78cfbe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2a089ecf-982e-4628-912f-f1a71e124523"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d7d53e0-8f3e-4ab1-9812-1ea3129b98b4"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ac34056-0c69-49ed-8b38-5928a9580724"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Options"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Movement = m_Gameplay.FindAction("Movement", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Select = m_Menu.FindAction("Select", throwIfNotFound: true);
        m_Menu_move = m_Menu.FindAction("move", throwIfNotFound: true);
        m_Menu_Options = m_Menu.FindAction("Options", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Movement;
    public struct GameplayActions
    {
        private @PlayerInputs m_Wrapper;
        public GameplayActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Gameplay_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Select;
    private readonly InputAction m_Menu_move;
    private readonly InputAction m_Menu_Options;
    public struct MenuActions
    {
        private @PlayerInputs m_Wrapper;
        public MenuActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_Menu_Select;
        public InputAction @move => m_Wrapper.m_Menu_move;
        public InputAction @Options => m_Wrapper.m_Menu_Options;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @move.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                @Options.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnOptions;
                @Options.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnOptions;
                @Options.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnOptions;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @Options.started += instance.OnOptions;
                @Options.performed += instance.OnOptions;
                @Options.canceled += instance.OnOptions;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IGameplayActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnOptions(InputAction.CallbackContext context);
    }
}
