# Class InteractableGrabber

Attempts to grab the given Interactable to the given Interactor.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [DelayInstruction]
  * [Grabbed]
  * [grabRoutine]
* [Properties]
  * [Interactable]
  * [Interactor]
* [Methods]
  * [CancelGrabRoutine()]
  * [DoGrab()]
  * [GrabAtEndOfFrame()]
  * [OnDisable()]

## Details

##### Inheritance

* System.Object
* InteractableGrabber

##### Namespace

* [Tilia.Interactions.PointerInteractors]

##### Syntax

```
public class InteractableGrabber : MonoBehaviour
```

### Fields

#### DelayInstruction

A reusable instance of WaitForEndOfFrame.

##### Declaration

```
protected static readonly WaitForEndOfFrame DelayInstruction
```

#### Grabbed

Emitted when the Grab has occurred.

##### Declaration

```
public InteractableGrabber.UnityEvent Grabbed
```

#### grabRoutine

The routine for managing the grab.

##### Declaration

```
protected Coroutine grabRoutine
```

### Properties

#### Interactable

The Interactable to grab.

##### Declaration

```
public InteractableFacade Interactable { get; set; }
```

#### Interactor

The Interactor to grab to.

##### Declaration

```
public InteractorFacade Interactor { get; set; }
```

### Methods

#### CancelGrabRoutine()

Cancels the existing running grab coroutine.

##### Declaration

```
protected virtual void CancelGrabRoutine()
```

#### DoGrab()

Attempts to grab the [Interactable] to the [Interactor].

##### Declaration

```
public virtual void DoGrab()
```

#### GrabAtEndOfFrame()

Performs the grab at the end of the current frame.

##### Declaration

```
protected virtual IEnumerator GrabAtEndOfFrame()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.IEnumerator | Coroutine enumerator. |

#### OnDisable()

##### Declaration

```
protected virtual void OnDisable()
```

[Tilia.Interactions.PointerInteractors]: README.md
[InteractableGrabber.UnityEvent]: InteractableGrabber.UnityEvent.md
[Interactable]: InteractableGrabber.md#Interactable
[Interactor]: InteractableGrabber.md#Interactor
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[DelayInstruction]: #DelayInstruction
[Grabbed]: #Grabbed
[grabRoutine]: #grabRoutine
[Properties]: #Properties
[Interactable]: #Interactable
[Interactor]: #Interactor
[Methods]: #Methods
[CancelGrabRoutine()]: #CancelGrabRoutine
[DoGrab()]: #DoGrab
[GrabAtEndOfFrame()]: #GrabAtEndOfFrame
[OnDisable()]: #OnDisable
