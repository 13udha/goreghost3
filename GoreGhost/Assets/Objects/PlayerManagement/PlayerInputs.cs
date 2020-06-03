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
                },
                {
                    ""name"": ""NorthAction"",
                    ""type"": ""Button"",
                    ""id"": ""904123a1-caa0-41a4-9a19-59ce908c405f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EastAction"",
                    ""type"": ""Button"",
                    ""id"": ""474e3a6b-e40e-44eb-8a7f-6821117794d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SouthAction"",
                    ""type"": ""Button"",
                    ""id"": ""d57b8d3f-24d0-4328-a693-9d79abd9a15d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WestAction"",
                    ""type"": ""Button"",
                    ""id"": ""5008ed38-4f60-49cb-b2cc-12806267346b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R1"",
                    ""type"": ""Button"",
                    ""id"": ""4c12879b-c46f-4278-b698-6df9fb9327e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L1"",
                    ""type"": ""Button"",
                    ""id"": ""028d5034-947d-49d4-8de3-1b7bb5d12d4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""72453943-6c06-41af-92dc-47cfdf26b46f"",
                    ""expectedControlType"": ""Button"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""862ff627-e079-4c9c-943e-65d0594498e2"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NorthAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""462895d3-4e8c-4d6d-b5ef-cc78fff9d393"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EastAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38d0ae13-e31e-45b2-b17f-f6e393abbf29"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SouthAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24eb23e8-51cb-47c1-af3a-db4b4661b352"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WestAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00656783-b918-4faf-b5c3-3287310c69db"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""503dc4b6-3151-4afb-9b45-aeb2d267af51"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3c18ad6-52c2-4d21-92e9-f6e346cc3356"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
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
        m_Gameplay_NorthAction = m_Gameplay.FindAction("NorthAction", throwIfNotFound: true);
        m_Gameplay_EastAction = m_Gameplay.FindAction("EastAction", throwIfNotFound: true);
        m_Gameplay_SouthAction = m_Gameplay.FindAction("SouthAction", throwIfNotFound: true);
        m_Gameplay_WestAction = m_Gameplay.FindAction("WestAction", throwIfNotFound: true);
        m_Gameplay_R1 = m_Gameplay.FindAction("R1", throwIfNotFound: true);
        m_Gameplay_L1 = m_Gameplay.FindAction("L1", throwIfNotFound: true);
        m_Gameplay_Start = m_Gameplay.FindAction("Start", throwIfNotFound: true);
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
    private readonly InputAction m_Gameplay_NorthAction;
    private readonly InputAction m_Gameplay_EastAction;
    private readonly InputAction m_Gameplay_SouthAction;
    private readonly InputAction m_Gameplay_WestAction;
    private readonly InputAction m_Gameplay_R1;
    private readonly InputAction m_Gameplay_L1;
    private readonly InputAction m_Gameplay_Start;
    public struct GameplayActions
    {
        private @PlayerInputs m_Wrapper;
        public GameplayActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Gameplay_Movement;
        public InputAction @NorthAction => m_Wrapper.m_Gameplay_NorthAction;
        public InputAction @EastAction => m_Wrapper.m_Gameplay_EastAction;
        public InputAction @SouthAction => m_Wrapper.m_Gameplay_SouthAction;
        public InputAction @WestAction => m_Wrapper.m_Gameplay_WestAction;
        public InputAction @R1 => m_Wrapper.m_Gameplay_R1;
        public InputAction @L1 => m_Wrapper.m_Gameplay_L1;
        public InputAction @Start => m_Wrapper.m_Gameplay_Start;
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
                @NorthAction.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNorthAction;
                @NorthAction.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNorthAction;
                @NorthAction.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNorthAction;
                @EastAction.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEastAction;
                @EastAction.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEastAction;
                @EastAction.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEastAction;
                @SouthAction.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSouthAction;
                @SouthAction.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSouthAction;
                @SouthAction.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSouthAction;
                @WestAction.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWestAction;
                @WestAction.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWestAction;
                @WestAction.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWestAction;
                @R1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnR1;
                @R1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnR1;
                @R1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnR1;
                @L1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnL1;
                @L1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnL1;
                @L1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnL1;
                @Start.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @NorthAction.started += instance.OnNorthAction;
                @NorthAction.performed += instance.OnNorthAction;
                @NorthAction.canceled += instance.OnNorthAction;
                @EastAction.started += instance.OnEastAction;
                @EastAction.performed += instance.OnEastAction;
                @EastAction.canceled += instance.OnEastAction;
                @SouthAction.started += instance.OnSouthAction;
                @SouthAction.performed += instance.OnSouthAction;
                @SouthAction.canceled += instance.OnSouthAction;
                @WestAction.started += instance.OnWestAction;
                @WestAction.performed += instance.OnWestAction;
                @WestAction.canceled += instance.OnWestAction;
                @R1.started += instance.OnR1;
                @R1.performed += instance.OnR1;
                @R1.canceled += instance.OnR1;
                @L1.started += instance.OnL1;
                @L1.performed += instance.OnL1;
                @L1.canceled += instance.OnL1;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
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
        void OnNorthAction(InputAction.CallbackContext context);
        void OnEastAction(InputAction.CallbackContext context);
        void OnSouthAction(InputAction.CallbackContext context);
        void OnWestAction(InputAction.CallbackContext context);
        void OnR1(InputAction.CallbackContext context);
        void OnL1(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnOptions(InputAction.CallbackContext context);
    }
}
