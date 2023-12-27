Tools for inspecting and manipulating asset bundles from Rogue Trader. Currently, it can export all of the asset bundles as text. End goal: produce a working Unity project export. It fully supports asset bundles from 2022.3.7f1 (all other tools fail on at least a few assets). Heavy emphasis on performance. The entire game imports and processes in under 15 seconds on my machine. Exporting all assets to disk takes 80~ seconds (50gb on disk).

Example object output:

```
$[MonoBehaviour]:m_GameObject:m_FileID$S32 = 0
$[MonoBehaviour]:m_GameObject:m_PathID$S64 = -650809873070036417
$[MonoBehaviour]:m_Enabled$U8 = 1
$[MonoBehaviour]:m_Script:m_FileID$S32 = 0
$[MonoBehaviour]:m_Script:m_PathID$S64 = -8990362273567350643
$[MonoBehaviour]:m_Name$String<0> = ""
$[MonoBehaviour]:m_Group:guid$String<32> = "a7045947f9a84d23a81d38e8a37287b7"
$[MonoBehaviour]:particleMap:m_FileID$S32 = 0
$[MonoBehaviour]:particleMap:m_PathID$S64 = 0
$[MonoBehaviour]:Data:Name$String<22> = "Locator_Torso_Upper_01"
$[MonoBehaviour]:Data:ParticleSize$F32 = 0.32
$[MonoBehaviour]:Data:LocalOffset:x$F32 = 0
$[MonoBehaviour]:Data:LocalOffset:y$F32 = 0
$[MonoBehaviour]:Data:LocalOffset:z$F32 = 0
$[MonoBehaviour]:Data:Rotate$U8 = 0
$[MonoBehaviour]:Data:CameraOffset$F32 = 0.23
$[MonoBehaviour]:Data:Flags$S32 = 0
$[MonoBehaviour]:bonesMap:m_FileID$S32 = 0
$[MonoBehaviour]:bonesMap:m_PathID$S64 = 0
```

Entry point for developers is at `RogueTraderUnityToolkit/Main.cs`. Pro tip: don't run it through your IDE if you care about perf. It disables optimizations and it takes a gazillion times longer.

Credits: UnityDataTools for some types. AssetRipper and AssetStudio for references when I was learning about the file structures.
