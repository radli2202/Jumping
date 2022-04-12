using UnityEngine;

public class RandomBild : MonoBehaviour
{
    [SerializeField] GameObject [] Resurs,Platform;
    [SerializeField] float _uplevel;
    Transform Tr_this;
    float _borderLevel;
   
    void Start()
    {
        _borderLevel = this.transform.position.y + _uplevel;
        Tr_this = GetComponent<Transform>();
    }

   
    void Update()
    {       
        if (Tr_this.position.y >= _borderLevel) CreatPlatform();         
    }


    void CreatPlatform()
    {
        
        Vector2 b = Vector2.zero;
        b.x = Random.RandomRange(-4, 4);
        b.y = Random.RandomRange(Tr_this.position.y, Tr_this.position.y + 10); 
        GameObject newGo = Instantiate(Resurs[Random.RandomRange(0, Resurs.Length)], b, Quaternion.identity);

       
            Vector2 d = Vector2.zero;
            d.x = Random.RandomRange(-4, 4);
            d.y = Random.RandomRange(Tr_this.position.y, Tr_this.position.y + 5);          
            GameObject newTile = Instantiate(Platform[Random.RandomRange(0, Platform.Length)], d, Quaternion.identity);

        _borderLevel = Tr_this.position.y + _uplevel;
    }
  


}
