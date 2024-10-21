using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPart : MonoBehaviour
{
    private SpriteRenderer _compSpriteRenderer;
    // Start is called before the first frame update
    private void Awake()
    {
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetSprite(Sprite newSprite) {
        _compSpriteRenderer.sprite = newSprite;
    }
}
