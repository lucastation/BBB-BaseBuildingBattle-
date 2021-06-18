using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    internal PlayerInput inputScript;
    [SerializeField]
    internal PlayerMovement movementScript;
    [SerializeField]
    internal PlayerCollision collisionScript;
    [SerializeField]
    internal PlayerRayCasting rayCastScript;


    private void Awake()
    {

    }

}
