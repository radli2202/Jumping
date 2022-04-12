using UnityEngine;
using UnityEngine.Events;


public class PlayerTrigger : MonoBehaviour
{
   
    int Scor;
    public UnityEvent<int> _score;
    GeneralManadger _generalManadger;

    private void Start()
    {
        _generalManadger = FindObjectOfType<GeneralManadger>();
        _score.Invoke(Scor);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Apple")
        {
            Scor++;
            _score.Invoke(Scor);
            if (Scor >= _generalManadger.Scorewin) _generalManadger.Win();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Finish")
        {
            _generalManadger.Full();
        }
    }
}
