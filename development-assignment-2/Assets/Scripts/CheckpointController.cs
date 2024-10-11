using System;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    public GameObject colourBar;
    public Material unReachedCheckpointColour;
    public Material reachedCheckpointColour;
    public Material oldCheckpointColour;
    public Vector3 spawnLocationInCheckpoint;
    public string playerTag;
    
    public delegate void Checkpoint(CheckpointController checkPoint);
    public static event Checkpoint CheckPointReached;
    private Renderer _renderer;
    private bool _activated;

    private void Start()
    {
        _renderer = colourBar.GetComponent<Renderer>();
        _renderer.material = unReachedCheckpointColour;
        _activated = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_activated || !other.CompareTag(playerTag)) return;
        
        CheckPointReached?.Invoke(this);
        _renderer.material = reachedCheckpointColour;
        _activated = true;
    }

    public void SetCheckPointToOld()
    {
        _renderer.material = oldCheckpointColour;
    }
}
