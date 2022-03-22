using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int statsScript = childObject.transform.parent.gameObject.EnemyStats.HP;
        if (StatsScript.HP == 0)
        {
            gameObject.SetActive(false);
        }
    }
}
