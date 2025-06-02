using TopDownShooter.Controls;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TopDownShooter.Input
{
    public class PlayerInputHandler : MonoBehaviour
    {
        public InputActionAsset inputActions;
        private IEntityControl controller;

        private InputAction moveAction;
        private InputAction aimAction;
        private InputAction attackAction;


        private void OnEnable()
        {
            inputActions.FindActionMap("Player").Enable();
        }
        private void OnDisable()
        {
            inputActions.FindActionMap("Player").Disable();
        }

        private void Awake()
        {
            controller = GetComponent<EntityControl>();

            moveAction = inputActions.FindAction("Move");
            aimAction = inputActions.FindAction("Aim");
            attackAction = inputActions.FindAction("Attack");
        }

        private void Update()
        {
            controller.Move(moveAction.ReadValue<Vector2>());
            controller.Aim(aimAction.ReadValue<Vector2>());
            
            if (attackAction.WasPressedThisFrame())
            {
                controller.Attack();
            }
        }
    }
}