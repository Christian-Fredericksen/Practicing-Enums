using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public enum EnemyState
    {
        Patrolling,
        Attacking,
        Chasing,
        Death
    }

    public EnemyState currentState;

    // Start is called before the first frame update
    void Start()
    {
        currentState = EnemyState.Patrolling; 
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentState)
        {
            case EnemyState.Patrolling:
                Debug.Log("Patrolling");
                break;
            case EnemyState.Attacking:
                Debug.Log("Attacking");
                break;
            case EnemyState.Chasing:
                Debug.Log("Chasing");
                break;
            case EnemyState.Death:
                Debug.Log("Death");
                break;
        }
    }
}
