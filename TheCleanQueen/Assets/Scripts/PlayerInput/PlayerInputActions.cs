//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Scripts/PlayerInput/PlayerInputActions.inputactions
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
            ""name"": ""Movement"",
            ""id"": ""6e762be1-c78b-4784-b6e7-0fb4bf038112"",
            ""actions"": [
                {
                    ""name"": ""WASD"",
                    ""type"": ""PassThrough"",
                    ""id"": ""60e284a4-b01e-4c54-afc5-4edc844ea79b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Mouse"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2e1737b1-59eb-46a5-ac25-91cb5f8ddfce"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""877fd122-ef9a-44b1-b636-9d1bd13dfd30"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""78d4ad41-be32-44ba-9691-c963f9d533e4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8de0c694-9b8f-4d5e-a125-4bad7e7fe1f6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bedf5202-0084-4013-b32e-2463aee6444c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2b7a8902-c947-4249-a156-dda86b26b1a8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""19a1dfac-34db-458c-bb92-2c37f7f329f1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""PlayerActionMap"",
            ""id"": ""f028c6f8-bc3e-46e5-ba90-8456b5ac6a3e"",
            ""actions"": [
                {
                    ""name"": ""Settings"",
                    ""type"": ""Button"",
                    ""id"": ""0a12982e-4cd5-4624-bb4e-54cc24b55986"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TowerButton"",
                    ""type"": ""Button"",
                    ""id"": ""d28663f3-e934-4aa9-a570-455da6cd825f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CloseTower"",
                    ""type"": ""Button"",
                    ""id"": ""9a0d7a25-174a-49e1-889c-5bd865e2c9a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TrashPickup"",
                    ""type"": ""Button"",
                    ""id"": ""f3a2d53e-b1cc-4488-b58b-b001bcb0ea4a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GetMoney"",
                    ""type"": ""Button"",
                    ""id"": ""6ad42b72-9a44-4508-8750-1d027edde5be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SkipWave"",
                    ""type"": ""Button"",
                    ""id"": ""9955cbb9-c880-4fae-bc4d-cb39b12fb34c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""KillEnemies"",
                    ""type"": ""Button"",
                    ""id"": ""146f7ad2-4260-4515-b4ae-a846a09f3468"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6809d754-0bf6-45b2-aeff-0d50c1aefcaa"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Settings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0f55cdf-8791-4380-88e9-293cc1fb4df5"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TowerButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4245a06-1d83-43ee-b81d-39ca62c1cce2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseTower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c352cc2-42f1-426e-bff6-3c207f153c54"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TrashPickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e073b459-6cb5-46d2-a6f3-1504d36e4430"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetMoney"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6acf34bb-d2a3-441b-bc91-8c81c678eb2f"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkipWave"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd65313e-59f1-4f1b-981a-a6ffa8fdae54"",
                    ""path"": ""<Keyboard>/f3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KillEnemies"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_WASD = m_Movement.FindAction("WASD", throwIfNotFound: true);
        m_Movement_Mouse = m_Movement.FindAction("Mouse", throwIfNotFound: true);
        // PlayerActionMap
        m_PlayerActionMap = asset.FindActionMap("PlayerActionMap", throwIfNotFound: true);
        m_PlayerActionMap_Settings = m_PlayerActionMap.FindAction("Settings", throwIfNotFound: true);
        m_PlayerActionMap_TowerButton = m_PlayerActionMap.FindAction("TowerButton", throwIfNotFound: true);
        m_PlayerActionMap_CloseTower = m_PlayerActionMap.FindAction("CloseTower", throwIfNotFound: true);
        m_PlayerActionMap_TrashPickup = m_PlayerActionMap.FindAction("TrashPickup", throwIfNotFound: true);
        m_PlayerActionMap_GetMoney = m_PlayerActionMap.FindAction("GetMoney", throwIfNotFound: true);
        m_PlayerActionMap_SkipWave = m_PlayerActionMap.FindAction("SkipWave", throwIfNotFound: true);
        m_PlayerActionMap_KillEnemies = m_PlayerActionMap.FindAction("KillEnemies", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private List<IMovementActions> m_MovementActionsCallbackInterfaces = new List<IMovementActions>();
    private readonly InputAction m_Movement_WASD;
    private readonly InputAction m_Movement_Mouse;
    public struct MovementActions
    {
        private @PlayerInputActions m_Wrapper;
        public MovementActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @WASD => m_Wrapper.m_Movement_WASD;
        public InputAction @Mouse => m_Wrapper.m_Movement_Mouse;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsCallbackInterfaces.Add(instance);
            @WASD.started += instance.OnWASD;
            @WASD.performed += instance.OnWASD;
            @WASD.canceled += instance.OnWASD;
            @Mouse.started += instance.OnMouse;
            @Mouse.performed += instance.OnMouse;
            @Mouse.canceled += instance.OnMouse;
        }

        private void UnregisterCallbacks(IMovementActions instance)
        {
            @WASD.started -= instance.OnWASD;
            @WASD.performed -= instance.OnWASD;
            @WASD.canceled -= instance.OnWASD;
            @Mouse.started -= instance.OnMouse;
            @Mouse.performed -= instance.OnMouse;
            @Mouse.canceled -= instance.OnMouse;
        }

        public void RemoveCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // PlayerActionMap
    private readonly InputActionMap m_PlayerActionMap;
    private List<IPlayerActionMapActions> m_PlayerActionMapActionsCallbackInterfaces = new List<IPlayerActionMapActions>();
    private readonly InputAction m_PlayerActionMap_Settings;
    private readonly InputAction m_PlayerActionMap_TowerButton;
    private readonly InputAction m_PlayerActionMap_CloseTower;
    private readonly InputAction m_PlayerActionMap_TrashPickup;
    private readonly InputAction m_PlayerActionMap_GetMoney;
    private readonly InputAction m_PlayerActionMap_SkipWave;
    private readonly InputAction m_PlayerActionMap_KillEnemies;
    public struct PlayerActionMapActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActionMapActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Settings => m_Wrapper.m_PlayerActionMap_Settings;
        public InputAction @TowerButton => m_Wrapper.m_PlayerActionMap_TowerButton;
        public InputAction @CloseTower => m_Wrapper.m_PlayerActionMap_CloseTower;
        public InputAction @TrashPickup => m_Wrapper.m_PlayerActionMap_TrashPickup;
        public InputAction @GetMoney => m_Wrapper.m_PlayerActionMap_GetMoney;
        public InputAction @SkipWave => m_Wrapper.m_PlayerActionMap_SkipWave;
        public InputAction @KillEnemies => m_Wrapper.m_PlayerActionMap_KillEnemies;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionMapActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActionMapActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionMapActionsCallbackInterfaces.Add(instance);
            @Settings.started += instance.OnSettings;
            @Settings.performed += instance.OnSettings;
            @Settings.canceled += instance.OnSettings;
            @TowerButton.started += instance.OnTowerButton;
            @TowerButton.performed += instance.OnTowerButton;
            @TowerButton.canceled += instance.OnTowerButton;
            @CloseTower.started += instance.OnCloseTower;
            @CloseTower.performed += instance.OnCloseTower;
            @CloseTower.canceled += instance.OnCloseTower;
            @TrashPickup.started += instance.OnTrashPickup;
            @TrashPickup.performed += instance.OnTrashPickup;
            @TrashPickup.canceled += instance.OnTrashPickup;
            @GetMoney.started += instance.OnGetMoney;
            @GetMoney.performed += instance.OnGetMoney;
            @GetMoney.canceled += instance.OnGetMoney;
            @SkipWave.started += instance.OnSkipWave;
            @SkipWave.performed += instance.OnSkipWave;
            @SkipWave.canceled += instance.OnSkipWave;
            @KillEnemies.started += instance.OnKillEnemies;
            @KillEnemies.performed += instance.OnKillEnemies;
            @KillEnemies.canceled += instance.OnKillEnemies;
        }

        private void UnregisterCallbacks(IPlayerActionMapActions instance)
        {
            @Settings.started -= instance.OnSettings;
            @Settings.performed -= instance.OnSettings;
            @Settings.canceled -= instance.OnSettings;
            @TowerButton.started -= instance.OnTowerButton;
            @TowerButton.performed -= instance.OnTowerButton;
            @TowerButton.canceled -= instance.OnTowerButton;
            @CloseTower.started -= instance.OnCloseTower;
            @CloseTower.performed -= instance.OnCloseTower;
            @CloseTower.canceled -= instance.OnCloseTower;
            @TrashPickup.started -= instance.OnTrashPickup;
            @TrashPickup.performed -= instance.OnTrashPickup;
            @TrashPickup.canceled -= instance.OnTrashPickup;
            @GetMoney.started -= instance.OnGetMoney;
            @GetMoney.performed -= instance.OnGetMoney;
            @GetMoney.canceled -= instance.OnGetMoney;
            @SkipWave.started -= instance.OnSkipWave;
            @SkipWave.performed -= instance.OnSkipWave;
            @SkipWave.canceled -= instance.OnSkipWave;
            @KillEnemies.started -= instance.OnKillEnemies;
            @KillEnemies.performed -= instance.OnKillEnemies;
            @KillEnemies.canceled -= instance.OnKillEnemies;
        }

        public void RemoveCallbacks(IPlayerActionMapActions instance)
        {
            if (m_Wrapper.m_PlayerActionMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActionMapActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActionMapActions @PlayerActionMap => new PlayerActionMapActions(this);
    public interface IMovementActions
    {
        void OnWASD(InputAction.CallbackContext context);
        void OnMouse(InputAction.CallbackContext context);
    }
    public interface IPlayerActionMapActions
    {
        void OnSettings(InputAction.CallbackContext context);
        void OnTowerButton(InputAction.CallbackContext context);
        void OnCloseTower(InputAction.CallbackContext context);
        void OnTrashPickup(InputAction.CallbackContext context);
        void OnGetMoney(InputAction.CallbackContext context);
        void OnSkipWave(InputAction.CallbackContext context);
        void OnKillEnemies(InputAction.CallbackContext context);
    }
}
