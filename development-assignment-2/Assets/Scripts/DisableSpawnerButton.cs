using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableSpawnerButton : MonoBehaviour, INteractable
{
    public GameObject spawner;
    public GameObject button;
    public float disableTime;
    public Material buttonOnMaterial;
    public Material buttonOffMaterial;
    
    public delegate void DisableSpawnersTemporarily();

    public static event DisableSpawnersTemporarily StartDisableSpawnerEffect;

    private bool _disabled;

    private void Start()
    {
        _disabled = false;
    }

    private void OnEnable()
    {
        StartDisableSpawnerEffect += DisableSpawnerTemporarily;
    }
    private void OnDisable()
    {
        StartDisableSpawnerEffect -= DisableSpawnerTemporarily;
    }

    public void Interact()
    {
        if (_disabled) return;
        DisableSpawnerTemporarily();
        StartDisableSpawnerEffect?.Invoke();
    }

    private void DisableSpawnerTemporarily()
    {
        StopAllCoroutines();
        StartCoroutine(DisableSpawnerTemporarilyCoroutine());
    }

    private void DisableSpawner()
    {
        _disabled = true;
        spawner.GetComponent<EnemySpawnerController>().enabled = false;
        button.transform.GetComponent<Renderer>().material = buttonOffMaterial;
    }
    private void EnableSpawner()
    {
        _disabled = false;
        spawner.GetComponent<EnemySpawnerController>().enabled = true;
        button.transform.GetComponent<Renderer>().material = buttonOnMaterial;
    }

    private IEnumerator DisableSpawnerTemporarilyCoroutine()
    {
        DisableSpawner();
        yield return new WaitForSeconds(disableTime);
        EnableSpawner();
    }
}
