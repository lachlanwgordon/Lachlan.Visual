Welcome to Lachlan.Visual

Please Call Lachlan.Visual.LachlanVisual.Init(); in your MainActivity.cs and your AppDelegate.

If you build your app with the linker set to LinkAll, please add Lachlan.Visual to the skipped assemblies in Android and --linkskip=Lachlan.Visual to the Additional mtouch arguments for iOS.

To use LachlanVisual set Visual="Lachlan" on any Controls or ContentPages you want to use the renderers. 

The renderers used in Lachlan.Visual are mostly un-modified Material Renderers from the Xamarin.Forms.Visual.Material package with a few tweaks to add case preserving buttons and pickers with titles/hints/

There's a blog post about creating your own Visual at https://lachlanwgordon.com/nugeting-a-custom-visual 

Source code at https://github.com/lachlanwgordon/Lachlan.Visual

Sample app https://github.com/lachlanwgordon/ExtendedVisualSample
