using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            // Debug.Log("Trigger hit by: " + collision.name);
            logic.addScore(1);
        }
        
    }
}
