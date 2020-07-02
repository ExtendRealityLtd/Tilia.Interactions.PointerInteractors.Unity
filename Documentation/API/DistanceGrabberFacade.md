# Class DistanceGrabberFacade

The public interface into the DistanceGrabber Prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Configuration]
  * [Interactor]
  * [RaycastRules]
  * [TargetValidity]
  * [TransitionDuration]
  * [UngrabDelay]
* [Methods]
  * [OnAfterConfigureReactivatePointerTimerChange()]
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

#### Interactor

The InteractorFacade to grab to.

##### Declaration

```
public InteractorFacade Interactor { get; set; }
```

#### RaycastRules

Determines the rules for the pointer raycast.

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

The time in which it will take the interactable to transition to the interactor.

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
[UngrabDelay]: DistanceGrabberFacade.md#UngrabDelay
[Interactor]: DistanceGrabberFacade.md#Interactor
[RaycastRules]: DistanceGrabberFacade.md#RaycastRules
[TargetValidity]: DistanceGrabberFacade.md#TargetValidity
[TransitionDuration]: DistanceGrabberFacade.md#TransitionDuration
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Configuration]: #Configuration
[Interactor]: #Interactor
[RaycastRules]: #RaycastRules
[TargetValidity]: #TargetValidity
[TransitionDuration]: #TransitionDuration
[UngrabDelay]: #UngrabDelay
[Methods]: #Methods
[OnAfterConfigureReactivatePointerTimerChange()]: #OnAfterConfigureReactivatePointerTimerChange
[OnAfterInteractorChange()]: #OnAfterInteractorChange
[OnAfterRaycastRulesChange()]: #OnAfterRaycastRulesChange
[OnAfterTargetValidityChange()]: #OnAfterTargetValidityChange
[OnAfterTransitionDurationChange()]: #OnAfterTransitionDurationChange
