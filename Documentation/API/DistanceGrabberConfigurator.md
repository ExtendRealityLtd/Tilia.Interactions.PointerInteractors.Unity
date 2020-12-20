# Class DistanceGrabberConfigurator

Sets up the DistanceGrabber Prefab based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [cachedKinematicState]
  * [grabPoint]
  * [hasSubscribedToInteractorEvents]
* [Properties]
  * [AlwaysCreateGrabPoint]
  * [DisablePointerOnInteractorTouch]
  * [EnablePointerContainer]
  * [Facade]
  * [ForceKinematicOnTransition]
  * [Grabber]
  * [GrabListener]
  * [GrabProxy]
  * [Pointer]
  * [PointerContainer]
  * [PropertyApplier]
  * [ReactivatePointerTimer]
  * [ShouldIgnoreEnablePointer]
  * [TargetValidityRules]
  * [UngrabListener]
* [Methods]
  * [CanCreateGrabPoint(GrabInteractableAction)]
  * [ConfigureInteractor()]
  * [ConfigurePointerRules()]
  * [ConfigurePropertyApplier()]
  * [ConfigureReactivatePointerTimer()]
  * [CreateGrabPoint(RaycastHit)]
  * [DestroyGrabPoint()]
  * [HasTouched(InteractableFacade)]
  * [HasUntouched(InteractableFacade)]
  * [MakeInteractableKinematic()]
  * [OnDisable()]
  * [OnEnable()]
  * [PerformGrab(InteractableFacade)]
  * [PerformUngrab(InteractableFacade)]
  * [RegisterInteractorListeners()]
  * [RestoreCachedInteractableKinematicState()]
  * [UnregisterInteractorListeners()]

## Details

##### Inheritance

* System.Object
* DistanceGrabberConfigurator

##### Namespace

* [Tilia.Interactions.PointerInteractors]

##### Syntax

```
public class DistanceGrabberConfigurator : MonoBehaviour
```

### Fields

#### cachedKinematicState

The kinematic state of the InteractableFacade.InteractableRigidbody before the transition period.

##### Declaration

```
protected bool cachedKinematicState
```

#### grabPoint

The point at which to use as the grab point offset for the transition.

##### Declaration

```
protected GameObject grabPoint
```

#### hasSubscribedToInteractorEvents

Whether the Interactor events have been subscribed to.

##### Declaration

```
protected bool hasSubscribedToInteractorEvents
```

### Properties

#### AlwaysCreateGrabPoint

Determines whether the grab point will be created always or only if the InteractableFacade has a follow action that is set to GrabInteractableFollowAction.OffsetType.PrecisionPoint.

##### Declaration

```
public bool AlwaysCreateGrabPoint { get; set; }
```

#### DisablePointerOnInteractorTouch

Whether to disable the pointer logic when the Facade.Interactor touches the InteractableFacade.

##### Declaration

```
public bool DisablePointerOnInteractorTouch { get; set; }
```

#### EnablePointerContainer

The container for the logic that enables the pointer.

##### Declaration

```
public GameObject EnablePointerContainer { get; protected set; }
```

#### Facade

The public facade.

##### Declaration

```
public DistanceGrabberFacade Facade { get; protected set; }
```

#### ForceKinematicOnTransition

Forces the InteractableFacade.InteractableRigidbody to be kinematic during the transition.

##### Declaration

```
public bool ForceKinematicOnTransition { get; set; }
```

#### Grabber

The [InteractableGrabber] that initiates the grabbing.

##### Declaration

```
public InteractableGrabber Grabber { get; protected set; }
```

#### GrabListener

The EmptyEventProxyEmitter that runs the grab logic.

##### Declaration

```
public EmptyEventProxyEmitter GrabListener { get; protected set; }
```

#### GrabProxy

The BooleanAction that proxies the Interactor's grab action.

##### Declaration

```
public BooleanAction GrabProxy { get; protected set; }
```

#### Pointer

The PointerFacade to initiate the grabbing.

##### Declaration

```
public PointerFacade Pointer { get; protected set; }
```

#### PointerContainer

The containing GameObject of the pointer logic.

##### Declaration

```
public GameObject PointerContainer { get; protected set; }
```

#### PropertyApplier

The TransformPropertyApplier that transitions the Interactable to the Interactor.

##### Declaration

```
public TransformPropertyApplier PropertyApplier { get; protected set; }
```

#### ReactivatePointerTimer

The CountdownTimer that controls when the pointer is reactivated.

##### Declaration

```
public CountdownTimer ReactivatePointerTimer { get; protected set; }
```

#### ShouldIgnoreEnablePointer

Whether to ignore the re-enabling of the pointer logic when the Facade.Interactor untouches.

##### Declaration

```
public bool ShouldIgnoreEnablePointer { get; set; }
```

#### TargetValidityRules

The RuleContainerObservableList that controls pointer target validity.

##### Declaration

```
public RuleContainerObservableList TargetValidityRules { get; protected set; }
```

#### UngrabListener

The EmptyEventProxyEmitter that runs the ungrab logic.

##### Declaration

```
public EmptyEventProxyEmitter UngrabListener { get; protected set; }
```

### Methods

#### CanCreateGrabPoint(GrabInteractableAction)

Determines whether the grab point can be created for the given action.

##### Declaration

```
protected virtual bool CanCreateGrabPoint(GrabInteractableAction action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| GrabInteractableAction | action | The action to check whether a grab point can be created for. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the grab point can be created. |

#### ConfigureInteractor()

Configures the relevant components that require knowledge of the Interactor.

##### Declaration

```
public virtual void ConfigureInteractor()
```

#### ConfigurePointerRules()

Configures the rules on the pointer.

##### Declaration

```
public virtual void ConfigurePointerRules()
```

#### ConfigurePropertyApplier()

Configures the property applier.

##### Declaration

```
public virtual void ConfigurePropertyApplier()
```

#### ConfigureReactivatePointerTimer()

Configures the reactivate pointer timer.

##### Declaration

```
public virtual void ConfigureReactivatePointerTimer()
```

#### CreateGrabPoint(RaycastHit)

Creates the grab point offset to transition the target Interactable towards.

##### Declaration

```
public virtual void CreateGrabPoint(RaycastHit hitData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| RaycastHit | hitData | The data to create the point with. |

#### DestroyGrabPoint()

Destroys any existing grab point.

##### Declaration

```
public virtual void DestroyGrabPoint()
```

#### HasTouched(InteractableFacade)

Handles the Facade.Interactor touching state.

##### Declaration

```
protected virtual void HasTouched(InteractableFacade interactable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InteractableFacade | interactable | The Interactable being touched. |

#### HasUntouched(InteractableFacade)

Handles the Facade.Interactor untouching state.

##### Declaration

```
protected virtual void HasUntouched(InteractableFacade interactable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InteractableFacade | interactable | The Interactable being touched. |

#### MakeInteractableKinematic()

Makes the InteractableFacade.InteractableRigidbody kinematic.

##### Declaration

```
public virtual void MakeInteractableKinematic()
```

#### OnDisable()

##### Declaration

```
protected virtual void OnDisable()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

#### PerformGrab(InteractableFacade)

Performs the grab logic.

##### Declaration

```
protected virtual void PerformGrab(InteractableFacade interactable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InteractableFacade | interactable | The Interactable being grabbed. |

#### PerformUngrab(InteractableFacade)

Performs the ungrab logic.

##### Declaration

```
protected virtual void PerformUngrab(InteractableFacade interactable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InteractableFacade | interactable | The Interactable being grabbed. |

#### RegisterInteractorListeners()

Registers the Interactor listeners.

##### Declaration

```
protected virtual void RegisterInteractorListeners()
```

#### RestoreCachedInteractableKinematicState()

Restores the InteractableFacade.InteractableRigidbody kinematic state to the value of [cachedKinematicState].

##### Declaration

```
public virtual void RestoreCachedInteractableKinematicState()
```

#### UnregisterInteractorListeners()

Unregisters the Interactor listeners.

##### Declaration

```
protected virtual void UnregisterInteractorListeners()
```

[Tilia.Interactions.PointerInteractors]: README.md
[DistanceGrabberFacade]: DistanceGrabberFacade.md
[InteractableGrabber]: InteractableGrabber.md
[cachedKinematicState]: DistanceGrabberConfigurator.md#cachedKinematicState
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[cachedKinematicState]: #cachedKinematicState
[grabPoint]: #grabPoint
[hasSubscribedToInteractorEvents]: #hasSubscribedToInteractorEvents
[Properties]: #Properties
[AlwaysCreateGrabPoint]: #AlwaysCreateGrabPoint
[DisablePointerOnInteractorTouch]: #DisablePointerOnInteractorTouch
[EnablePointerContainer]: #EnablePointerContainer
[Facade]: #Facade
[ForceKinematicOnTransition]: #ForceKinematicOnTransition
[Grabber]: #Grabber
[GrabListener]: #GrabListener
[GrabProxy]: #GrabProxy
[Pointer]: #Pointer
[PointerContainer]: #PointerContainer
[PropertyApplier]: #PropertyApplier
[ReactivatePointerTimer]: #ReactivatePointerTimer
[ShouldIgnoreEnablePointer]: #ShouldIgnoreEnablePointer
[TargetValidityRules]: #TargetValidityRules
[UngrabListener]: #UngrabListener
[Methods]: #Methods
[CanCreateGrabPoint(GrabInteractableAction)]: #CanCreateGrabPointGrabInteractableAction
[ConfigureInteractor()]: #ConfigureInteractor
[ConfigurePointerRules()]: #ConfigurePointerRules
[ConfigurePropertyApplier()]: #ConfigurePropertyApplier
[ConfigureReactivatePointerTimer()]: #ConfigureReactivatePointerTimer
[CreateGrabPoint(RaycastHit)]: #CreateGrabPointRaycastHit
[DestroyGrabPoint()]: #DestroyGrabPoint
[HasTouched(InteractableFacade)]: #HasTouchedInteractableFacade
[HasUntouched(InteractableFacade)]: #HasUntouchedInteractableFacade
[MakeInteractableKinematic()]: #MakeInteractableKinematic
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[PerformGrab(InteractableFacade)]: #PerformGrabInteractableFacade
[PerformUngrab(InteractableFacade)]: #PerformUngrabInteractableFacade
[RegisterInteractorListeners()]: #RegisterInteractorListeners
[RestoreCachedInteractableKinematicState()]: #RestoreCachedInteractableKinematicState
[UnregisterInteractorListeners()]: #UnregisterInteractorListeners
