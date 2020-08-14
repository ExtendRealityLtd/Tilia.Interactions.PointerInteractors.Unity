# Class DistanceGrabberConfigurator

Sets up the DistanceGrabber Prefab based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [grabPoint]
  * [hasSubscribedToInteractorEvents]
* [Properties]
  * [AlwaysCreateGrabPoint]
  * [Facade]
  * [Grabber]
  * [GrabListener]
  * [GrabProxy]
  * [Pointer]
  * [PropertyApplier]
  * [ReactivatePointerTimer]
  * [TargetValidityRules]
  * [UngrabListener]
* [Methods]
  * [CanCreateGrabPoint(GrabInteractableFollowAction)]
  * [ConfigureInteractor()]
  * [ConfigurePointerRules()]
  * [ConfigurePropertyApplier()]
  * [ConfigureReactivatePointerTimer()]
  * [CreateGrabPoint(RaycastHit)]
  * [DestroyGrabPoint()]
  * [OnDisable()]
  * [OnEnable()]
  * [PerformGrab(InteractableFacade)]
  * [PerformUngrab(InteractableFacade)]
  * [RegisterInteractorGrabListeners()]
  * [UnregisterInteractorGrabListeners()]

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

#### Facade

The public facade.

##### Declaration

```
public DistanceGrabberFacade Facade { get; protected set; }
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

#### CanCreateGrabPoint(GrabInteractableFollowAction)

Determines whether the grab point can be created for the given action.

##### Declaration

```
protected virtual bool CanCreateGrabPoint(GrabInteractableFollowAction action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| GrabInteractableFollowAction | action | The action to check whether a grab point can be created for. |

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

#### RegisterInteractorGrabListeners()

Registers the Interactor Grab listeners.

##### Declaration

```
protected virtual void RegisterInteractorGrabListeners()
```

#### UnregisterInteractorGrabListeners()

Unregisters the Interactor Grab listeners.

##### Declaration

```
protected virtual void UnregisterInteractorGrabListeners()
```

[Tilia.Interactions.PointerInteractors]: README.md
[DistanceGrabberFacade]: DistanceGrabberFacade.md
[InteractableGrabber]: InteractableGrabber.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[grabPoint]: #grabPoint
[hasSubscribedToInteractorEvents]: #hasSubscribedToInteractorEvents
[Properties]: #Properties
[AlwaysCreateGrabPoint]: #AlwaysCreateGrabPoint
[Facade]: #Facade
[Grabber]: #Grabber
[GrabListener]: #GrabListener
[GrabProxy]: #GrabProxy
[Pointer]: #Pointer
[PropertyApplier]: #PropertyApplier
[ReactivatePointerTimer]: #ReactivatePointerTimer
[TargetValidityRules]: #TargetValidityRules
[UngrabListener]: #UngrabListener
[Methods]: #Methods
[CanCreateGrabPoint(GrabInteractableFollowAction)]: #CanCreateGrabPointGrabInteractableFollowAction
[ConfigureInteractor()]: #ConfigureInteractor
[ConfigurePointerRules()]: #ConfigurePointerRules
[ConfigurePropertyApplier()]: #ConfigurePropertyApplier
[ConfigureReactivatePointerTimer()]: #ConfigureReactivatePointerTimer
[CreateGrabPoint(RaycastHit)]: #CreateGrabPointRaycastHit
[DestroyGrabPoint()]: #DestroyGrabPoint
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[PerformGrab(InteractableFacade)]: #PerformGrabInteractableFacade
[PerformUngrab(InteractableFacade)]: #PerformUngrabInteractableFacade
[RegisterInteractorGrabListeners()]: #RegisterInteractorGrabListeners
[UnregisterInteractorGrabListeners()]: #UnregisterInteractorGrabListeners
