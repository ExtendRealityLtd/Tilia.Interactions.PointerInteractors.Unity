# Class PointerGrabberFacade

The public interface into the PointerGrabber Prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [ActivationAction]
  * [AutoGrabOnEnter]
  * [Configuration]
  * [FollowSource]
  * [GrabAction]
  * [LengthAxisAction]
  * [LengthAxisMultiplier]
  * [RaycastRules]
  * [TargetValidity]
  * [VelocityTracker]
* [Methods]
  * [OnAfterActivationActionChange()]
  * [OnAfterAutoGrabOnEnterChange()]
  * [OnAfterFollowSourceChange()]
  * [OnAfterGrabActionChange()]
  * [OnAfterLengthAxisActionChange()]
  * [OnAfterLengthAxisMultiplierChange()]
  * [OnAfterRaycastRulesChange()]
  * [OnAfterTargetValidityChange()]
  * [OnAfterVelocityTrackerChange()]

## Details

##### Inheritance

* System.Object
* PointerGrabberFacade

##### Namespace

* [Tilia.Interactions.PointerInteractors]

##### Syntax

```
public class PointerGrabberFacade : MonoBehaviour
```

### Properties

#### ActivationAction

The Action to enable and disable the pointer with.

##### Declaration

```
public BooleanAction ActivationAction { get; set; }
```

#### AutoGrabOnEnter

Whether to attempt to automatically grab upon the pointer entering a valid target.

##### Declaration

```
public bool AutoGrabOnEnter { get; set; }
```

#### Configuration

The linked Internal Setup.

##### Declaration

```
public PointerGrabberConfigurator Configuration { get; set; }
```

#### FollowSource

The source to get the internal pointer to follow.

##### Declaration

```
public GameObject FollowSource { get; set; }
```

#### GrabAction

The Action to attempt to get the pointer interactor to grab.

##### Declaration

```
public BooleanAction GrabAction { get; set; }
```

#### LengthAxisAction

The Action control the fixed pointer length.

##### Declaration

```
public FloatAction LengthAxisAction { get; set; }
```

#### LengthAxisMultiplier

The multiplier value of the given length axis input to increase or reduce the speed of the pointer length change.

##### Declaration

```
public float LengthAxisMultiplier { get; set; }
```

#### RaycastRules

Determines the rules for the pointer RayCast.

##### Declaration

```
public PhysicsCast RaycastRules { get; set; }
```

#### TargetValidity

Determines which targets are valid to the pointer.

##### Declaration

```
public RuleContainer TargetValidity { get; set; }
```

#### VelocityTracker

An optional [VelocityTracker] to use when applying velocity to the Interactor.

##### Declaration

```
public VelocityTracker VelocityTracker { get; set; }
```

##### Remarks

If one is not provided then a default [VelocityTracker] will be used that tracks the pointer cursor.

### Methods

#### OnAfterActivationActionChange()

Called after [ActivationAction] has been changed.

##### Declaration

```
protected virtual void OnAfterActivationActionChange()
```

#### OnAfterAutoGrabOnEnterChange()

Called after [AutoGrabOnEnter] has been changed.

##### Declaration

```
protected virtual void OnAfterAutoGrabOnEnterChange()
```

#### OnAfterFollowSourceChange()

Called after [FollowSource] has been changed.

##### Declaration

```
protected virtual void OnAfterFollowSourceChange()
```

#### OnAfterGrabActionChange()

Called after [GrabAction] has been changed.

##### Declaration

```
protected virtual void OnAfterGrabActionChange()
```

#### OnAfterLengthAxisActionChange()

Called after [LengthAxisAction] has been changed.

##### Declaration

```
protected virtual void OnAfterLengthAxisActionChange()
```

#### OnAfterLengthAxisMultiplierChange()

Called after [LengthAxisMultiplier] has been changed.

##### Declaration

```
protected virtual void OnAfterLengthAxisMultiplierChange()
```

#### OnAfterRaycastRulesChange()

Called after [RaycastRules] has been changed.

##### Declaration

```
protected virtual void OnAfterRaycastRulesChange()
```

#### OnAfterTargetValidityChange()

Called after [TargetValidity] has been changed.

##### Declaration

```
protected virtual void OnAfterTargetValidityChange()
```

#### OnAfterVelocityTrackerChange()

Called after [VelocityTracker] has been changed.

##### Declaration

```
protected virtual void OnAfterVelocityTrackerChange()
```

[Tilia.Interactions.PointerInteractors]: README.md
[PointerGrabberConfigurator]: PointerGrabberConfigurator.md
[VelocityTracker]: PointerGrabberFacade.md#VelocityTracker
[VelocityTracker]: PointerGrabberFacade.md#VelocityTracker
[ActivationAction]: PointerGrabberFacade.md#ActivationAction
[AutoGrabOnEnter]: PointerGrabberFacade.md#AutoGrabOnEnter
[FollowSource]: PointerGrabberFacade.md#FollowSource
[GrabAction]: PointerGrabberFacade.md#GrabAction
[LengthAxisAction]: PointerGrabberFacade.md#LengthAxisAction
[LengthAxisMultiplier]: PointerGrabberFacade.md#LengthAxisMultiplier
[RaycastRules]: PointerGrabberFacade.md#RaycastRules
[TargetValidity]: PointerGrabberFacade.md#TargetValidity
[VelocityTracker]: PointerGrabberFacade.md#VelocityTracker
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[ActivationAction]: #ActivationAction
[AutoGrabOnEnter]: #AutoGrabOnEnter
[Configuration]: #Configuration
[FollowSource]: #FollowSource
[GrabAction]: #GrabAction
[LengthAxisAction]: #LengthAxisAction
[LengthAxisMultiplier]: #LengthAxisMultiplier
[RaycastRules]: #RaycastRules
[TargetValidity]: #TargetValidity
[VelocityTracker]: #VelocityTracker
[Methods]: #Methods
[OnAfterActivationActionChange()]: #OnAfterActivationActionChange
[OnAfterAutoGrabOnEnterChange()]: #OnAfterAutoGrabOnEnterChange
[OnAfterFollowSourceChange()]: #OnAfterFollowSourceChange
[OnAfterGrabActionChange()]: #OnAfterGrabActionChange
[OnAfterLengthAxisActionChange()]: #OnAfterLengthAxisActionChange
[OnAfterLengthAxisMultiplierChange()]: #OnAfterLengthAxisMultiplierChange
[OnAfterRaycastRulesChange()]: #OnAfterRaycastRulesChange
[OnAfterTargetValidityChange()]: #OnAfterTargetValidityChange
[OnAfterVelocityTrackerChange()]: #OnAfterVelocityTrackerChange
