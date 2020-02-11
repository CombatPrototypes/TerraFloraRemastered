// GENERATED AUTOMATICALLY FROM 'Assets/TEST/Input/BaseController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BaseController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @BaseController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BaseController"",
    ""maps"": [
        {
            ""name"": ""Traversal"",
            ""id"": ""616fb399-228b-4e0b-a1fb-cae022ce5b4f"",
            ""actions"": [
                {
                    ""name"": ""WASD"",
                    ""type"": ""Button"",
                    ""id"": ""9add7e2c-afb6-4557-92cf-5c503013c67d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b1b87c42-fe83-419c-bf14-0ad55b8fbd03"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Hold(duration=0.01),Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""19152e5f-bcb4-4429-aed7-4d5d69b2b365"",
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
                    ""id"": ""d1ccf01f-5874-421c-91be-d0cd2bab99c7"",
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
                    ""id"": ""e795a049-2330-4fb6-a8a7-d43fb61d45ef"",
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
                    ""id"": ""e44ffadb-44dd-4099-b374-f8f2c760adbd"",
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
            ""name"": ""Combat"",
            ""id"": ""da509877-2d80-48d7-bf97-307420f6bb34"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""85155510-d0a4-459e-af78-826297e795d4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HeavyAttack"",
                    ""type"": ""Button"",
                    ""id"": ""a7d7f092-55b1-400f-9c9f-9a287ad40b9c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ThirdAttack"",
                    ""type"": ""Button"",
                    ""id"": ""cebec307-a758-4f2e-8ee3-a65530a4ea37"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0f4012b9-18db-413f-bd3a-1a726aef912a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Tap,Hold(duration=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bef21bdd-4432-4aef-9a6e-2d1374aca7db"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Tap,Hold(duration=4)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeavyAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9d6dff5-13fe-42d7-a352-3797e9e3fdfd"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": ""Tap,Hold(duration=5)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThirdAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Traversal
        m_Traversal = asset.FindActionMap("Traversal", throwIfNotFound: true);
        m_Traversal_WASD = m_Traversal.FindAction("WASD", throwIfNotFound: true);
        // Combat
        m_Combat = asset.FindActionMap("Combat", throwIfNotFound: true);
        m_Combat_Attack = m_Combat.FindAction("Attack", throwIfNotFound: true);
        m_Combat_HeavyAttack = m_Combat.FindAction("HeavyAttack", throwIfNotFound: true);
        m_Combat_ThirdAttack = m_Combat.FindAction("ThirdAttack", throwIfNotFound: true);
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

    // Traversal
    private readonly InputActionMap m_Traversal;
    private ITraversalActions m_TraversalActionsCallbackInterface;
    private readonly InputAction m_Traversal_WASD;
    public struct TraversalActions
    {
        private @BaseController m_Wrapper;
        public TraversalActions(@BaseController wrapper) { m_Wrapper = wrapper; }
        public InputAction @WASD => m_Wrapper.m_Traversal_WASD;
        public InputActionMap Get() { return m_Wrapper.m_Traversal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TraversalActions set) { return set.Get(); }
        public void SetCallbacks(ITraversalActions instance)
        {
            if (m_Wrapper.m_TraversalActionsCallbackInterface != null)
            {
                @WASD.started -= m_Wrapper.m_TraversalActionsCallbackInterface.OnWASD;
                @WASD.performed -= m_Wrapper.m_TraversalActionsCallbackInterface.OnWASD;
                @WASD.canceled -= m_Wrapper.m_TraversalActionsCallbackInterface.OnWASD;
            }
            m_Wrapper.m_TraversalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @WASD.started += instance.OnWASD;
                @WASD.performed += instance.OnWASD;
                @WASD.canceled += instance.OnWASD;
            }
        }
    }
    public TraversalActions @Traversal => new TraversalActions(this);

    // Combat
    private readonly InputActionMap m_Combat;
    private ICombatActions m_CombatActionsCallbackInterface;
    private readonly InputAction m_Combat_Attack;
    private readonly InputAction m_Combat_HeavyAttack;
    private readonly InputAction m_Combat_ThirdAttack;
    public struct CombatActions
    {
        private @BaseController m_Wrapper;
        public CombatActions(@BaseController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attack => m_Wrapper.m_Combat_Attack;
        public InputAction @HeavyAttack => m_Wrapper.m_Combat_HeavyAttack;
        public InputAction @ThirdAttack => m_Wrapper.m_Combat_ThirdAttack;
        public InputActionMap Get() { return m_Wrapper.m_Combat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CombatActions set) { return set.Get(); }
        public void SetCallbacks(ICombatActions instance)
        {
            if (m_Wrapper.m_CombatActionsCallbackInterface != null)
            {
                @Attack.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack;
                @HeavyAttack.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnHeavyAttack;
                @HeavyAttack.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnHeavyAttack;
                @HeavyAttack.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnHeavyAttack;
                @ThirdAttack.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnThirdAttack;
                @ThirdAttack.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnThirdAttack;
                @ThirdAttack.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnThirdAttack;
            }
            m_Wrapper.m_CombatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @HeavyAttack.started += instance.OnHeavyAttack;
                @HeavyAttack.performed += instance.OnHeavyAttack;
                @HeavyAttack.canceled += instance.OnHeavyAttack;
                @ThirdAttack.started += instance.OnThirdAttack;
                @ThirdAttack.performed += instance.OnThirdAttack;
                @ThirdAttack.canceled += instance.OnThirdAttack;
            }
        }
    }
    public CombatActions @Combat => new CombatActions(this);
    public interface ITraversalActions
    {
        void OnWASD(InputAction.CallbackContext context);
    }
    public interface ICombatActions
    {
        void OnAttack(InputAction.CallbackContext context);
        void OnHeavyAttack(InputAction.CallbackContext context);
        void OnThirdAttack(InputAction.CallbackContext context);
    }
}
