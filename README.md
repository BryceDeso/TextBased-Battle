| Bryce Deshotel|
|:---|
|s208069|
|Computer Programming|
|Assessment-1 Documentation|

### I. Requirements

Task given: Create a program using C# that meets the specified requirements requested by the professors

1. Task Requirements

    - Use of variables, operators and expressions
    - Use of sequester, selection and iteration
    - Functions
    - At least two instances of the use of arrays to store primitive or custom data types
    - Reading and writing to a text file
    - Two classes that each contain four instance variables
    - Multiple options for object construction
    - User-defined aggregation
    - Use of polymorphism once for code extensibility
    - Code documentation

### II. Objects

##### File: Character.cs 

**Attributes**
    
    
    Name: _health
    Type: int
    Description: 

    Name: _damage
    Type: int
    Description: 

    Name: _name
    Type: string
    Description: 

    Name: Character() : Character(int, int)
    Type: Character
    Description: Initalizes _health, _damage, and _name. Has one overload that can change what _health and _damage are set to. 

    Name: Attack(Character)
    Type: int
    Description: Allows a character to attack another character.

    Name: TakeDamage(int)
    Type: int
    Description: Allows the enemy to take damage but wont let damage set health into negatives.

    Name: PrintStats(Character)
    Type: void
    Description: Prints character stats.

    Name: GetName()
    Type: string
    Description: Gets the _name of whatever called the funtion.

    Name: GetHealth()
    Type: int
    Description: Gets the _health of whatever called the funtion.        

    Name: GetDamage()
    Type: int
    Description: Gets the _damage of whatever called the function.


##### File: Game.cs

**Attributes**

   - Struct: Item

    Name: name
    Type: string
    Description: Used to define an item's name.

    Name: damage
    Type: int
    Description: Used to define an item's damage.

    Name: healthBoost
    Type: int
    Description: Used to define an item's healthBoost.

   - Class: Game

    Name: _gameOver
    Type: bool
    Description: Signifies when the game is over.

    Name: _player
    Type: Player
    Description: Is a new instance of the Player class.

    Name: _wizard
    Type: Wizard
    Description: Is a new instance of the Wizard class.

    Name: _bow
    Type: Item
    Description: Is an item that _player can equip and deal damage with.

    Name: _claymore
    Type: Item
    Description: Is an item that _player can equip and deal damage with.

    Name: _healthPotion
    Type: Item
    Description: Is an item the player can use to replenish health.

    Name: Run()
    Type: void
    Description: Used to run the program.

    Name: Start()
    Type: void
    Description: Preformed once the game begins.

    Name: Update()
    Type: void
    Description: This repeats until game ends.

    Name: End()
    Type: void
    Description: Preformed once the game ends.

    Name: CreateCharacter()
    Type: void
    Description: Initalizes the instances of _player and _wizard

    Name: GetInput(out char, string, string, string) : GetInput(out char, string, int, string, int, string)
    Type: void
    Description: Gets input from the player. Overload prints the damage of an item.

    Name: InitializeItems()
    Type: void
    Description: Sets values to any items added to game.

    Name: EquipWeapon()
    Type: void
    Description: Lets player pick a weapon and equip it in their inventory.

    Name: ViewInveotory(Player)
    Type: void
    Description: Prints a player's invetory an allows them to select an item.

    Name: BattleLoop
    Type: void
    Description: This is where the player will fight the enemy.



##### File: Player.cs

**Attributes**

    Name: _inventory
    Type: Item[]
    Description: Creates an array that will serve as the players inventory

    Name: Player(int, int)
    Type: constructor
    Description: Inherits from Character class, used to set default values.

    Name: HealPlayer(Player, int)
    Type: int
    Description: When used, it will a player by an item's healthBoost.

    Name: EquipItem(Player, int)
    Type: void
    Description:  Sets the player's damage to item's damage selected in inventory.


##### File: Weapon.cs

**Attributes**

    Name: _damage
    Type: int
    Description: Used to hold a value.

    Name: Weapon(int)
    Type: constructor
    Description: Sets the damage of a character.

    Name: GetDamage()
    Type: int
    Description: Returns _damage.

##### File: Wizard.cs

**Attributes**

    Name: _mana
    Type: int
    Description: 

    Name: Wizard()
    Type: constructor
    Description: Inherits from the Character class, used to set default values.

    Name: Attack(Character)
    Type: int
    Description: Is an override of Character's Attack function, this override just decrements the set amount of mana by seven.

    Name: PrintStats(Character)
    Type: void
    Description: Is an override of Character's PrintStats function, this override just displayes the current amount of mana. 







            



        

 
