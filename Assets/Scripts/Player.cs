
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour{
    
    Rigidbody _rigidbody;
    public IPlayerInput PlayerInput { get; set; }

    private void Awake() {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.useGravity = false;
    }


    void Update(){
        float vertical = PlayerInput.Vertical;
        float moveSpeed = 100f;

        _rigidbody.AddForce(0,0,vertical * moveSpeed);
    }
}
