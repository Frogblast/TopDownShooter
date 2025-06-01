using UnityEngine;
using UnityEngine.InputSystem;
using TopDownShooter.Controls;

namespace TopDownShooter.Input
{
    public class InputHandler : MonoBehaviour
    {
        public InputActionAsset inputActions;
        private IEntityControl controller;

        private InputAction moveAction;
     //   private InputAction aimAction;
        private InputAction attackAction;

        private void OnEnable() => inputActions.FindActionMap("Player").Enable();
        private void OnDisable() => inputActions.FindActionMap("Player").Disable();

        private void Awake()
        {
            controller = GetComponent<PlayerControl>();

            moveAction = inputActions.FindAction("Move");
        //    aimAction = inputActions.FindAction("Aim");
            attackAction = inputActions.FindAction("Attack");
        }

        private void Update()
        {
            controller.Move(moveAction.ReadValue<Vector2>());
        //    controller.Look(aimAction.ReadValue<Vector2>());
            if (attackAction.WasPressedThisFrame())
            {
                controller.Attack();
            }
            controller.Look(Mouse.current.position.ReadValue()); // Only works for mouse. Add separate logic to handle controller.
        }
    }
}