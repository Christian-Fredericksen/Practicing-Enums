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
        
    }
}
