using UnityEngine;

[CreateAssetMenu(fileName = "EnemyAttackSettings", menuName = "ScriptableObjects/EnemyAttackSettings")]
public class EnemyAttackSettings : ScriptableObject
{
    public float attackRange;
    public float attackSize;
    public float attackDuration;
    public float simultaneousTargetLocksRequiredForAttack;
    public float targetLockDuration;

    public GameObject attackAreaPrefab;
    public string attackAreaTag;
    public string attackProjectileTag;
    
    public Vector3 pointThatFieldDirectsPlayerTo;
}