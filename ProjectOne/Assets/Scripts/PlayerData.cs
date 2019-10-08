using UnityEngine;
[CreateAssetMenu]
public class PlayerData : GameArtData
{
    public WeaponData weapon;

    public void InstancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        newSprite.sprite = sprite;
        newSprite.color = color;
    }
}