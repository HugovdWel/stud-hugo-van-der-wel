using System.Collections;
using UnityEngine;

public class LampController : MonoBehaviour
{
    public Material lampOnMaterial;
    public Material lampOffMaterial;

    public float minTimeUntilLampsFail;
    public float maxTimeUntilLampsFail;
    public float minTimeUntilLampsRestore;
    public float maxTimeUntilLampsRestore;

    public float blinkTime;
    public float blinkChance;

    public bool lampBlinksRandomly;
    public bool lampFailsOnSpawnerDisabled;

    private bool _blinking;
    private Light _light;
    private Renderer _renderer;

    private void OnEnable()

    {
        LightSwitchController.SetLightState += SetLightState;
        DisableSpawnerButton.StartDisableSpawnerEffect += StartDisableSpawnerEffect;
    }

    private void OnDisable()
    {
        LightSwitchController.SetLightState -= SetLightState;
        DisableSpawnerButton.StartDisableSpawnerEffect -= StartDisableSpawnerEffect;
    }

    private void Start()
    {
        _light = gameObject.GetComponent<Light>();
        _renderer = gameObject.GetComponent<Renderer>();
    }

    private void Update()
    {
        if (lampBlinksRandomly || !_light.enabled) return;
        if (Random.Range(0, (1000 / (int)blinkChance * 1000)) == 1)
        {
            StartCoroutine(BlinkLight(blinkTime));
        }
    }

    private void StartDisableSpawnerEffect()
    {
        SetLightState(true);
        if (!lampFailsOnSpawnerDisabled && _light.enabled) return;
        StartCoroutine(WaitForLampToFail(Random.Range(minTimeUntilLampsFail, maxTimeUntilLampsFail)));
    }

    private void SetLightState(bool state)
    {
        StopAllCoroutines();
        ChangeBulbToState(state);
    }

    private void ChangeBulbToState(bool state)
    {
        _light.enabled = state;
        _renderer.material = state ? lampOnMaterial : lampOffMaterial;
    }

    private IEnumerator BlinkLight(float duration)
    {
        if (!_light.enabled) yield break;
        
        ChangeBulbToState(false);
        yield return new WaitForSeconds(duration);
        ChangeBulbToState(true);
    }

    private IEnumerator WaitForLampToFail(float duration)
    {
        yield return new WaitForSeconds(duration);
        StartCoroutine(BlinkLight(Random.Range(minTimeUntilLampsRestore, maxTimeUntilLampsRestore)));
    }
}