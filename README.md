# BetterAttributes

Custom attributes package for Unity. Makes working with the Editor easier and more intuitive, especially while creating in-game items.

# Example

Here's an example of how to use BetterAttributes for the fields of a scriptable object:
```C#
using UnityEngine;
using BetterAttributes;

[CreateAssetMenu(menuName = "ScriptableObject/Item")]
public class Item : ScriptableObject
{
    [SerializeField, BetterIcon] private Sprite icon;
    [SerializeField, BetterSlider] private int damage;
    [SerializeField, BetterSlider(0, 1000)] private int speed;
}
```

If we go to Create => ScriptableObject => Item, the created scriptable object will appear in the editor like this:
<img width="668" height="170" alt="Screenshot 2025-12-27 173328" src="https://github.com/user-attachments/assets/8afe698c-0e04-4aae-baf2-1f2ceb55d2de" />


# How to install

### Via Package Manager (recommended)
Package Manager => "+" => Install package from git URL and paste in the following url:
```
https://github.com/tamtaasatiani/BetterAttributes.git
```

### Via manifest.json
Add the following URL to your manifest.json:
```
"dependencies": {
  "com.tamtaasatiani.betterattributes": "https://github.com/tamtaasatiani/BetterAttributes.git"
}
```

# License

This package is under the MIT license.
