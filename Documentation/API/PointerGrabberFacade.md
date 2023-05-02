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
  * [RaycastRules]
  * [TargetValidity]
  * [VelocityTracker]
* [Methods]
  * [OnAfterActivationActionChange()]
  * [OnAfterAutoGrabOnEnterChange()]
  * [OnAfterFollowSourceChange()]
  * [OnAfterGrabActionChange()]
  * [OnAfterLengthAxisActionChange()]
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

The [VelocityTracker] to use when applying velocity to the Interactor.

##### Declaration

```
public VelocityTracker VelocityTracker { get; set; }
```

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
[ActivationAction]: PointerGrabberFacade.md#ActivationAction
[AutoGrabOnEnter]: PointerGrabberFacade.md#AutoGrabOnEnter
[FollowSource]: PointerGrabberFacade.md#FollowSource
[GrabAction]: PointerGrabberFacade.md#GrabAction
[LengthAxisAction]: PointerGrabberFacade.md#LengthAxisAction
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
[RaycastRules]: #RaycastRules
[TargetValidity]: #TargetValidity
[VelocityTracker]: #VelocityTracker
[Methods]: #Methods
[OnAfterActivationActionChange()]: #OnAfterActivationActionChange
[OnAfterAutoGrabOnEnterChange()]: #OnAfterAutoGrabOnEnterChange
[OnAfterFollowSourceChange()]: #OnAfterFollowSourceChange
[OnAfterGrabActionChange()]: #OnAfterGrabActionChange
[OnAfterLengthAxisActionChange()]: #OnAfterLengthAxisActionChange
[OnAfterRaycastRulesChange()]: #OnAfterRaycastRulesChange
[OnAfterTargetValidityChange()]: #OnAfterTargetValidityChange
[OnAfterVelocityTrackerChange()]: #OnAfterVelocityTrackerChange
