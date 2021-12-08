# Unreal Engine - Animation Modifiers Extras

This plug-in is a collection of animation modifiers to use in your project

## Installation

You can use install this plugin as a submodule using the following command:

`git submodule add git@github.com:TheEmidee/UEAnimationModifiersExtras.git Plugins/AnimationModifiersExtras`

You can also download the ZIP file and manually extract the plugin in your `Plugins` directory.

## How to use

Follow [this documentation](https://docs.unrealengine.com/4.27/en-US/AnimatingObjects/SkeletalMeshAnimation/AnimModifiers/) page on the website of Unreal Engine.

## Animation modifiers list

### FootSyncMarkers

The implememtation is based on [this implementation](http://www.aclockworkberry.com/automated-foot-sync-markers-using-animation-modifiers-unreal-engine/), with more features.

This animation modifier creates [sync markers](https://docs.unrealengine.com/4.27/en-US/AnimatingObjects/SkeletalMeshAnimation/SyncGroups/) in animation sequences. It is most useful to generate sync markers when the foot bones cross the line between the pelvis and the floor.

This modifier can be configured to find tokens in the animation sequence name (like Forward / Bwd / 45 / 135), which will change how it detects when the bones to look at need a synchronization marker. This allows to create sync markers for all your locomotion animations if they all follow the same naming convention.

Basically, you want to set a reference direction to 
* (X:0;Y:1) for forward locomotion
* (X:0;Y:-1) for backward locomotion
* (X:-1;Y:0) for right locomotion
* (X:1;Y:0) for left locomotion

If you have locomotion for diagonal movement, you need new entries which affect both X and Y.