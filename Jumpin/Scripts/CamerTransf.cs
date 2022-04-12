using UnityEngine;

public class CamerTransf : MonoBehaviour
{
    [SerializeField] Transform PlayerTransform;
    Transform tr_this;
   
    void Start()
    {
        tr_this = GetComponent<Transform>();       
        PlayerTransform= GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    
    void Update()
    {
        tr_this.position = new Vector3(0, PlayerTransform.position.y, tr_this.position.z);
    }


}
