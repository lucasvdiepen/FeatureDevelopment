using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInRangeChecker : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask _layer;

    public Enemy GetFirstEnemyInRange()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, _radius, _layer);
        
        if(cols.Length <= 0)
        {
            //no enemy in range
            return null;
        }

        return cols[0].GetComponent<Enemy>();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, _radius);
    }
}
