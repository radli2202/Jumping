using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    
    [SerializeField] float _speed, _down_layer;
    [SerializeField] string [] _tagsoff;
    Transform PlayerTR;
    Transform tr_this;
    void Start()
    {
        PlayerTR = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        tr_this = GetComponent<Transform>();
    }

  
    void Update()
    {
        if(tr_this.position.y<= PlayerTR.position.y - _down_layer)
        {
            tr_this.Translate(Vector2.up * _speed);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        for(int i=0; i < _tagsoff.Length; i++)
        {
            if (collision.gameObject.tag == _tagsoff[i]) Destroy(collision.gameObject);
        }
       
    }



}
