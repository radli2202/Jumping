using UnityEngine;

public class Border : MonoBehaviour
{
    Transform _this_tr;
    [SerializeField] public float _border;
     void Start()
    {
        _this_tr = GetComponent<Transform>();        
    }

    void Update()
    {
        border_out();
    }

    void border_out()
    {
        if (_this_tr.position.x < -_border)
            _this_tr.position = new Vector3(_this_tr.position.x + _border*2, _this_tr.position.y, _this_tr.position.z);
        else if (_this_tr.position.x > _border)
            _this_tr.position = new Vector3(_this_tr.position.x - _border*2, _this_tr.position.y, _this_tr.position.z);
    }


}
