using UnityEngine;

public class Animated : MonoBehaviour
{
    Animator _anim;
    Jumping _jumpin;
    AudioSource sorse_Jump;


    void Start()
    {
        _anim = GetComponent<Animator>();
        _jumpin = GetComponent<Jumping>();
        sorse_Jump = GetComponent<AudioSource>();
        
    }
   
    void Update()
    {
        _anim.SetBool("Ground", _jumpin.isGround);
        if (_jumpin.isGround) sorse_Jump.Play();
    }


}
