using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerInput playerInput;

    void Awake()
    {
        playerInput = new PlayerInput();

        playerInput.CharacterControls.Move.started += Context => { Debug.Log(context.ReadValue<Vector2>()); };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
