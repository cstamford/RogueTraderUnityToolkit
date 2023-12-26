Tools for inspecting and manipulating asset bundles from Rogue Trader. Currently, it can export all of the asset bundles as text. End goal: produce a working Unity project export. Heavy emphasis on performance. The entire game imports and processes (parsing all objects) in under 5 seconds on my machine. Exporting all asset bundles takes 18 seconds (to memory) or 80~ seconds (50gb on disk). 4gb peak memory usage. P.S don't run it through your IDE if you care about perf. It disables optimizations and it takes a gazillion times longer.

tl;dr: like other tools, but working for 2022.3.7f1 (including managed references, which breaks both official UnityDataTools and all the others!) for programmers/modders.

Credits: UnityDataTools for some types. AssetRipper and AssetStudio for references when I was learning about the file structures.
