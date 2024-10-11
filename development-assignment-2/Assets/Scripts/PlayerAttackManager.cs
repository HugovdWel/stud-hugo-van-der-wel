using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerAttackManager : MonoBehaviour
{
    public GameObject projectilePrefab;
    public int maxAmountOfProjectiles;
    private List<GameObject> _currentProjectiles;

    private void Start()
    {
        _currentProjectiles = new List<GameObject>();
    }

    public void FireProjectileFromTransform(Transform player)
    {
        var projectile = Instantiate(projectilePrefab, player.position, Quaternion.identity);
        var projectileController = projectile.GetComponent<ProjectileController>();
        var forwardMovement = player.forward * projectileController.moveSpeed;
        projectileController.rb.AddForce(forwardMovement, ForceMode.Impulse);
        _currentProjectiles.Add(projectile);
        _DeleteProjectilesPastTheLimit();
    }

    private void _DeleteProjectilesPastTheLimit()
    {
        if (_currentProjectiles.Count <= maxAmountOfProjectiles) return;
        
        try
        {
            var deletingObject = _currentProjectiles.First();
            _currentProjectiles.Remove(deletingObject);
            Destroy(deletingObject);
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }
}