using UnityEngine;

public class GameManager_Script : MonoBehaviour
{
 //   Variables

    public GameObject Collectable;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 //  Make a function that (re)spawns a collectile

    public void Respawn () 
    {
         //     Spawn a collectivle at random location in bounds of walls
         //                                                     f is for float
          Instantiate (Collectable, new Vector2(Random.Range(-6f, 6f), Random.Range(-3f, 3f)), Collectable.transform.rotation);
     }
}