# Class DistanceGrabberFacade

The public interface into the DistanceGrabber Prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [AfterGrabbed]
  * [BeforeGrabbed]
  * [GrabCanceled]
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
  * [ClearFollowSource()]
  * [ClearInteractor()]
  * [ClearRaycastRules()]
  * [ClearTargetValidity()]
  * [OnAfterConfigureReactivatePointerTimerChange()]
  * [OnAfterFollowSourceChange()]
  * [OnAfterInteractorChange()]
  * [OnAfterRaycastRulesChange()]
  * [OnAfterTargetValidityChange()]
  * [OnAfterTransitionDurationChange()]
  * [OnAfterUngrabDelayChange()]

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

### Fields

#### AfterGrabbed

Emitted after the grab occurs.

##### Declaration

```
public DistanceGrabberFacade.UnityEvent AfterGrabbed
```

#### BeforeGrabbed

Emitted before the grab occurs.

##### Declaration

```
public DistanceGrabberFacade.UnityEvent BeforeGrabbed
```

#### GrabCanceled

Emitted if the grab occurrence is canceled.

##### Declaration

```
public DistanceGrabberFacade.UnityEvent GrabCanceled
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
public virtual InteractableFacade CurrentInteractable { get; }
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

#### ClearFollowSource()

Clears [FollowSource].

##### Declaration

```
public virtual void ClearFollowSource()
```

#### ClearInteractor()

Clears [Interactor].

##### Declaration

```
public virtual void ClearInteractor()
```

#### ClearRaycastRules()

Clears [RaycastRules].

##### Declaration

```
public virtual void ClearRaycastRules()
```

#### ClearTargetValidity()

Clears [TargetValidity].

##### Declaration

```
public virtual void ClearTargetValidity()
```

#### OnAfterConfigureReactivatePointerTimerChange()

##### Declaration

```
[Obsolete("Use `OnAfterUngrabDelayChange` instead.")]
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

#### OnAfterUngrabDelayChange()

Called after [UngrabDelay] has been changed.

##### Declaration

```
protected virtual void OnAfterUngrabDelayChange()
```

[Tilia.Interactions.PointerInteractors]: README.md
[DistanceGrabberFacade.UnityEvent]: DistanceGrabberFacade.UnityEvent.md
[DistanceGrabberConfigurator]: DistanceGrabberConfigurator.md
[Interactor]: DistanceGrabberFacade.md#Interactor
[FollowSource]: DistanceGrabberFacade.md#FollowSource
[Interactor]: DistanceGrabberFacade.md#Interactor
[RaycastRules]: DistanceGrabberFacade.md#RaycastRules
[TargetValidity]: DistanceGrabberFacade.md#TargetValidity
[FollowSource]: DistanceGrabberFacade.md#FollowSource
[Interactor]: DistanceGrabberFacade.md#Interactor
[RaycastRules]: DistanceGrabberFacade.md#RaycastRules
[TargetValidity]: DistanceGrabberFacade.md#TargetValidity
[TransitionDuration]: DistanceGrabberFacade.md#TransitionDuration
[UngrabDelay]: DistanceGrabberFacade.md#UngrabDelay
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[AfterGrabbed]: #AfterGrabbed
[BeforeGrabbed]: #BeforeGrabbed
[GrabCanceled]: #GrabCanceled
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
[ClearFollowSource()]: #ClearFollowSource
[ClearInteractor()]: #ClearInteractor
[ClearRaycastRules()]: #ClearRaycastRules
[ClearTargetValidity()]: #ClearTargetValidity
[OnAfterConfigureReactivatePointerTimerChange()]: #OnAfterConfigureReactivatePointerTimerChange
[OnAfterFollowSourceChange()]: #OnAfterFollowSourceChange
[OnAfterInteractorChange()]: #OnAfterInteractorChange
[OnAfterRaycastRulesChange()]: #OnAfterRaycastRulesChange
[OnAfterTargetValidityChange()]: #OnAfterTargetValidityChange
[OnAfterTransitionDurationChange()]: #OnAfterTransitionDurationChange
[OnAfterUngrabDelayChange()]: #OnAfterUngrabDelayChange
