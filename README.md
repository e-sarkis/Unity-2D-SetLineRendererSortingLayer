# Unity-2D-SetLineRendererSortingLayer
Trying to get your SpriteRenderers and LineRenderers to play nice in 2D Unity? Lines dissapearing behind sprites? Add the following script to any GameObject(s) with a LineRenderer component.

To use:
1. Import SetLineRendererSortingLayer.cs into your Unity project.
2. Add the Script via the Script Component to the GameObject(s) which have LineRenderers rendering behind sprites.
3. Set string reference SortingLayer in the component to the layer of choice, which can be found in Edit->Project Settings->Tags and Layers->Sorting Layers

Tested on Unity 5.6.1f1
