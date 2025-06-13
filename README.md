
- [ ] Task 1
  - Use Pooling Object for NewWaitForSeconds with Yielders.cs
- [x] Task 2  
- [x] Task 3
- [x] Task 4
- [x] Task 5
  - Implement MonoBehaviour inheritance across all game entities (Board, Item, Cell, etc.) to leverage Unity's component-based system
  - Implement **event-driven architecture** and split the project into modules (each module has a singleton-gameobject as the module-manager) for better decoupling, use GameManager as the center point of the project, GameManager will subscribes to all events from other modules and process based on each event-type 