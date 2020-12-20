# Class DistanceGrabberFacade

The public interface into the DistanceGrabber Prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Configuration]
  * [CurrentInteractable]
  * [FollowSource]
  * [Interactor]
  * [RaycastRules]
  * [TargetValidity]
  * [TransitionDuration]
  * [UngrabDelay]
* [Methods]
  * [OnAfterConfigureReactivatePointerTimerChange()]
  * [OnAfterFollowSourceChange()]
  * [OnAfterInteractorChange()]
  * [OnAfterRaycastRulesChange()]
  * [OnAfterTargetValidityChange()]
  * [OnAfterTransitionDurationChange()]

## Details

##### Inheritance

* System.Object
* DistanceGrabberFacade

##### Namespace

* [Tilia.Interactions.PointerInteractors]

##### Syntax

```
public class DistanceGrabberFacade : MonoBehaviour
```

### Properties

#### Configuration

The linked Internal Setup.

##### Declaration

```
public DistanceGrabberConfigurator Configuration { get; protected set; }
```

#### CurrentInteractable

The current InteractableFacade being distance grabbed.

##### Declaration

```
public InteractableFacade CurrentInteractable { get; }
```

#### FollowSource

An optional source to get the internal pointer to follow. If one isn't provided then the [Interactor] will be used.

##### Declaration

```
public GameObject FollowSource { get; set; }
```

#### Interactor

The InteractorFacade to grab to.

##### Declaration

```
public InteractorFacade Interactor { get; set; }
```

#### RaycastRules

Determines the rules for the pointer RayCast.

##### Declaration

```
public PhysicsCast RaycastRules { get; set; }
```

#### TargetValidity

Determines which targets are valid to initiate the distance grab.

##### Declaration

```
public RuleContainer TargetValidity { get; set; }
```

#### TransitionDuration

The time in which it will take the Interactable to transition to the Interactor.

##### Declaration

```
public float TransitionDuration { get; set; }
```

#### UngrabDelay

The time in which to delay being able to distance grab again after ungrabbing.

##### Declaration

```
public float UngrabDelay { get; set; }
```

### Methods

#### OnAfterConfigureReactivatePointerTimerChange()

Called after [UngrabDelay] has been changed.

##### Declaration

```
protected virtual void OnAfterConfigureReactivatePointerTimerChange()
```

#### OnAfterFollowSourceChange()

Called after [FollowSource] has been changed.

##### Declaration

```
protected virtual void OnAfterFollowSourceChange()
```

#### OnAfterInteractorChange()

Called after [Interactor] has been changed.

##### Declaration

```
protected virtual void OnAfterInteractorChange()
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

#### OnAfterTransitionDurationChange()

Called after [TransitionDuration] has been changed.

##### Declaration

```
protected virtual void OnAfterTransitionDurationChange()
```

[Tilia.Interactions.PointerInteractors]: README.md
[DistanceGrabberConfigurator]: DistanceGrabberConfigurator.md
[Interactor]: DistanceGrabberFacade.md#Interactor
[UngrabDelay]: DistanceGrabberFacade.md#UngrabDelay
[FollowSource]: DistanceGrabberFacade.md#FollowSource
[Interactor]: DistanceGrabberFacade.md#Interactor
[RaycastRules]: DistanceGrabberFacade.md#RaycastRules
[TargetValidity]: DistanceGrabberFacade.md#TargetValidity
[TransitionDuration]: DistanceGrabberFacade.md#TransitionDuration
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Configuration]: #Configuration
[CurrentInteractable]: #CurrentInteractable
[FollowSource]: #FollowSource
[Interactor]: #Interactor
[RaycastRules]: #RaycastRules
[TargetValidity]: #TargetValidity
[TransitionDuration]: #TransitionDuration
[UngrabDelay]: #UngrabDelay
[Methods]: #Methods
[OnAfterConfigureReactivatePointerTimerChange()]: #OnAfterConfigureReactivatePointerTimerChange
[OnAfterFollowSourceChange()]: #OnAfterFollowSourceChange
[OnAfterInteractorChange()]: #OnAfterInteractorChange
[OnAfterRaycastRulesChange()]: #OnAfterRaycastRulesChange
[OnAfterTargetValidityChange()]: #OnAfterTargetValidityChange
[OnAfterTransitionDurationChange()]: #OnAfterTransitionDurationChange
