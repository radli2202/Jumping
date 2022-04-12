using UnityEngine;

public class Jumping : MonoBehaviour
{
    Rigidbody2D Rb;
    PlayerControllerMobile mobil_control;   
    [SerializeField] LayerMask _mlayer;
    [SerializeField] float _GroundHit,_jumpForce,_muvet;
    
    
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();      
        mobil_control = FindObjectOfType<PlayerControllerMobile>();
    }

   
    void Update()
    {
        jump();
        muvet();     
    }

    public  bool isGround => Physics2D.Raycast(transform.position, Vector2.down, _GroundHit, _mlayer.value);
    void jump()  {if (isGround) Rb.velocity = new Vector2(Rb.velocity.x, _jumpForce);}
    void muvet() { Rb.velocity = new Vector2(mobil_control.Horizontal() * _muvet,Rb.velocity.y);}

}
